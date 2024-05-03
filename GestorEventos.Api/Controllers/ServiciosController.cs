﻿using GestorEventos.Servicios.Entidades;
using GestorEventos.Servicios.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestorEventos.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServiciosController : ControllerBase
	{
		[HttpGet]
		public IActionResult GetServicios()
		{
			ServiciosService serviciosService = new ServiciosService();

			return Ok(serviciosService.GetServicios());
		}

		[HttpGet("{idServicio:int}")]
		public IActionResult GetServicioPorId(int idServicio)
		{
			ServiciosService serviciosService = new ServiciosService();

			var servicio = serviciosService.GetServiciosPorId(idServicio);

			if (servicio == null)
				return NotFound();
			else
				return Ok(servicio);
		}

		[HttpPost("nuevo")]
		public IActionResult PostNuevoServicio([FromBody] ServiciosVM servicionuevo)
		{

			ServiciosService serviciosService = new ServiciosService();
			serviciosService.AgregarServicio(servicionuevo);

			return Ok();
		}



	}
}
