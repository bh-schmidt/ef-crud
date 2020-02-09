using Models.Caminhoes;
using System.Threading.Tasks;

namespace Business.Caminhoes.AtualizarCaminhoes
{
    public interface IAtualizarCaminhao
    {
        public Task<Caminhao> Atualizar(Caminhao caminhao);
    }
}
