using Business.Caminhoes.AtualizarCaminhoes;
using Business.Caminhoes.ExcluirCaminhoes;
using Business.Caminhoes.InserirCaminhoes;
using Business.Caminhoes.ObterCaminhoes;
using Microsoft.AspNetCore.Mvc;
using Models.Caminhoes;
using System.Threading.Tasks;

namespace Api.Controllers.Caminhoes
{
    public class CaminhoesController : BaseController
    {
        private readonly IInserirCaminhao inserirCaminhao;
        private readonly IObterTodosOsCaminhoes obterTodosOsCaminhoes;
        private readonly IAtualizarCaminhao atualizarCaminhao;
        private readonly IObterCaminhaoPorId obterCaminhaoPorId;
        private readonly IExcluirCaminhao excluirCaminhao;

        public CaminhoesController(
            IInserirCaminhao inserirCaminhao,
            IObterTodosOsCaminhoes obterTodosOsCaminhoes,
            IAtualizarCaminhao atualizarCaminhao,
            IObterCaminhaoPorId obterCaminhaoPorId,
            IExcluirCaminhao excluirCaminhao)
        {
            this.inserirCaminhao = inserirCaminhao;
            this.obterTodosOsCaminhoes = obterTodosOsCaminhoes;
            this.atualizarCaminhao = atualizarCaminhao;
            this.obterCaminhaoPorId = obterCaminhaoPorId;
            this.excluirCaminhao = excluirCaminhao;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var caminhoes = await obterTodosOsCaminhoes.ObterTodos();

            return CreateResult(caminhoes);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> ObterPor(long id)
        {
            var caminhao = await obterCaminhaoPorId.ObterPor(id);

            return CreateResult(caminhao);
        }

        [HttpPost]
        public async Task<IActionResult> Inserir(Caminhao caminhao)
        {
            var resultado = await inserirCaminhao.Inserir(caminhao);

            return CreateResult(resultado);
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar(Caminhao caminhao)
        {
            var resultado = await atualizarCaminhao.Atualizar(caminhao);

            return CreateResult(resultado);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Exluir(long id)
        {
            await excluirCaminhao.Excluir(id);

            return CreateResult();
        }
    }
}
