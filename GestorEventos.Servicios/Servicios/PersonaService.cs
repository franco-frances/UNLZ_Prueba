using GestorEventos.Servicios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEventos.Servicios.Servicios
{
	public class PersonaService
	{
		//IENumerable para esstablecer que es una Lista de Entidades
		public IEnumerable<Persona> PersonasDePrueba { get; set; }


		//constructor
		public PersonaService()
		{
			PersonasDePrueba = new List<Persona>
			{
				new Persona{ IdPersona = 1, Nombre = "Esteban", Apellido = "Gomez", Direccion =new Direccion("Moreno",1875,"4","B","7541",0,0) , Email = "estebangomez@yopmail.com", Telefono = "1111111"},
				new Persona{ IdPersona = 2, Nombre = "Jose", Apellido = "Peñaloza", Direccion = new Direccion("Mitre",2436,"2","G","1123",0,0), Email = "Josepenaloza@yopmail.com", Telefono = "22222222"},
				new Persona{ IdPersona = 3, Nombre = "Juana", Apellido = "Manzo", Direccion = new Direccion("Rivadavia",4566,"","","7456",0,0), Email = "juanamanzo@yopmail.com", Telefono = "3333333"},

			};
		}

		public IEnumerable<Persona> GetPersonasDePrueba()
		{
			return PersonasDePrueba;
		}

		public Persona? GetPersonaDePruebaSegunId(int IdPersona)
		{


			try
			{
				Persona persona = PersonasDePrueba.Where(x => x.IdPersona == IdPersona).First();
				return persona; 
			}
			catch (Exception ex)
			{
				return null;
			}



		}



	}
}
