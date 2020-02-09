using Data.Context;
using Data.Repositories.Caminhoes;
using Models.Caminhoes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Caminhoes.ObterCaminhoes
{
    public class ObterTodosOsCaminhoes : IObterTodosOsCaminhoes
    {
        private readonly ICaminhaoRepository caminhaoRepository;

        public ObterTodosOsCaminhoes(ICaminhaoRepository caminhaoRepository)
        {
            this.caminhaoRepository = caminhaoRepository;
        }
        public Task<IEnumerable<Caminhao>> ObterTodos()
        {
            return caminhaoRepository.ObterTodos();
        }
    }
}
