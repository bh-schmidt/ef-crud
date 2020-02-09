using System.Threading.Tasks;

namespace Business.Caminhoes.ExcluirCaminhoes
{
    public interface IExcluirCaminhao
    {
        public Task Excluir(long id);
    }
}
