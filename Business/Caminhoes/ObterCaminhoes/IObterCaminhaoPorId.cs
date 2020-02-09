using Models.Caminhoes;
using System.Threading.Tasks;

namespace Business.Caminhoes.ObterCaminhoes
{
    public interface IObterCaminhaoPorId
    {
        Task<Caminhao> ObterPor(long id);
    }
}
