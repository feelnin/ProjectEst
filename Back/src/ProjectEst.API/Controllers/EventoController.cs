using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectEst.API.Models;

namespace ProjectEst.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable <Evento> _evento = new Evento []
           {
                new Evento (){
                    EventoId = 1,
                    Tema = "Angular e .Net 5",
                    Local = "Salvador",
                    Lote = "1º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemURL = "foto.png"
                },
                new Evento (){
                    EventoId = 1,
                    Tema = "Angular e .Net 5",
                    Local = "Salvador",
                    Lote = "1º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemURL = "foto.png"
                }
            };
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }
        
        [HttpPut ("{id}")]
        public string Put(int id)
        {
           return $"Exemplo de put={id}";
        }

        [HttpDelete ("{id}")]
        public string Delete(int id)
        {
           return $"Exemplo de Delete = {id}";
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }
    }
}
