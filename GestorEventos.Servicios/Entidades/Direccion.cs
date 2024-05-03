using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GestorEventos.Servicios.Entidades
{
    public class Direccion
    {
        //DireccionCalle, DireccionNumero, DireccionPiso, DireccionDepartamento,
        //DireccionIdLocalidad (IdExterno), DireccionIdProvincia (IdExterno), DireccionCodigoPostal. 


        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Piso { get; set; }
        public string Departamento { get; set; }
        public string CodigoPostal { get; set; }
        public int IdLocalidad { get; set; }
        public int IdProvincia { get; set; }


        public Direccion(string calle="", int nuemero=0,string piso="", string departamento="", string codigoPostal="", int Idlocalidad=0, int IdProvincia=0) { 
            
            this.Calle = calle;
            this.Numero = nuemero;
            this.Piso = piso;
            this.Departamento = departamento;
            this.CodigoPostal = codigoPostal;
            this.IdProvincia = IdProvincia;
            this.IdLocalidad= Idlocalidad;
        
        
        }

    }

}

