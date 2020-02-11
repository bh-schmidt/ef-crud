using Data.Context;
using Data.Repositories.Caminhoes;
using Models.Caminhoes;
using System;
using System.Threading.Tasks;

namespace Business.Caminhoes.ExcluirCaminhoes
{
    public class ExcluirCaminhao : IExcluirCaminhao
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ICaminhaoRepository caminhaoRepository;
        private readonly IExcluirCaminhaoValidator excluirCaminhaoValidator;

        public ExcluirCaminhao(
            IUnitOfWork unitOfWork,
            ICaminhaoRepository caminhaoRepository,
            IExcluirCaminhaoValidator excluirCaminhaoValidator)
        {
            this.unitOfWork = unitOfWork;
            this.caminhaoRepository = caminhaoRepository;
            this.excluirCaminhaoValidator = excluirCaminhaoValidator;
        }

        public async Task<Caminhao> Excluir(long id)
        {
            try
            {
                await unitOfWork.BeginAsync();

                var caminhao = await ProcessarExclusao(id);

                if (caminhao.Valid)
                {
                    await unitOfWork.CommitAsync();
                    return caminhao;
                }

                await unitOfWork.RollbackAsync();

                return caminhao;
            }
            catch
            {
                await unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task<Caminhao> ProcessarExclusao(long id)
        {
            var caminhao = new Caminhao() { Id = id };

            await caminhao.ValidarAsync(excluirCaminhaoValidator);

            if (caminhao.Valid)
                await caminhaoRepository.Excluir(caminhao);

            return caminhao;
        }
    }
}
