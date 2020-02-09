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
        private readonly IObterTodosOsCaminhoes obterTodosOsCaminhoes;
        private readonly IObterCaminhaoPorId obterCaminhaoPorId;
        private readonly IInserirCaminhao inserirCaminhao;
        private readonly IAtualizarCaminhao atualizarCaminhao;
        private readonly IExcluirCaminhao excluirCaminhao;

        public CaminhoesController(
            IObterTodosOsCaminhoes obterTodosOsCaminhoes,
            IObterCaminhaoPorId obterCaminhaoPorId,
            IInserirCaminhao inserirCaminhao,
            IAtualizarCaminhao atualizarCaminhao,
            IExcluirCaminhao excluirCaminhao)
        {
            this.obterTodosOsCaminhoes = obterTodosOsCaminhoes;
            this.obterCaminhaoPorId = obterCaminhaoPorId;
            this.inserirCaminhao = inserirCaminhao;
            this.atualizarCaminhao = atualizarCaminhao;
            this.excluirCaminhao = excluirCaminhao;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var caminhoes = await obterTodosOsCaminhoes.ObterTodos();

            return CreateObjectResult(caminhoes);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> ObterPor(long id)
        {
            var caminhao = await obterCaminhaoPorId.ObterPor(id);

            return CreateObjectResult(caminhao);
        }

        [HttpPost]
        public async Task<IActionResult> Inserir(Caminhao caminhao)
        {
            var resultado = await inserirCaminhao.Inserir(caminhao);

            return CreateObjectResult(resultado);
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar(Caminhao caminhao)
        {
            var resultado = await atualizarCaminhao.Atualizar(caminhao);

            return CreateObjectResult(resultado);
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
