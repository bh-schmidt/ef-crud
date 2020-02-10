using Data.Context;
using Data.Repositories.Caminhoes;
using Models.Caminhoes;
using System;
using System.Threading.Tasks;

namespace Business.Caminhoes.AtualizarCaminhoes
{
    public class AtualizarCaminhao : IAtualizarCaminhao
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ICaminhaoRepository caminhaoRepository;
        private readonly IAtualizarCaminhaoValidator atualizarCaminhaoValidator;

        public AtualizarCaminhao(
            IUnitOfWork unitOfWork,
            ICaminhaoRepository caminhaoRepository,
            IAtualizarCaminhaoValidator atualizarCaminhaoValidator)
        {
            this.unitOfWork = unitOfWork;
            this.caminhaoRepository = caminhaoRepository;
            this.atualizarCaminhaoValidator = atualizarCaminhaoValidator;
        }

        public async Task<Caminhao> Atualizar(Caminhao caminhao)
        {
            try
            {
                await unitOfWork.BeginAsync();
                
                var resultado = await ProcessarAtualizacao(caminhao);
                
                if (caminhao.Valid)
                {
                    await unitOfWork.CommitAsync();
                    return caminhao;
                }

                await unitOfWork.RollbackAsync();

                return resultado;
            }
            catch (Exception ex)
            {
                await unitOfWork.RollbackAsync();
                throw ex;
            }
        }

        private async Task<Caminhao> ProcessarAtualizacao(Caminhao caminhao)
        {
            await caminhao.ValidarAsync(atualizarCaminhaoValidator);

            if (caminhao.Valid)
                await caminhaoRepository.AtualizarTudo(caminhao);

            return caminhao;
        }
    }
}
