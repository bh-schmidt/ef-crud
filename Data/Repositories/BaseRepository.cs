using Data.Context;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utils.Extensions;

namespace Data.Repositories
{
    public abstract class BaseRepository<TModel> : IBaseRepository<TModel>
        where TModel : BaseModel
    {
        private readonly IUnitOfWork unitOfWork;

        protected BaseRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        protected EfCrudContext Context() => unitOfWork.Context();

        public async Task<IEnumerable<TModel>> ObterTodos() =>
            await Context().Set<TModel>().ToArrayAsync();

        public async Task<TModel> ObterPor(long id) =>
            await Context().Set<TModel>().FirstOrDefaultAsync(m => m.Id == id);

        public async Task Inserir(TModel model)
        {
            Context().Set<TModel>().Add(model);
            await Context().SaveChangesAsync();
        }

        public async Task AtualizarTudo(TModel model)
        {
            Context().Set<TModel>().Update(model);
            await Context().SaveChangesAsync();
        }

        public async Task Excluir(TModel model)
        {
            Context().Set<TModel>().Remove(model);
            await Context().SaveChangesAsync();
        }

        public async Task<bool> IdExistente(long id)
        {
            return await Context().Set<TModel>().AnyAsync(m => m.Id == id);
        }
    }
}
