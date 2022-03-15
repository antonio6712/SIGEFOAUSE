using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using SIGEFOAUSE;
using MySql.Data.MySqlClient;

namespace Presentacion
{
    class Control
    {
        public string ctrlRegistro(Usuarios usuario)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.LoginName1) || string.IsNullOrEmpty(usuario.Password1) ||
                string.IsNullOrEmpty(usuario.FirstName1) || string.IsNullOrEmpty(usuario.LastName1) ||
                string.IsNullOrEmpty(usuario.Email1) || usuario.LoginName1.Equals("(CLICK AQUI)")||
                usuario.Password1.Equals("(CLICK AQUI)") || usuario.FirstName1.Equals("(CLICK AQUI)") ||
                usuario.LastName1.Equals("(CLICK AQUI)") || usuario.Email1.Equals("(CLICK AQUI)"))
            {
                respuesta = "Se Deben llenar Todos los Campos";
            }
            else
            {
                if (modelo.ExisteUsuario(usuario.LoginName1))
                {
                    respuesta = "El Usuario de Ingreso ya Existe";
                }
                else
                {
                    usuario.Password1 = generarSHA1(usuario.Password1);
                    modelo.registro(usuario);
                }
            }
            return respuesta;
        }

        private string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder  sb = new StringBuilder();    
            for(int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }

            return sb.ToString();   
        }

        public string ControlIngreso(Usuarios usuario)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.LoginName1) || string.IsNullOrEmpty(usuario.Password1) ||
                usuario.LoginName1.Equals("") || usuario.Password1.Equals(""))
            {
                respuesta = "Se Deben llenar Todos los Campos";
            }
            else
            {
                if (modelo.LoginUsuario(usuario.LoginName1, generarSHA1(usuario.Password1)))
                {

                    respuesta = "¡Ingreso Con Exito!";

                }                       

            }
            return respuesta;
        }

        public string ControlRegistroDocumentos(Documentos documentos)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (string.IsNullOrEmpty(documentos.CantidadCompra1) || string.IsNullOrEmpty(documentos.CantidadCompraEscrita1) ||
                string.IsNullOrEmpty(documentos.ColorExterior1) || string.IsNullOrEmpty(documentos.ColorInterior1)||
                string.IsNullOrEmpty(documentos.CP1) || string.IsNullOrEmpty(documentos.Curp1) ||
                string.IsNullOrEmpty(documentos.FechaEscrita1) || string.IsNullOrEmpty(documentos.JuegoLlaves1)||
                string.IsNullOrEmpty(documentos.JuegoPlacasNumero1) || string.IsNullOrEmpty(documentos.Marca1) ||
                string.IsNullOrEmpty(documentos.Modelo1) || string.IsNullOrEmpty(documentos.Motor1) ||
                string.IsNullOrEmpty(documentos.NombreVendedor1) || string.IsNullOrEmpty(documentos.NumeroIdentificacion1) ||
                string.IsNullOrEmpty(documentos.Rfc1) || string.IsNullOrEmpty(documentos.Serie1) ||
                string.IsNullOrEmpty(documentos.TelefonoVendedor1) || string.IsNullOrEmpty(documentos.Tipo1)||
                string.IsNullOrEmpty(documentos.EstadoMunicipio1))
            {
                respuesta = "Se Deben llenar Todos los Campos";
            }
            else
            {
                modelo.registroDocumentos(documentos);
            }
            return respuesta;
        }

        
    }
}
