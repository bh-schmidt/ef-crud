using Data.Context;
using Data.Repositories.Caminhoes;
using Models.Caminhoes;
using System;
using System.Threading.Tasks;

namespace Business.Caminhoes.InserirCaminhoes
{
    public class InserirCaminhao : IInserirCaminhao
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ICaminhaoRepository caminhaoRepository;
        private readonly IInserirCaminhaoValidator caminhaoValidator;

        public InserirCaminhao(
            IUnitOfWork unitOfWork,
            ICaminhaoRepository caminhaoRepository,
            IInserirCaminhaoValidator caminhaoValidator)
        {
            this.unitOfWork = unitOfWork;
            this.caminhaoRepository = caminhaoRepository;
            this.caminhaoValidator = caminhaoValidator;
        }

        public async Task<Caminhao> Inserir(Caminhao caminhao)
        {
            try
            {
                await unitOfWork.BeginAsync();
                var resultado = await ProcessarInsercao(caminhao);
                await unitOfWork.CommitAsync();

                return resultado;
            }
            catch (Exception ex)
            {
                await unitOfWork.RollbackAsync();
                throw ex;
            }
        }

        private async Task<Caminhao> ProcessarInsercao(Caminhao caminhao)
        {
            caminhao.Validar(caminhaoValidator);

            if (caminhao.Valid)
                await caminhaoRepository.Inserir(caminhao);

            return caminhao;
        }
    }
}
