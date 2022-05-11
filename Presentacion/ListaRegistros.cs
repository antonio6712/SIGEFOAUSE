using DataAccess;
using Domain;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ListaRegistros : Form
    {
        public ListaRegistros()
        {
            InitializeComponent();
            CargarDatosTabla(null, null);
            //fecha();
        }

        //private void fecha()
        //{
        //    //string fecha = string.Format("{0:d}", date.Value);
        //    string fecha = date.Value.ToString("dd-MM-yyyy");
        //    MessageBox.Show(fecha);
        //}

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatosTabla(string dato, string dato2)
        {
            List<DocumentosTabla> lista = new List<DocumentosTabla>();
            Modelo md = new Modelo();
            ListaTabla.DataSource = md.ConsultaLista(dato, dato2);

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

            string dato = BuscaFecha.Value.ToString("yyyy-MM-dd");
            string dato2 = fechahasta.Value.ToString("yyyy-MM-dd");

            CargarDatosTabla(dato, dato2);
        }

        private void EditarRegistro_Click(object sender, EventArgs e)
        {
            if (ListaTabla.SelectedRows.Count > 0)
            {
                llegadaDatos.IdRegistro = ListaTabla.CurrentRow.Cells["Iddocumento"].Value.ToString();


            }
            else
            {
                MessageBox.Show("Seleccione un Registro");
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (ListaTabla.SelectedRows.Count > 0)
            {
                llegadaDatos.IdRegistro = ListaTabla.CurrentRow.Cells["Iddocumento"].Value.ToString();

                CrearPdf();

                MessageBox.Show("Se a Generado el Documento");
            }
            else
            {
                MessageBox.Show("Seleccione un Registro para Imprimir");
            }
        }

        private void CrearPdf()
        {

            string query = "SELECT * FROM documento where iddocumento = " + llegadaDatos.IdRegistro + ";";
            MySqlConnection conexion = ConnectionToSql.getConnection();
            conexion.Open();
            MySqlDataReader reader;

            MySqlCommand comando = new MySqlCommand(query, conexion);
            reader = comando.ExecuteReader();

            Documentos documentos = new Documentos();

            if (reader.Read())
            {

                documentos.NombreVendedor1 = reader["NombreVendedor"].ToString();
                documentos.Tipo1 = reader["Tipo"].ToString();
                documentos.Serie1 = reader["Serie"].ToString();
                documentos.Rfc1 = reader["Rfc"].ToString();
                documentos.Domicilio1 = reader["Domicilio"].ToString();
                documentos.CP1 = reader["CP"].ToString();
                documentos.EstadoMunicipio1 = reader["MunicipioEstado"].ToString();

                documentos.Marca1 = reader["Marca"].ToString();
                documentos.Modelo1 = reader["Modelo"].ToString();
                documentos.ColorExterior1 = reader["ColorExterior"].ToString();
                documentos.ColorInterior1 = reader["ColorInterior"].ToString();
                documentos.Tipo1 = reader["Tipo"].ToString();
                documentos.Motor1 = reader["Motor"].ToString();
                documentos.Serie1 = reader["Serie"].ToString();

                documentos.FacturaNumero1 = reader["FacturaNumero"].ToString();
                documentos.JuegoLlaves1 = reader["JuegoLlaves"].ToString();
                documentos.Verificacion1 = Convert.ToBoolean(reader["Verificacion"]);

                documentos.CantidadCompra1 = reader["CantidadCompra"].ToString();
                documentos.CantidadCompraEscrita1 = reader["CantidadCompraEscrita"].ToString();

                documentos.FechaEscrita1 = reader["FechaEscrita"].ToString();

                documentos.TelefonoVendedor1 = reader["TelefonoVendedor"].ToString();

                documentos.FacturaOrigen1 = Convert.ToBoolean(reader["FacturaOrigen"]);
                documentos.FactuaOriginal1 = Convert.ToBoolean(reader["FacturaOriginal"]);
                documentos.TarjetaCirculacion1 = Convert.ToBoolean(reader["TarjetaCirculacion"]);
                documentos.A20211 = Convert.ToBoolean(reader["2021"]);
                documentos.A20201 = Convert.ToBoolean(reader["2020"]);
                documentos.A20191 = Convert.ToBoolean(reader["2019"]);
                documentos.A20181 = Convert.ToBoolean(reader["2018"]);
                documentos.A20171 = Convert.ToBoolean(reader["2017"]);
                documentos.A20161 = Convert.ToBoolean(reader["2016"]);
                documentos.A20151 = Convert.ToBoolean(reader["2015"]);
                documentos.A20141 = Convert.ToBoolean(reader["2014"]);
                documentos.A20131 = Convert.ToBoolean(reader["2013"]);

                documentos.A20221 = Convert.ToBoolean(reader["A2022"]);
                documentos.NoAplica1 = Convert.ToBoolean(reader["NoAplica"]);
                documentos.TarjetaCirculacion1 = Convert.ToBoolean(reader["TarjetaCirculacion"]);
                documentos.JuegoPlacasNumero1 = reader["JuegoPlacasNumero"].ToString();


                documentos.UnidadesLuces1 = Convert.ToBoolean(reader["UnidadesLuces"]);
                documentos.Luces1 = Convert.ToBoolean(reader["Luces"]);
                documentos.Antena1 = Convert.ToBoolean(reader["Antena"]);
                documentos.EspejosLaterales1 = Convert.ToBoolean(reader["EspejosLaterales"]);
                documentos.MoldurasCompletas1 = Convert.ToBoolean(reader["MoldurasCompletas"]);
                documentos.TaponGasolina1 = Convert.ToBoolean(reader["TaponGasolina"]);
                documentos.CarroceriaGolpes1 = Convert.ToBoolean(reader["CarroceriaGolpes"]);
                documentos.Claxon1 = Convert.ToBoolean(reader["Claxon"]);
                documentos.InstrumentoTablero1 = Convert.ToBoolean(reader["InstrumentoTablero"]);
                documentos.Calefaccion1 = Convert.ToBoolean(reader["CalefaccionAireAcondicionado"]);
                documentos.Limpiadores1 = Convert.ToBoolean(reader["Limpiadores"]);
                documentos.Radio1 = Convert.ToBoolean(reader["Radio"]);
                documentos.Bocinas1 = Convert.ToBoolean(reader["Bocinas"]);
                documentos.EspejoRetrovisor1 = Convert.ToBoolean(reader["EspejoRetrovisor"]);
                documentos.Ceniceros1 = Convert.ToBoolean(reader["Ceniceros"]);
                documentos.CinturonesSeguridad1 = Convert.ToBoolean(reader["CinturonesSeguridad"]);


                documentos.ManeralGato1 = Convert.ToBoolean(reader["ManeralGato"]);
                documentos.LlantaRuedas1 = Convert.ToBoolean(reader["LlaveRuedas"]);
                documentos.EstucheHerramienta1 = Convert.ToBoolean(reader["EstucheHerramienta"]);
                documentos.TrianguloSeguridad1 = Convert.ToBoolean(reader["TrianguloSeguridad"]);
                documentos.LlantaRefaccion1 = Convert.ToBoolean(reader["LlantaRefaccion"]);
                documentos.Extinguidor1 = Convert.ToBoolean(reader["Extinguidor"]);
                documentos.CarroceriaGolpes1 = Convert.ToBoolean(reader["CarroceriaGolpes"]);
                documentos.Claxon1 = Convert.ToBoolean(reader["Claxon"]);


                documentos.TarjetaCirculacion1 = Convert.ToBoolean(reader["TarjetaCirculacion"]);
                documentos.ComprobantesTendencia1 = Convert.ToBoolean(reader["ConprobantesTendencia"]);
                documentos.ComprobantesVerificacionVehi1 = Convert.ToBoolean(reader["ComprobantesVerificacionVehi"]);

                documentos.Fecha1 = Convert.ToDateTime(reader["Fecha"]);

                documentos.Curp1 = reader["Curp"].ToString();
                documentos.NumeroIdentificacion1 = reader["NumeroIdentificacion"].ToString();

                documentos.Rfc1 = reader["Rfc"].ToString();


            }


            //ruta de la carpeta documentos del sistema.
            var rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //Creación de la carpeta reportes.
            string FolderReportes = @"" + rutaDocumentos + "/Reportes";
            if (!Directory.Exists(FolderReportes))
            {
                Directory.CreateDirectory(FolderReportes);
            }

            var fecha = DateTime.Now.ToString("dd-MM-yyyy");

            PdfWriter pdfwriter = new PdfWriter(FolderReportes + "/Reporte " + llegadaDatos.IdRegistro + " " + fecha + ".pdf");
            PdfDocument pdfdocument = new PdfDocument(pdfwriter);
            Document documento = new Document(pdfdocument, PageSize.LETTER);


            documento.SetMargins(50, 60, 50, 60);

            PdfFont fontcolumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            //AQUI EMPIEZA LA PAGINA 1

            var p1 = new Paragraph("(" + documentos.NombreVendedor1 + ") en mi propio derecho " +
                "manifiesto que no obtengo ingresos por las actividades empresariales o " +
                "profesionales a que se refiere las Secciones I y II, Capítulo II del " +
                "Título IV de la Ley del Impuesto Sobre la Renta, motivo por el cual " +
                "solicito me sea aplicada las facilidades contenidas en las reglas " +
                "I.2.4.3 y I.2.7.3.4 de la Resolución Miscelánea Fiscal para 2014, " +
                "las cuales establecen textualmente lo siguiente:").SetTextAlignment(TextAlignment.LEFT).SetFont(fontContenido).SetFontSize(12);

            var p2 = new Paragraph("I.2.4.3. Para los efectos del artículo 27 del CFF, " +
                "podrán inscribirse en el RFC a través de los adquirentes de " +
                "sus productos o de los contribuyentes a los que les otorguen el uso o " +
                "goce, de conformidad con el procedimiento que se señala en la página " +
                "de Internet del SAT, los contribuyentes personas físicas que: ")
                .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontContenido).SetFontSize(8);

            var p3 = new Paragraph("IV. Enajenen vehículos usados, con excepción de " +
                "aquéllas que tributen en los términos de las Secciones I y II, del " +
                "Capítulo II del Título IV de la LISR. ")
                .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontContenido).SetFontSize(8);

            var p4 = new Paragraph("Los contribuyentes que opten por aplicar lo dispuesto " +
                "en esta regla, deberán proporcionar a dichos adquirentes o a sus " +
                "arrendatarios, así como a las personas morales constituidas como " +
                "organizaciones, comités, organismos ejecutores o asociaciones que " +
                "reúnan a productores y comercializadores agrícolas, pecuarios, " +
                "acuícolas o pesqueros de un Sistema Producto según sea el caso, " +
                "lo siguiente:  ")
                .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontContenido).SetFontSize(8);

            var p5 = new Paragraph("  a) Nombre." +
                "\nb) CURP o copia del acta de nacimiento." +
                "\nc) Actividad preponderante que realizan." +
                "\nd) Domicilio fiscal.")
               .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontContenido).SetFontSize(8);

            var p6 = new Paragraph("I.2.7.3.4. Para los efectos del artículo 29, último " +
                "párrafo del CFF, las personas físicas a que se refiere la regla I.2.4.3., " +
                "fracción IV, que hayan optado por inscribirse en el RFC a través de los " +
                "adquirentes de sus vehículos usados, podrán expedir CFDI cumpliendo con " +
                "los requisitos establecidos en los artículos 29 y 29-A del citado " +
                "ordenamiento, para lo cual deberán utilizar los servicios que para " +
                "tales efectos sean prestados por un PSECFDI, en los términos de lo " +
                "dispuesto por la regla II.2.5.3.1., a las personas a quienes enajenen " +
                "los vehículos usados. Los contribuyentes señalados en esta regla que ya " +
                "se encuentren inscritos en el RFC, deberán proporcionar a los adquirentes " +
                "de los vehículos usados, su clave en el RFC, para que se expidan CFDI en " +
                "los términos de la regla II.2.5.3.1. ")
                .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontContenido).SetFontSize(8);

            var p7 = new Paragraph("   Lo anterior con relación a la venta a la empresa " +
                "(Automotriz Marbra) del vehículo usado de mi propiedad " +
                "(" + documentos.Tipo1 + "  " + documentos.Serie1 + ") ")
                .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontContenido).SetFontSize(12);

            var p8 = new Paragraph("Atentamente")
                .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontContenido).SetFontSize(12);

            var p9 = new Paragraph("___________________________")
                .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontContenido).SetFontSize(12);

            var p10 = new Paragraph("" + documentos.NombreVendedor1 + "")
                .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontContenido).SetFontSize(12);

            var p11 = new Paragraph("" + documentos.Rfc1 + "")
               .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontContenido).SetFontSize(12);

            var p12 = new Paragraph("EMPLEADO")
               .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontContenido).SetFontSize(12);

            var p13 = new Paragraph("" + documentos.Domicilio1 + "")
              .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontContenido).SetFontSize(12);

            var PMunicipio = new Paragraph("" + documentos.EstadoMunicipio1 + " C.P. " + documentos.CP1 + "")
              .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontContenido).SetFontSize(12);


            Paragraph saltoDeLinea2 = new Paragraph("");




            documento.Add(p1);
            documento.Add(p2);
            documento.Add(p3);
            documento.Add(p4);
            documento.Add(p5);
            documento.Add(p6);
            documento.Add(p7);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(p8);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(p9);
            documento.Add(p10);
            documento.Add(p11);
            documento.Add(p12);
            documento.Add(p13);


            documento.Add(PMunicipio);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);

            //AQUI EMPIEZA LA PAGINA 2

            var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("C:/Users/anton/" +
                "Documents/Antonio/PROYECTOS/SIGEFOAUSE/Presentacion/img/mazdalo.jpeg")).SetWidth(100).SetHeight(50);

            Table table = new Table(11).SetWidth(500).SetFontSize(8);


            table.AddCell("Factura de Origen");
            if (documentos.FacturaOrigen1 == true)
            {
                table.AddCell("SI");
            }
            else
            {
                table.AddCell("NA");
            }
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");

            table.AddCell("Factura Original");
            if (documentos.FactuaOriginal1 == true)
            {
                table.AddCell("SI");
            }
            else
            {
                table.AddCell("NA");
            }
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");

            table.AddCell("Tarjeta de Circulación");
            if (documentos.TarjetaCirculacion1 == true)
            {
                table.AddCell("SI");
            }
            else
            {
                table.AddCell("NA");
            }
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");

            table.AddCell("");
            table.AddCell("2022");
            table.AddCell("2021");
            table.AddCell("2020");
            table.AddCell("2019");
            table.AddCell("2018");
            table.AddCell("2017");
            table.AddCell("2016");
            table.AddCell("2015");
            table.AddCell("2014");
            table.AddCell("2013");


            table.AddCell("Tenencias");
            table.AddCell("ok");

            if (documentos.A20211 == true)
            {
                table.AddCell("SI");
            }
            else
            {
                table.AddCell("NA");
            }
            if (documentos.A20201 == true)
            {
                table.AddCell("SI");
            }
            else
            {
                table.AddCell("NA");
            }
            if (documentos.A20191 == true)
            {
                table.AddCell("SI");
            }
            else
            {
                table.AddCell("NA");
            }
            if (documentos.A20181 == true)
            {
                table.AddCell("SI");
            }
            else
            {
                table.AddCell("NA");
            }
            if (documentos.A20171 == true)
            {
                table.AddCell("SI");
            }
            else
            {
                table.AddCell("NA");
            }
            if (documentos.A20161 == true)
            {
                table.AddCell("SI");
            }
            else
            {
                table.AddCell("NA");
            }
            if (documentos.A20151 == true)
            {
                table.AddCell("SI");
            }
            else
            {
                table.AddCell("NA");
            }
            if (documentos.A20141 == true)
            {
                table.AddCell("SI");
            }
            else
            {
                table.AddCell("NA");
            }
            if (documentos.A20131 == true)
            {
                table.AddCell("SI");
            }
            else
            {
                table.AddCell("NA");
            }



            table.AddCell("Placas");
            table.AddCell("Valor");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");


            table.AddCell("LLaves");
            table.AddCell(documentos.JuegoLlaves1);
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");

            table.AddCell("Verificación");
            if (documentos.Verificacion1 == true)
            {
                table.AddCell("SI");
            }
            else
            {
                table.AddCell("NA");
            }
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");

            var p14 = new Paragraph("CARTA RESPONSIVA DE COMPRAVENTA")
               .SetTextAlignment(TextAlignment.CENTER).SetFont(fontcolumnas).SetFontSize(18);


            Table tabla2 = new Table(2).SetWidth(400).SetMarginTop(0).SetMarginBottom(0);
            Cell cell1 = new Cell(1, 1);
            cell1.SetBorder(Border.NO_BORDER);
            //Paragraph marca = new Paragraph(documentos.Marca1).SetUnderline();
            cell1.Add(new Paragraph("Marca: " + documentos.Marca1).SetPaddings(0, 1, 0, 1).SetFontSize(14));

            Cell cell2 = new Cell(1, 2);
            cell2.SetBorder(Border.NO_BORDER);
            cell2.Add(new Paragraph("Modelo: " + documentos.Modelo1).SetPaddings(0, 1, 0, 1).SetFontSize(14));

            Cell cell3 = new Cell(2, 1);
            cell3.SetBorder(Border.NO_BORDER);
            cell3.Add(new Paragraph("Color: " + documentos.ColorExterior1).SetPaddings(0, 1, 0, 1).SetFontSize(14));

            Cell cell4 = new Cell(2, 2);
            cell4.SetBorder(Border.NO_BORDER);
            cell4.Add(new Paragraph("Tipo: " + documentos.Tipo1).SetPaddings(0, 1, 0, 1).SetFontSize(14));

            Cell cell5 = new Cell(3, 1);
            cell5.SetBorder(Border.NO_BORDER);
            cell5.Add(new Paragraph("Motor: " + documentos.Motor1).SetPaddings(0, 1, 0, 1).SetFontSize(14));

            Cell cell6 = new Cell(3, 2);
            cell6.SetBorder(Border.NO_BORDER);
            cell6.Add(new Paragraph("Serie: " + documentos.Serie1).SetPaddings(0, 1, 0, 1).SetFontSize(14));


            tabla2.AddCell(cell1);
            tabla2.AddCell(cell2);
            tabla2.AddCell(cell3);
            tabla2.AddCell(cell4);
            tabla2.AddCell(cell5);
            tabla2.AddCell(cell6);


            documento.Add(logo);
            documento.Add(p14);
            documento.Add(tabla2);
            documento.Add(new Paragraph("Con los siguientes documentos").SetFontSize(10));
            documento.Add(table);
            documento.Add(new Paragraph("Las que por ahora no estará mi nombre, " +
                "pero que, dentro del término legal y mediante los procedimientos " +
                "administrativos correspondientes ante la Secretaria de finanzas " +
                "correspondiente así la dirección general de tránsito o su " +
                "equivalente el automóvil de que se trata quedará circulando a " +
                "nombre mío. El comprador revisará por su propia cuenta la unidad " +
                "y recibe el vehículo usado y en el estado material en que se " +
                "encuentra. El vendedor (a) acepta toda la responsabilidad civil o " +
                "penal o de tránsito en que se haya involucrada el automóvil objeto " +
                "de la compra y que a partir de la fecha de operación, el comprador " +
                "asume una nueva responsabilidad. Se realiza la compra venta en la " +
                "cantidad de: $" + documentos.CantidadCompra1 + " (" + documentos.CantidadCompraEscrita1 + "  " +
                "pesos  00/100 M.N.) ").SetFontSize(8).SetTextAlignment(TextAlignment.JUSTIFIED));

            documento.Add(saltoDeLinea2);
            documento.Add(new Paragraph("Estando de conformidad ambas partes, " +
                "con los derechos y obligaciones, firma alcance para  " +
                "la constancia.").SetFontSize(8).SetTextAlignment(TextAlignment.JUSTIFIED));

            documento.Add(new Paragraph(documentos.EstadoMunicipio1 + " " + documentos.FechaEscrita1).SetFontSize(10).SetBold());

            Table tabla3 = new Table(2).SetWidth(500);

            Cell cell7 = new Cell();
            cell7.Add(new Paragraph("Vendedor").SetPaddings(0, 1, 0, 1).SetFontSize(14).SetTextAlignment(TextAlignment.CENTER));

            Cell cell8 = new Cell();
            cell8.Add(new Paragraph("Comprador").SetPaddings(0, 1, 0, 1).SetFontSize(14).SetTextAlignment(TextAlignment.CENTER));

            Cell cell9 = new Cell();
            cell9.Add(new Paragraph("Nombre: " + documentos.NombreVendedor1).SetPaddings(0, 1, 0, 1).SetFontSize(14).SetTextAlignment(TextAlignment.JUSTIFIED)).SetWidth(250);

            Cell cell10 = new Cell();
            cell10.Add(new Paragraph("Nombre: Automotriz Marbra S.A. DE C.V.").SetPaddings(0, 1, 0, 1).SetFontSize(14).SetTextAlignment(TextAlignment.JUSTIFIED).SetWidth(250));

            Cell cell11 = new Cell();
            cell11.Add(new Paragraph("Dom: " + documentos.Domicilio1 + " " + documentos.EstadoMunicipio1 + " C.P." + documentos.CP1).SetPaddings(0, 1, 0, 1).SetFontSize(14).SetTextAlignment(TextAlignment.JUSTIFIED).SetWidth(250));

            Cell cell12 = new Cell();
            cell12.Add(new Paragraph("Dom: BLVD. DE LAS NACIONES #979, COL. GRANJAS DEL MARQUES, ACAPULCO GRO. C.P. 39890").SetPaddings(0, 1, 0, 1).SetFontSize(14).SetTextAlignment(TextAlignment.JUSTIFIED).SetWidth(250));

            Cell cell13 = new Cell();
            cell13.Add(new Paragraph("Tel: " + documentos.TelefonoVendedor1).SetPaddings(0, 1, 0, 1).SetFontSize(14).SetTextAlignment(TextAlignment.JUSTIFIED).SetWidth(250));

            Cell cell14 = new Cell();
            cell14.Add(new Paragraph("Tel: 7444350710").SetPaddings(0, 1, 0, 1).SetFontSize(14).SetTextAlignment(TextAlignment.JUSTIFIED).SetWidth(250));



            tabla3.AddCell(cell7);
            tabla3.AddCell(cell8);
            tabla3.AddCell(cell9);
            tabla3.AddCell(cell10);
            tabla3.AddCell(cell11);
            tabla3.AddCell(cell12);
            tabla3.AddCell(cell13);
            tabla3.AddCell(cell14);
            documento.Add(tabla3);

            Table tabla4 = new Table(2).SetWidth(500);

            Cell cell15 = new Cell().SetBorder(Border.NO_BORDER).SetWidth(250).SetTextAlignment(TextAlignment.CENTER);
            cell15.Add(new Paragraph("Entregado de Conformidad")).SetTextAlignment(TextAlignment.CENTER);

            Cell cell16 = new Cell().SetBorder(Border.NO_BORDER).SetWidth(250).SetTextAlignment(TextAlignment.CENTER);
            cell16.Add(new Paragraph("Recibí de Conformidad")).SetTextAlignment(TextAlignment.CENTER);

            Cell cell17 = new Cell().SetBorder(Border.NO_BORDER).SetWidth(250).SetTextAlignment(TextAlignment.CENTER);
            cell17.Add(new Paragraph("_______________________")).SetTextAlignment(TextAlignment.CENTER);

            Cell cell18 = new Cell().SetBorder(Border.NO_BORDER).SetWidth(250).SetTextAlignment(TextAlignment.CENTER);
            cell18.Add(new Paragraph("_______________________")).SetTextAlignment(TextAlignment.CENTER);


            tabla4.AddCell(cell15);
            tabla4.AddCell(cell16);
            tabla4.AddCell(cell17);
            tabla4.AddCell(cell18);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(tabla4);
            documento.Add(saltoDeLinea2);



            //AQUI EMPIEZA LA PAGINA 3
            documento.Add(new Paragraph("CONTRATO DE COMPRAVENTA - VENTA DE VEHICULOS USADOS")
               .SetTextAlignment(TextAlignment.CENTER).SetFont(fontcolumnas).SetFontSize(16));

            string hora = DateTime.Now.ToString("hh:mm tt");

            documento.Add(new Paragraph("En Acapulco, Guerrero siendo las " + hora + " hrs. " +
                "del día " + documentos.FechaEscrita1 + " por una parte el Transmitente o " +
                "vendedor: " + documentos.NombreVendedor1 + "," +
                " con dirección: Cond. " + documentos.Domicilio1 + ", " +
                "" + documentos.EstadoMunicipio1 + ", CP " + documentos.CP1 + ", por otra parte el adquiriente o " +
                "comprador de Automotriz Marbra, S.A DE C.V. con " +
                "dirección: Blvd. De las Naciones #979, Col. Granjas del Marques," +
                " Acapulco, Gro. C.P. 39890, Tel.7444350710 al tenor de las siguientes" +
                " Declaraciones y Clausulas").SetTextAlignment(TextAlignment.JUSTIFIED).SetFontSize(9));

            documento.Add(new Paragraph("ACUERDA.").SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).SetBold());
            documento.Add(new Paragraph("Celebrar el presente CONTRATO DE COMPRA - VENTA DE VEHICULOS USADOS").SetTextAlignment(TextAlignment.CENTER).SetFontSize(9));
            documento.Add(new Paragraph("CLAUSULAS.").SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).SetBold());
            documento.Add(new Paragraph("Declara el Comprador").SetTextAlignment(TextAlignment.JUSTIFIED).SetFontSize(10).SetBold());
            documento.Add(new Paragraph("I.	Ser una persona MORAL, cuya actividad " +
                "preponderante es la compra de vehículos nuevos y usados.").SetTextAlignment(TextAlignment.JUSTIFIED).SetFontSize(9));
            documento.Add(new Paragraph("II.	Tener su domicilio en Blvd. De las " +
                "Naciones #979, Col. Granjas del Marques, Acapulco, Gro. C.P. 398900" +
                " con un registro de contribuyentes ACA090512JI4.").SetTextAlignment(TextAlignment.JUSTIFIED).SetFontSize(9));
            documento.Add(new Paragraph("III.	Que es una empresa legalmente " +
                "constituida tal como consta en escritura pública No. Noventa " +
                "y ocho mil ochocientos sesenta y tres (98,863) De fecha 12 de " +
                "Febrero de 2013 de  pasada ante la fe del Notario Público No.99  " +
                "del Lic. José Luis Quevedo Salceda   Notario del distrito federal " +
                "Inscrita en el registro Público de la propiedad y comercio de la " +
                "ciudad de México ").SetTextAlignment(TextAlignment.JUSTIFIED).SetFontSize(9));
            documento.Add(new Paragraph("IV.	Quien está representado por C.P. " +
                "Elizabeth Alvear Jiménez según testimonio notarial No. " +
                "Ciento nueve mil cuatrocientos cuarenta y cuatro 109444  Del distrito " +
                "federal pasada ante la fe del notario público No.99  del Lic. José" +
                " Luis Quevedo Salceda   Notario del distrito federal Inscrita en el " +
                "registro Público de la propiedad y comercio de la ciudad de México.").SetTextAlignment(TextAlignment.JUSTIFIED).SetFontSize(9));

            documento.Add(new Paragraph("Declara el Vendedor").SetTextAlignment(TextAlignment.JUSTIFIED).SetFontSize(10).SetBold());

            documento.Add(new Paragraph("V.	Llamarse como ha quedado expresado " +
                "el VENDEDOR " + documentos.NombreVendedor1 + ", capacidad para obligarse  " +
                "y manifestar que antes  de firmar  ha leído el clausulado de " +
                "este contrato").SetTextAlignment(TextAlignment.JUSTIFIED).SetFontSize(9));

            documento.Add(new Paragraph("VI.	" + documentos.NombreVendedor1 + ", entrega " +
                "en este acto al comprador el automóvil y/o camión de su propiedad " +
                "con la documentación y especificaciones siguientes:").SetTextAlignment(TextAlignment.JUSTIFIED).SetFontSize(9));

            documento.Add(new Paragraph("A.	Marca: " + documentos.Marca1 + "\n " +
                "B.	Serie: " + documentos.Serie1 + " \n" +
                "C.	Tipo: " + documentos.Tipo1 + " \n" +
                "D.	Color exterior: " + documentos.ColorExterior1 + " \n" +
                "E.	Modelo: " + documentos.Modelo1 + " \n" +
                "F.	Color Interior: " + documentos.ColorInterior1 + " \n" +
                "G.	Motor: " + documentos.Motor1 + "  ").SetTextAlignment(TextAlignment.JUSTIFIED).SetFontSize(9));

            documento.Add(new Paragraph("Con la siguiente Documentación: \n" +
                "A.Factura Número: " + documentos.FacturaNumero1 + " \n" +
                "B.Numero de Endosos: (1) \n" +
                "C.Re facturación: (  ) \n" +
                "D.A nombre de: " + documentos.NombreVendedor1 + " \n" +
                "E.Expedida por: AUTOMOTRIZ MARBRA, SA DE CV ")
                .SetTextAlignment(TextAlignment.JUSTIFIED).SetFontSize(9));

            //HOJA NUMERO 4 

            documento.Add(new Paragraph("HOLA").SetFontSize(10));

            Table tabla5 = new Table(11).SetWidth(500);

            tabla5.AddCell("Tenencias");
            tabla5.AddCell("2022");
            tabla5.AddCell("2021");
            tabla5.AddCell("2020");
            tabla5.AddCell("2019");
            tabla5.AddCell("2018");
            tabla5.AddCell("2017");
            tabla5.AddCell("2016");
            tabla5.AddCell("2015");
            tabla5.AddCell("2014");
            tabla5.AddCell("2013");

            tabla5.AddCell(" ");
            if (documentos.A20221 == true)
            {
                tabla5.AddCell("SI");
            }
            else
            {
                tabla5.AddCell("NA");
            }

            if (documentos.A20211 == true)
            {
                tabla5.AddCell("SI");
            }
            else
            {
                tabla5.AddCell("NA");
            }
            if (documentos.A20201 == true)
            {
                tabla5.AddCell("SI");
            }
            else
            {
                tabla5.AddCell("NA");
            }
            if (documentos.A20191 == true)
            {
                tabla5.AddCell("SI");
            }
            else
            {
                tabla5.AddCell("NA");
            }
            if (documentos.A20181 == true)
            {
                tabla5.AddCell("SI");
            }
            else
            {
                tabla5.AddCell("NA");
            }
            if (documentos.A20171 == true)
            {
                tabla5.AddCell("SI");
            }
            else
            {
                tabla5.AddCell("NA");
            }
            if (documentos.A20161 == true)
            {
                tabla5.AddCell("SI");
            }
            else
            {
                tabla5.AddCell("NA");
            }
            if (documentos.A20151 == true)
            {
                tabla5.AddCell("SI");
            }
            else
            {
                tabla5.AddCell("NA");
            }
            if (documentos.A20141 == true)
            {
                tabla5.AddCell("SI");
            }
            else
            {
                tabla5.AddCell("NA");
            }
            if (documentos.A20131 == true)
            {
                tabla5.AddCell("SI");
            }
            else
            {
                tabla5.AddCell("NA");
            }

            documento.Add(tabla5);

            string v = "";
            string tc = "";


            if (documentos.Verificacion1 == true && documentos.NoAplica1 == false)
            {
                v = "SI";
            }
            else if (documentos.Verificacion1 == false && documentos.NoAplica1 == false)
            {
                v = "No";
            }
            else
            {
                v = "No Aplica";
            }

            if (documentos.TarjetaCirculacion1 == true)
            {
                tc = "SI";
            }
            else
            {
                tc = "NO";
            }


            documento.Add(new Paragraph("F.Verificación: " + v + " \n " +
           "G.Tarjeta de circulación número: " + tc + " \n" +
           "H.Juego de placas número: " + documentos.JuegoPlacasNumero1 + " \n" +
           "I.Juego de Llaves: " + documentos.JuegoLlaves1 + ""));

            Table tabla6 = new Table(6).SetWidth(500);

            Cell cel19 = new Cell();
            cel19.Add(new Paragraph("Exteriores").SetBold().SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Cell cel20 = new Cell();
            cel20.Add(new Paragraph("Si").SetBold().SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Cell cel21 = new Cell();
            cel21.Add(new Paragraph("No").SetBold().SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Cell cel22 = new Cell();
            cel22.Add(new Paragraph("Interior").SetBold().SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Cell cel23 = new Cell();
            cel23.Add(new Paragraph("Si").SetBold().SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Cell cel24 = new Cell();
            cel24.Add(new Paragraph("No").SetBold().SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));


            tabla6.AddCell(cel19);
            tabla6.AddCell(cel20);
            tabla6.AddCell(cel21);
            tabla6.AddCell(cel22);
            tabla6.AddCell(cel23);
            tabla6.AddCell(cel24);

            tabla6.AddCell(new Paragraph("Unidades de luces").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Deciciones(documentos.UnidadesLuces1, tabla6);
            tabla6.AddCell(new Paragraph("Instrumento de Tablero").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Deciciones(documentos.InstrumentoTablero1, tabla6);

            tabla6.AddCell(new Paragraph("1/4 de Luces ").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Deciciones(documentos.Luces1, tabla6);
            tabla6.AddCell(new Paragraph("Calefacción, aire Acondicionado ").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Deciciones(documentos.Calefaccion1, tabla6);

            tabla6.AddCell(new Paragraph("Antena ").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Deciciones(documentos.Antena1, tabla6);
            tabla6.AddCell(new Paragraph("Limpiadores").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Deciciones(documentos.Limpiadores1, tabla6);

            tabla6.AddCell(new Paragraph("Espejos Laterales").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Deciciones(documentos.EspejosLaterales1, tabla6);
            tabla6.AddCell(new Paragraph("Radio").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Deciciones(documentos.Radio1, tabla6);

            tabla6.AddCell(new Paragraph("Molduras Completas").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Deciciones(documentos.MoldurasCompletas1, tabla6);
            tabla6.AddCell(new Paragraph("Bocina").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Deciciones(documentos.Bocinas1, tabla6);

            tabla6.AddCell(new Paragraph("Tapon de Gasolina").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Deciciones(documentos.TaponGasolina1, tabla6);
            tabla6.AddCell(new Paragraph("Espejo Retrovisor").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Deciciones(documentos.EspejoRetrovisor1, tabla6);

            tabla6.AddCell(new Paragraph("Carroceria sin Golpes").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Deciciones(documentos.CarroceriaGolpes1, tabla6);
            tabla6.AddCell(new Paragraph("Ceniceros").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Deciciones(documentos.Ceniceros1, tabla6);

            tabla6.AddCell(new Paragraph("Claxon").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Deciciones(documentos.Claxon1, tabla6);
            tabla6.AddCell(new Paragraph("Cinturones de Seguridad").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            Deciciones(documentos.CinturonesSeguridad1, tabla6);

            documento.Add(tabla6);

            documento.Add(new Paragraph("Aceesorios").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED).SetBold());
            Table tabla7 = new Table(3).SetWidth(200);

            tabla7.AddCell(new Paragraph("Accesorios").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED).SetBold());
            tabla7.AddCell(new Paragraph("Si").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED).SetBold());
            tabla7.AddCell(new Paragraph("No").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED).SetBold());

            tabla7.AddCell(new Paragraph("Maneral de Gato").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            tablaP(documentos.ManeralGato1, tabla7);
            tabla7.AddCell(new Paragraph("Llave de Ruedas").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            tablaP(documentos.LlantaRuedas1, tabla7);
            tabla7.AddCell(new Paragraph("Estuche de Herramientas").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            tablaP(documentos.EstucheHerramienta1, tabla7);
            tabla7.AddCell(new Paragraph("Triangulo de seguridad").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            tablaP(documentos.TrianguloSeguridad1, tabla7);
            tabla7.AddCell(new Paragraph("Llanta de Refacción").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            tablaP(documentos.LlantaRefaccion1, tabla7);
            tabla7.AddCell(new Paragraph("Extinguidor").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            tablaP(documentos.Extinguidor1, tabla7);
            tabla7.AddCell(new Paragraph("Carroceria sin golpes").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            tablaP(documentos.CarroceriaGolpes1, tabla7);
            tabla7.AddCell(new Paragraph("Claxon").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            tablaP(documentos.Claxon1, tabla7);

            documento.Add(tabla7);

            documento.Add(new Paragraph("VI.	A decir verdad que la unidad seminueva que les he venido dejando a cuenta tipo " +
                "" + documentos.Tipo1 + " MARCA " + documentos.Marca1 + ", Color " + documentos.ColorExterior1 + " Serie " + documentos.Serie1 + " a cuenta de unidad nueva dicha " +
                "unidad la adquirí legalmente y la entrego completamente libre de cualquier gravamen o vicio constituyéndome " +
                "en único responsable de su saneamiento, así mismo solventare todo problema que se presente respecto de su " +
                "legitima propiedad por su legal y definitiva estancia en el país o por cualquier responsabilidad de carácter " +
                "civil, penal o fiscal que por el mismo resultare hasta la fecha, por lo que en su caso me obligo expresamente" +
                " a efectuar de inmediato la devolución del dinero.").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));

            double num_var = double.Parse(documentos.CantidadCompra1);

            string dinero = String.Format("{0:C}", num_var);

            documento.Add(new Paragraph("VII.	Dicha unidad es valuada a valor de mercado con un " +
                "importe de " + dinero + " (" + documentos.CantidadCompraEscrita1 + " pesos 00/100 M.N.), " +
                "precio que ambas partes aceptan.").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            //HOJA 5
            documento.Add(new Paragraph("VIII.	" + documentos.NombreVendedor1 + ", recibo a mi entera satisfacción, " +
                "el importe convenido de " + dinero + " (" + documentos.CantidadCompraEscrita1 + " pesos 00/100 M.N.) Del cual" +
                " sirviendo este documento como carta de pago.").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));

            documento.Add(new Paragraph("IX.	EL COMPRADOR Automotriz Marbra, S.A DE C.V. después de haber revisado por " +
                "cuenta propia el automóvil y/o camión detallado en la cláusula, lo recibe en las condiciones de uso en que se encuentra.\n\n" +
                "X.     El comprador acepta que por tratarse de una unidad usada adquiere el vehículo objeto del presente contrato en el " +
                "uso en el que se encuentra, el cual fue facilitado para su revisión general, por cuyo motivo cuenta con una garantía de " +
                "30 días en tren motriz excluyéndose  en su caso la correspondientes a las partes eléctricas, que ningún caso será menor " +
                "al establecido en las deposiciones legales. \n\n" +
                "XI.    Al momento de la entrega del vehículo, el vendedor dará a su entera satisfacción y previa validación de su legal " +
                "presencia la siguiente documentación \n\n").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));

            Table tabla8 = new Table(3);

            tabla8.AddCell(new Paragraph("Accesorios").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED).SetBold());
            tabla8.AddCell(new Paragraph("Si").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED).SetBold());
            tabla8.AddCell(new Paragraph("No").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED).SetBold());

            tabla8.AddCell(new Paragraph("Factura").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            tablaP(documentos.FactuaOriginal1, tabla8);
            tabla8.AddCell(new Paragraph("Tarjeta de Circulación").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            tablaP(documentos.TarjetaCirculacion1, tabla8);
            tabla8.AddCell(new Paragraph("Comprovantes de Tenencia").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            tablaP(documentos.ComprobantesTendencia1, tabla8);
            tabla8.AddCell(new Paragraph("Comprovantes de Verificación vehicular").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            tablaP(documentos.ComprobantesVerificacionVehi1, tabla8);
            documento.Add(tabla8);

            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);


            documento.Add(new Paragraph("XII.	El COMPRADOR tendrá derecho a demandar la recisión del presente contrato en términos de " +
                "los artículos  70 y 71 de la ley Federal de protección al consumidor en los siguientes casos:  \n" +
                "A.Por incumplimiento del VENDEDOR  a cualesquiera de las obligaciones estipuladas  en el presente contrato. \n" +
                "B.Si el vehículo presentara vicios ocultos que no hayan sido informados al COMPRADOR  a través del presente contrato. \n" +
                "C.Si el vendedor no entrega el vehículo en la fecha estipulada de presente contrato. \n" +
                "D.Si el vehículo le fuera entregado al COMPRADOR  en condiciones  y con características distintas a las señaladas en la " +
                "primera clausula del presente contrato. ").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));

            documento.Add(new Paragraph("A partir de esta fecha se deslinda de cualquier problema en que sea involucrado el automóvil y/o " +
                "camión, tanto civil, penal o de transito asumiendo toda la responsabilidad el COMPRADOR Automotriz Marbra, S.A DE C.V. " +
                "Manifestando su absoluta conformidad con las cláusulas que anteceden derivado del presente contrato de " +
                "compra-venta " + documentos.NombreVendedor1 + ", (VENDEDOR) y Automotriz Marbra, S.A DE C.V. (COMPRADOR), " +
                "firmando al calce para constancia.").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));

            documento.Add(new Paragraph("VI.	Para todos los efectos legales de este contrato, los contratantes se someten a la " +
                "competencia de la Procuraduría Federal del Consumidor y tribunales del lugar en que se haya suscrito en el presente " +
                "contrato, y regirá por las disposiciones aplicables  de la ley Federal de protección al " +
                "consumidor ").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));

            Table firmas = new Table(2).SetWidth(500);

            Cell c1 = new Cell();
            c1.Add(new Paragraph(documentos.NombreVendedor1).SetFontSize(9).SetTextAlignment(TextAlignment.CENTER).SetBold()
                ).SetBorder(Border.NO_BORDER).SetWidth(250);

            Cell c2 = new Cell();
            c2.Add(new Paragraph("Automotriz Marbra, S.A DE C.V.").SetFontSize(9).SetTextAlignment(TextAlignment.CENTER).SetBold()
                ).SetBorder(Border.NO_BORDER).SetWidth(250);

            Cell c3 = new Cell();
            c3.Add(new Paragraph(" (EL TRANSMITENTE O VENDEDOR)	").SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)
                ).SetBorder(Border.NO_BORDER).SetWidth(250);

            Cell c4 = new Cell();
            c4.Add(new Paragraph(" (COMPRADOR) ").SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)
                ).SetBorder(Border.NO_BORDER).SetWidth(250);

            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);

            firmas.AddCell(c1);
            firmas.AddCell(c2);
            firmas.AddCell(c3);
            firmas.AddCell(c4);
            documento.Add(firmas);


            //hoja 6
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(new Paragraph("ANEXO 4").SetFontSize(16).SetTextAlignment(TextAlignment.CENTER).SetBold());
            documento.Add(new Paragraph("SOLICITUD DE EXPEDICIÓN DE CFDI").SetFontSize(12).SetTextAlignment(TextAlignment.CENTER).SetBold());

            string f = Convert.ToDateTime(documentos.Fecha1).ToString("dd-MM-yyyy");

            documento.Add(new Paragraph("Fecha " + f).SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED));

            documento.Add(new Paragraph("Por este medio quien suscribe: " + documentos.NombreVendedor1 + ", " +
                "con actividad preponderante consistente   en *Sin Actividad Economica y  " +
                "domicilio fiscal ubicado en: " + documentos.Domicilio1 + ", " + documentos.EstadoMunicipio1 + ", CP " + documentos.CP1 + ". " +
                "Manifiesto expresamente mi conformidad  para  que  la  Distribuidora: " +
                "Automotriz Marbra SA de CV. con clave de RFC: ACA-090512-JI4 quien será quirente, " +
                "beneficiario del uso o goce de los bienes o servicios que presto, realice mi inscripción en el " +
                "Registro Federal de Contribuyentes (RFC) en los términos de lo dispuesto por la " +
                "regla I.2.4.3., I.2.7.3.6. y I.2.7.4.1., de la Resolución Miscelánea Fiscal vigente, y en " +
                "consecuencia emita los CFDI por las operaciones de venta de bienes o prestación de servicios que " +
                "celebremos entre ambas partes, al amparo de los dispuesto por la regla I.2.7.3.4 y I.2.7.3.6..").SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED));

            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);

            documento.Add(new Paragraph("Nombre Completo: " + documentos.NombreVendedor1 + "").SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED));
            documento.Add(new Paragraph("Clave CURP: " + documentos.Curp1 + "").SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED));
            documento.Add(new Paragraph("Datos de Identificación Oficial Vigente: " + documentos.NumeroIdentificacion1 + "").SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED));

            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);

            Table tf = new Table(1).SetWidth(500);

            Cell tfc1 = new Cell();
            tfc1.Add(new Paragraph("_____________________").SetFontSize(10).SetTextAlignment(TextAlignment.CENTER)).SetBorder(Border.NO_BORDER);

            Cell tfc2 = new Cell();
            tfc2.Add(new Paragraph("FIRMA").SetFontSize(10).SetTextAlignment(TextAlignment.CENTER)).SetBorder(Border.NO_BORDER);

            tf.AddCell(tfc1);
            tf.AddCell(tfc2);
            documento.Add(tf);

            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);

            documento.Add(new Paragraph("*En el caso de la fracción IV de la regla I.2.4.3. de la RMF (Enajenantes de vehículos usados), " +
                "se deberá señalar como actividad preponderante “Sin actividad económica”").SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED));

            documento.Add(new Paragraph("\n\n\n\n\n\n\n\n\n"));


            documento.Add(new Paragraph("Fecha " + f).SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED));
            documento.Add(new Paragraph("Por este medio quien suscribe: "+documentos.NombreVendedor1+", manifiesto no " +
                "obtener ingresos por las actividades empresariales o profesionales a que se refiere el Capítulo II " +
                "del Título IV de la Ley del ISR.").SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED));

            documento.Add(new Paragraph("\n\n"));
            documento.Add(new Paragraph("Fecha " + f).SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED));
            documento.Add(new Paragraph("Nombre Completo: " + documentos.NombreVendedor1 + "").SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED));
            documento.Add(new Paragraph("Rfc: " + documentos.Rfc1 + "").SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED));
            documento.Add(new Paragraph("Clave CURP: " + documentos.Curp1 + "").SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED));
            documento.Add(new Paragraph("Datos de Identificación Oficial Vigente: " + documentos.NumeroIdentificacion1 + "").SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED));

            documento.Add(new Paragraph("\n\n\n\n\n\n"));

            Table fr = new Table(1).SetWidth(500);

            Cell frc1 = new Cell();
            frc1.Add(new Paragraph("_____________________").SetFontSize(10).SetTextAlignment(TextAlignment.CENTER)).SetBorder(Border.NO_BORDER);

            Cell frc2 = new Cell();
            frc2.Add(new Paragraph("FIRMA").SetFontSize(10).SetTextAlignment(TextAlignment.CENTER)).SetBorder(Border.NO_BORDER);

            fr.AddCell(frc1);
            fr.AddCell(frc2);
            documento.Add(fr);

            documento.Add(new Paragraph("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n"));

            documento.Add(new Paragraph("ANEXO 3").SetFontSize(16).SetTextAlignment(TextAlignment.CENTER).SetBold());
            documento.Add(new Paragraph("SOLICITUD DE EXPEDICIÓN DE CFDI").SetFontSize(12).SetTextAlignment(TextAlignment.CENTER).SetBold());
            documento.Add(new Paragraph("Fecha " + f).SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED));

            documento.Add(new Paragraph("          Por este medio quien suscribe: "+documentos.NombreVendedor1+", con RFC: "+documentos.Rfc1+" " +
                "y con actividad preponderante consistente en * Sin Actividad Económica y domicilio fiscal  " +
                "ubicado en: "+documentos.Domicilio1+", "+documentos.EstadoMunicipio1+"., Manifiesto expresamente mi conformidad  para   " +
                "que   la   Distribuidora: Automotriz Marbra SA de CV.con clave de RFC: ACA - 090512 - JI4 quien será adquirente de la a " +
                "unidad usada de la que soy propietario, emita los CFDI por la operaciones de la venta de bienes(unidad usada) que " +
                "celebremos entre ambas partes, al amparo de los dispuesto por las " +
                "reglas I.2.7.3.4 y I.2.7.3.6. " ).SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED));

            documento.Add(new Paragraph("Nombre Completo: " + documentos.NombreVendedor1 + "").SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED));
            documento.Add(new Paragraph("Clave CURP: " + documentos.Curp1 + "").SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED));
            documento.Add(new Paragraph("Datos de Identificación Oficial Vigente: " + documentos.NumeroIdentificacion1 + "").SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED));

            documento.Add(new Paragraph("\n\n\n\n"));
            
            documento.Add(fr);

            documento.Add(new Paragraph("\n\n"));

            documento.Add(new Paragraph("Notas:\n\n" +
                " “La Persona Física que emitirá la factura de la venta de la unidad usada, realiza la operación como un acto accidental " +
                "de comercio y no le genera obligaciones fiscales adicionales(no está sujeta a lo dispuesto en las secciones I y II del " +
                "Capítulo II del Título IV de la LISR)”\n " +
                "“El comprobante fiscal se expedirá para cumplir con las disposiciones fiscales " +
                "establecidas en el artículo 29 del Código Fiscal de la Federación y sus reglas respectivas”. ").SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED).SetBold());

            documento.Add(new Paragraph("\n\n\n\n"));

            documento.Add(new Paragraph("*En el caso de la fracción IV de la regla I.2.4.3. de la RMF (Enajenantes de vehículos usados), " +
                "se deberá señalar como actividad preponderante “Sin actividad económica”").SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED));

            documento.Add(new Paragraph("\n\n\n"));

            documento.Add(new Paragraph("Fecha: Acapulco, Gro., "+documentos.FechaEscrita1+"").SetFontSize(12).SetTextAlignment(TextAlignment.RIGHT));
            documento.Add(new Paragraph("Por este medio quien suscribe: "+documentos.NombreVendedor1+", manifiesto no tributar y no obtener " +
                "ingresos por las actividades empresariales o profesionales a que se refiere el Capítulo II del Título IV de la " +
                "Ley del ISR.").SetFontSize(12).SetTextAlignment(TextAlignment.JUSTIFIED));

            documento.Add(new Paragraph("\n\n\n"));

            documento.Add(new Paragraph("También manifiesto que el vehículo enajenado a la agencia: AUTOMOTRIZ MARBRA, SA DE CV, no ha sido " +
                "objeto de deducción para efectos de la Ley del ISR.").SetFontSize(12).SetTextAlignment(TextAlignment.JUSTIFIED));

            documento.Add(new Paragraph("\n\n\n"));

            documento.Add(new Paragraph("Fecha " + documentos.FechaEscrita1).SetFontSize(12).SetTextAlignment(TextAlignment.JUSTIFIED));
            documento.Add(new Paragraph("Nombre Completo: " + documentos.NombreVendedor1 + "").SetFontSize(12).SetTextAlignment(TextAlignment.JUSTIFIED));
            documento.Add(new Paragraph("Rfc: " + documentos.Rfc1 + "").SetFontSize(12).SetTextAlignment(TextAlignment.JUSTIFIED));
            documento.Add(new Paragraph("Clave CURP: " + documentos.Curp1 + "").SetFontSize(12).SetTextAlignment(TextAlignment.JUSTIFIED));
            documento.Add(new Paragraph("Datos de Identificación Oficial Vigente: " + documentos.NumeroIdentificacion1 + "").SetFontSize(12).SetTextAlignment(TextAlignment.JUSTIFIED));
            documento.Add(new Paragraph("Datos del Vehiculo:  " + documentos.Tipo1 + "").SetFontSize(12).SetTextAlignment(TextAlignment.JUSTIFIED));
            documento.Add(new Paragraph("Serie: " + documentos.Serie1 + "").SetFontSize(12).SetTextAlignment(TextAlignment.JUSTIFIED));


            documento.Add(new Paragraph("\n\n\n\n"));
            documento.Add(fr);


            documento.Close();
        }

       

        public void tablaP(bool v1, Table tabla)
        {
            if (v1 == true)
            {
                tabla.AddCell(new Paragraph("x").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            }
            else
            {
                tabla.AddCell(new Paragraph("").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            }
            if (v1 == false)
            {
                tabla.AddCell(new Paragraph("x").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            }
            else
            {
                tabla.AddCell(new Paragraph("").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            }
        }


        public void Deciciones(bool v1, Table tabla)
        {

            if (v1 == true)
            {
                tabla.AddCell(new Paragraph("x").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            }
            else
            {
                tabla.AddCell(new Paragraph("").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            }
            if (v1 == false)
            {
                tabla.AddCell(new Paragraph("x").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            }
            else
            {
                tabla.AddCell(new Paragraph("").SetFontSize(9).SetTextAlignment(TextAlignment.JUSTIFIED));
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }


    }
}
