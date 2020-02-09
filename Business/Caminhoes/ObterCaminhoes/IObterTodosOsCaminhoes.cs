using Models.Caminhoes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Caminhoes.ObterCaminhoes
{
    public interface IObterTodosOsCaminhoes
    {
        public Task<IEnumerable<Caminhao>> ObterTodos();
    }
}
