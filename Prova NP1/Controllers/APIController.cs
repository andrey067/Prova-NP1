using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Prova_NP1.Models;
using Prova_NP1.Models.Interface;
using Prova_NP1.View;
using Prova_NP1.View.FilterDTO;
using System.Collections.Generic;
using System.Linq;

namespace Prova_NP1.Controllers
{
    [ApiController]
    public class APIController : ControllerBase
    {
        private readonly IHabilitadoRepository _repo;
        private readonly IMapper _mapper;

        public APIController(IHabilitadoRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        [HttpPost]
        [Route("/api/v1/produto/criar/")]
        public HabilitadoDTO Inserir([FromBody] CreateViewModel createViewModel)
        {
            var TodosUsuarios = _mapper.Map<List<Habilitado>>(this.GetAll());
            var habilitado_objDTO = _mapper.Map<HabilitadoDTO>(createViewModel);
            var indexMax = TodosUsuarios.Max(x => x.AId);
            habilitado_objDTO.AId = indexMax + 1;
            var habilitado_obj = _mapper.Map<Habilitado>(habilitado_objDTO);
            TodosUsuarios.Add(habilitado_obj);
            _repo.Reescrever(TodosUsuarios);
            return _mapper.Map<HabilitadoDTO>(habilitado_obj);

        }

        [HttpPut]
        [Route("/api/v1/produto/atualizar/")]
        public HabilitadoDTO Atualizar([FromBody] UpdateViewModel updateViewModel)
        {
            var TodosUsuarios = _repo.Query();
            var resultadoBusca = this.GetAll().Where(x => x.ACPF.ToLower() == updateViewModel.ACPF.ToLower()).FirstOrDefault();

            resultadoBusca.ACPF = updateViewModel.ACPF;
            resultadoBusca.ANome = updateViewModel.ANome;
            resultadoBusca.ATelefone = updateViewModel.ATelefone;
            resultadoBusca.AEmail = updateViewModel.AEmail;
            resultadoBusca.AIdade = updateViewModel.AIdade;
            var index = TodosUsuarios.FindIndex(x => x.ACPF.ToLower() == updateViewModel.ACPF.ToLower());
            var obj = _mapper.Map<Habilitado>(resultadoBusca);
            TodosUsuarios.Insert(index, obj);
            var habilitadoList = _mapper.Map<List<Habilitado>>(TodosUsuarios);
            _repo.Reescrever(habilitadoList);
            return resultadoBusca;
        }

        [HttpGet]
        [Route("/api/v1/habilitado/buscartodos")]
        public List<HabilitadoDTO> GetAll()
        {
            return _mapper.Map<List<HabilitadoDTO>>(_repo.Query());
        }

        [HttpGet]
        [Route("/api/v1/habilitado/buscarHabilitado/{aNome}")]
        public HabilitadoDTO GetHabilitados(string aNome)
        {
            return _mapper.Map<HabilitadoDTO>(_repo.Query().Where(x => x.ANome.ToLower() == aNome.ToLower()).FirstOrDefault());
        }

        [HttpDelete]
        [Route("/api/v1/habilitado/Deletar")]
        public bool Deletar(string ACpf)
        {
            var TodosUsuarios = _mapper.Map<List<HabilitadoDTO>>(_repo.Query());
            var index = TodosUsuarios.FindIndex(x => x.ACPF.ToLower() == ACpf.ToLower());
            if (index >= 0)
            {
                TodosUsuarios.RemoveAt(index);
                var HabilitadosObj = _mapper.Map<List<Habilitado>>(TodosUsuarios);
                _repo.Reescrever(HabilitadosObj);
                return true;
            }

            return false;
        }
    }
}

