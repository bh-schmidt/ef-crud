using Data.Context;
using Data.Repositories.Caminhoes;
using System;
using System.Threading.Tasks;

namespace Business.Caminhoes.ExcluirCaminhoes
{
    public class ExcluirCaminhao : IExcluirCaminhao
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ICaminhaoRepository caminhaoRepository;

        public ExcluirCaminhao(
            IUnitOfWork unitOfWork, 
            ICaminhaoRepository caminhaoRepository)
        {
            this.unitOfWork = unitOfWork;
            this.caminhaoRepository = caminhaoRepository;
        }

        public async Task Excluir(long id)
        {
            try
            {
                await unitOfWork.BeginAsync();
                await ProcessarExclusao(id);
                await unitOfWork.CommitAsync();
            }
            catch (Exception ex)
            {
                await unitOfWork.RollbackAsync();
                throw ex;
            }
        }

        public async Task ProcessarExclusao(long id)
        {
            await caminhaoRepository.ExcluirPor(id);
        }
    }
}
