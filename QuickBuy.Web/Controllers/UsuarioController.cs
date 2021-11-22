using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBuy.Web.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpPost]
        public ActionResult Post()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex )
            {

                return BadRequest(ex.ToString());
            }
           
        }

        [HttpPost("VerificarUsuario")]
        public ActionResult VerificarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                if (usuario.Email == "laiss988@gmail.com" && usuario.Senha == "laiss988@gmail.com")
                {
                    return Ok(usuario);
                }

                return BadRequest("Usuario ou senha inválidos");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }

        }



        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }

        }


    }
}
