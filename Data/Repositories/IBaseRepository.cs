using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IBaseRepository<TModel>
        where TModel : BaseModel
    {
        public Task<IEnumerable<TModel>> ObterTodos();
        public Task<TModel> ObterPor(long id);
        public Task Inserir(TModel model);
        public Task AtualizarTudo(TModel model);
        public Task ExcluirPor(long id);
        public Task<bool> ModelExistente(long id);
    }
}
