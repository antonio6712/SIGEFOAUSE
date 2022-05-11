using DataAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Modelo
    {
        //USUARIOS
        public int registro(Usuarios usuario)
        {
            MySqlConnection conexion = ConnectionToSql.getConnection();
            conexion.Open();
            string query = "INSERT INTO users (LoginName,Password,Firstname,Lastname,Email) " +
                "VALUES(@LoginName, @Password, @FirstName, @LastName, @Email);";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@LoginName", usuario.LoginName1);
            comando.Parameters.AddWithValue("@Password", usuario.Password1);
            comando.Parameters.AddWithValue("@FirstName", usuario.FirstName1);
            comando.Parameters.AddWithValue("@LastName", usuario.LastName1);
            comando.Parameters.AddWithValue("@Email", usuario.Email1);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        public bool ExisteUsuario(string usuario)
        {
            MySqlConnection conexion = ConnectionToSql.getConnection();
            conexion.Open();
            MySqlDataReader reader;

            string query = "select UserId from users where LoginName LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LoginUsuario(string usuario, string contraseña)
        {
            MySqlConnection conexion = ConnectionToSql.getConnection();
            conexion.Open();
            MySqlDataReader reader;

            string query = "select * from users where LoginName like @LoginName and Password like @Password";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@LoginName", usuario);
            comando.Parameters.AddWithValue("@Password", contraseña);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BuscarRol()
        {
            string us = llegadaDatos.user;

            MySqlConnection conexion = ConnectionToSql.getConnection();
            conexion.Open();
            MySqlDataReader reader;

            string query = "select * from users where LoginName like @LoginName and Rol='ADMINISTRADOR'";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@LoginName", us);

            reader = comando.ExecuteReader();


            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool DatosUsuario()
        {
            string us = llegadaDatos.user;

            MySqlConnection conexion = ConnectionToSql.getConnection();
            conexion.Open();
            MySqlDataReader reader;

            string query = "select * from users where LoginName = @LoginName";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@LoginName", us);


            reader = comando.ExecuteReader();
            if (reader.Read())
            {
                llegadaDatos.FirstName = reader["Firstname"].ToString();
                llegadaDatos.LastName = reader["Lastname"].ToString();
                llegadaDatos.Iduser = int.Parse(reader["UserId"].ToString());

                return true;
            }
            else
            {
                return false;
            }

        }

        //DOCUMENTOS
        public int registroDocumentos(Documentos documentos)
        {
            MySqlConnection conexion = ConnectionToSql.getConnection();
            conexion.Open();
            string query = "INSERT INTO `sigefoause`.`documento` (`NombreVendedor`, " +
                "`NumeroIdentificacion`, `Curp`, `Rfc`, `Domicilio`, `CP`, " +
                "`TelefonoVendedor`, `Marca`, `Modelo`, `ColorExterior`, " +
                "`ColorInterior`, `Motor`, `Tipo`, `Serie`, `FacturaOrigen`, `FacturaOriginal`, " +
                "`TarjetaCirculacion`, `2021`, `2020`, `2019`, `2018`, `2017`, `2016`, `2015`, `2014`, " +
                "`2013`, `Placas`, `Llaves`, `CantidadCompra`, `CantidadCompraEscrita`, " +
                "`FacturaNumero`, `Fecha`, `FechaEscrita`, `Verificacion`, `JuegoPlacasNumero`, " +
                "`JuegoLlaves`, `UnidadesLuces`, `Luces`, `Antena`, `EspejosLaterales`, " +
                "`MoldurasCompletas`, `TaponGasolina`, `InstrumentoTablero`, " +
                "`CalefaccionAireAcondicionado`, `Radio`, `Bocinas`, `EspejoRetrovisor`, " +
                "`Ceniceros`, `CinturonesSeguridad`, `ManeralGato`, `LlaveRuedas`, " +
                "`TrianguloSeguridad`, `LlantaRefaccion`, `Extinguidor`, `CarroceriaGolpes`, " +
                "`Claxon`, `ConprobantesTendencia`, `ComprobantesVerificacionVehi`, " +
                "`EstucheHerramienta`, `Tenencia`, IdUsuario, MunicipioEstado, A2022, NoAplica, Limpiadores)  " +

                "VALUES (@NombreVendedor, @NumeroIdentificacion, @Curp, @Rfc, @Domicilio, @CP, @TelefonoVendedor," +
                "@Marca, @Modelo, @ColorExterior, @ColorInterior, @Motor, @Tipo, @Serie, " +
                "@FacturaOrigen, @FacturaOriginal, @TarjetaCirculacion, @A2021, @A2020,@A2019, @A2018," +
                "@A2017, @A2016, @A2015, @A2014, @A2013, @Placas, @Llaves, @CantidadCompra, @CantidadCompraEscrita," +
                "@FacturaNumero,@Fecha, @FechaEscrita, @Verificacion, @JuegoPlacasNumero, @JuegoLlaves,  @UnidadesLuces," +
                "@Luces, @Antena, @EspejosLaterales, @MoldurasCompletas, @TaponGasolina, @InstrumentoTablero," +
                "@CalefaccionAireAcondicionado, @Radio, @Bocinas, @EspejoRetrovisor, @Ceniceros, @CinturonesSeguridad," +
                "@ManeralGato, @LlaveRuedas, @TrianguloSeguridad, @LlantaRefaccion, @Extinguidor, @CarroceriaGolpes," +
                "@Claxon, @ConprobantesTendencia, @ComprobantesVerificacionVehi, @EstucheHerramienta, @Tenencia, @IdUsuario," +
                "@MunicipioEstado, @A2022, @NoAplica, @Limpiadores);";

            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@NombreVendedor", documentos.NombreVendedor1);
            comando.Parameters.AddWithValue("@NumeroIdentificacion", documentos.NumeroIdentificacion1);
            comando.Parameters.AddWithValue("@Curp", documentos.Curp1);
            comando.Parameters.AddWithValue("@Rfc", documentos.Rfc1);
            comando.Parameters.AddWithValue("@Domicilio", documentos.Domicilio1);
            comando.Parameters.AddWithValue("@CP", documentos.CP1);
            comando.Parameters.AddWithValue("@TelefonoVendedor", documentos.TelefonoVendedor1);
            comando.Parameters.AddWithValue("@Marca", documentos.Marca1);
            comando.Parameters.AddWithValue("@Modelo", documentos.Modelo1);
            comando.Parameters.AddWithValue("@ColorExterior", documentos.ColorExterior1);
            comando.Parameters.AddWithValue("@ColorInterior", documentos.ColorInterior1);
            comando.Parameters.AddWithValue("@Motor", documentos.Motor1);
            comando.Parameters.AddWithValue("@Serie", documentos.Serie1);
            comando.Parameters.AddWithValue("@FacturaOrigen", documentos.FacturaOrigen1);
            comando.Parameters.AddWithValue("@FacturaOriginal", documentos.FactuaOriginal1);
            comando.Parameters.AddWithValue("@TarjetaCirculacion", documentos.TarjetaCirculacion1);
            comando.Parameters.AddWithValue("@A2021", documentos.A20211);
            comando.Parameters.AddWithValue("@A2020", documentos.A20201);
            comando.Parameters.AddWithValue("@A2019", documentos.A20191);
            comando.Parameters.AddWithValue("@A2018", documentos.A20181);
            comando.Parameters.AddWithValue("@A2017", documentos.A20171);
            comando.Parameters.AddWithValue("@A2016", documentos.A20161);
            comando.Parameters.AddWithValue("@A2015", documentos.A20151);
            comando.Parameters.AddWithValue("@A2014", documentos.A20141);
            comando.Parameters.AddWithValue("@A2013", documentos.A20131);
            comando.Parameters.AddWithValue("@Placas", documentos.Placas);
            comando.Parameters.AddWithValue("@Llaves", documentos.Llaves);
            comando.Parameters.AddWithValue("@CantidadCompra", documentos.CantidadCompra1);
            comando.Parameters.AddWithValue("@CantidadCompraEscrita", documentos.CantidadCompraEscrita1);
            comando.Parameters.AddWithValue("@FacturaNumero", documentos.FacturaNumero1);
            comando.Parameters.AddWithValue("@Fecha", documentos.Fecha1);
            comando.Parameters.AddWithValue("@FechaEscrita", documentos.FechaEscrita1);
            comando.Parameters.AddWithValue("@Verificacion", documentos.Verificacion1);
            comando.Parameters.AddWithValue("@JuegoPlacasNumero", documentos.JuegoPlacasNumero1);
            comando.Parameters.AddWithValue("@JuegoLlaves", documentos.JuegoLlaves1);
            comando.Parameters.AddWithValue("@UnidadesLuces", documentos.UnidadesLuces1);
            comando.Parameters.AddWithValue("@Luces", documentos.Luces1);
            comando.Parameters.AddWithValue("@Antena", documentos.Antena1);
            comando.Parameters.AddWithValue("@EspejosLaterales", documentos.EspejosLaterales1);
            comando.Parameters.AddWithValue("@MoldurasCompletas", documentos.MoldurasCompletas1);
            comando.Parameters.AddWithValue("@TaponGasolina", documentos.TaponGasolina1);
            comando.Parameters.AddWithValue("@InstrumentoTablero", documentos.InstrumentoTablero1);
            comando.Parameters.AddWithValue("@CalefaccionAireAcondicionado", documentos.Calefaccion1);
            comando.Parameters.AddWithValue("@Radio", documentos.Radio1);
            comando.Parameters.AddWithValue("@Bocinas", documentos.Bocinas1);
            comando.Parameters.AddWithValue("@EspejoRetrovisor", documentos.EspejoRetrovisor1);
            comando.Parameters.AddWithValue("@Ceniceros", documentos.Ceniceros1);
            comando.Parameters.AddWithValue("@CinturonesSeguridad", documentos.CinturonesSeguridad1);
            comando.Parameters.AddWithValue("@ManeralGato", documentos.ManeralGato1);
            comando.Parameters.AddWithValue("@LlaveRuedas", documentos.ManeralGato1);
            comando.Parameters.AddWithValue("@TrianguloSeguridad", documentos.TrianguloSeguridad1);
            comando.Parameters.AddWithValue("@LlantaRefaccion", documentos.LlantaRefaccion1);
            comando.Parameters.AddWithValue("@Extinguidor", documentos.Extinguidor1);
            comando.Parameters.AddWithValue("@CarroceriaGolpes", documentos.CarroceriaGolpes1);
            comando.Parameters.AddWithValue("@Claxon", documentos.Claxon1);
            comando.Parameters.AddWithValue("@ConprobantesTendencia", documentos.ComprobantesTendencia1);
            comando.Parameters.AddWithValue("@ComprobantesVerificacionVehi", documentos.ComprobantesVerificacionVehi1);
            comando.Parameters.AddWithValue("@EstucheHerramienta", documentos.EstucheHerramienta1);
            comando.Parameters.AddWithValue("@Tipo", documentos.Tipo1);
            comando.Parameters.AddWithValue("@Tenencia", documentos.Tenencia1);
            comando.Parameters.AddWithValue("@IdUsuario", llegadaDatos.Iduser);
            comando.Parameters.AddWithValue("@MunicipioEstado", documentos.EstadoMunicipio1);
            comando.Parameters.AddWithValue("@A2022", documentos.A20221);
            comando.Parameters.AddWithValue("@NoAplica", documentos.NoAplica1);
            comando.Parameters.AddWithValue("@Limpiadores", documentos.Limpiadores1);



            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        public List<Object> ConsultaLista(string dato, string dato2)
        {
            MySqlDataReader reader;

            List<Object> lista = new List<Object>();
            string query;

            //Buscar Registros por ROL
            
            if (BuscarRol() == true && dato == null && dato2 == null)
            {
                query = "SELECT * FROM documento order by iddocumento desc;";

            }else if (BuscarRol() == false )
            {
                if (dato == null && dato2 == null)
                {
                    query = "SELECT * FROM documento where IdUsuario = " + llegadaDatos.Iduser + " order by iddocumento desc;";

                }
                else
                {
                    query = "SELECT * FROM documento where fecha between '" + dato + "' and '" + dato2 + "' and IdUsuario = " + llegadaDatos.Iduser + " ";
                }
            }
            else
            {
                query = "SELECT * FROM documento where fecha between '" + dato + "' and '" + dato2 + "' ";
            }

            try
            {
                MySqlConnection conexion = ConnectionToSql.getConnection();
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(query, conexion);

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    DocumentosTabla documentos = new DocumentosTabla();
                    documentos.NombreVendedor1 = reader.GetString("NombreVendedor");
                    documentos.Rfc1 = reader.GetString("Rfc");
                    documentos.FacturaNumero1 = reader.GetString("FacturaNumero");
                    documentos.Fecha1 = reader.GetDateTime("Fecha");
                    documentos.Iddocumento = int.Parse(reader.GetString("iddocumento"));

                    lista.Add(documentos);

                }
            }
            catch (MySqlException e)
            {

                Console.WriteLine(e);
            }

            return lista;
        }


    }
}

