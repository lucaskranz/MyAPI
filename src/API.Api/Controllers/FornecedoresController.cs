using AutoMapper;
using DevIO.Api.ViewModels;
using DevIO.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace MyAPI.Api.Controllers
{
    [Route("api/fornecedores")]
    public class FornecedoresController : ControllerBase
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IMapper _mapper;
        public FornecedoresController(IFornecedorRepository fornecedorRepository, IMapper mapper)
        {
            _fornecedorRepository = fornecedorRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FornecedorDTO>> ObterTodos()
        {
            var fornecedor = _mapper.Map<IEnumerable<FornecedorDTO>>(await _fornecedorRepository.ObterTodos());
            return fornecedor;
        }
    }
}
