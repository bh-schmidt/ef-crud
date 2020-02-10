using Models.Caminhoes;
using System.Threading.Tasks;

namespace Business.Caminhoes.InserirCaminhoes
{
    public interface IInserirCaminhao
    {
        public Task<Caminhao> Inserir(Caminhao caminhao);
    }
}
