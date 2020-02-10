using Models.Caminhoes;
using System.Threading.Tasks;

namespace Business.Caminhoes.ExcluirCaminhoes
{
    public interface IExcluirCaminhao
    {
        public Task<Caminhao> Excluir(long id);
    }
}
