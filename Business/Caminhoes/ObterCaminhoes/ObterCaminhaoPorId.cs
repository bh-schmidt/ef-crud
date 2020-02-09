using Data.Context;
using Data.Repositories.Caminhoes;
using Models.Caminhoes;
using System.Threading.Tasks;

namespace Business.Caminhoes.ObterCaminhoes
{
    public class ObterCaminhaoPorId : IObterCaminhaoPorId
    {
        private readonly ICaminhaoRepository caminhaoRepository;

        public ObterCaminhaoPorId(
            ICaminhaoRepository caminhaoRepository)
        {
            this.caminhaoRepository = caminhaoRepository;
        }

        public Task<Caminhao> ObterPor(long id)
        {
            return caminhaoRepository.ObterPor(id);
        }
    }
}
