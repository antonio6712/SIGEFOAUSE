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
                documentos.Tipo1 = reader["Tipo"].ToString();
                documentos.Motor1 = reader["Motor"].ToString();
                documentos.Serie1 = reader["Serie"].ToString();

                documentos.JuegoLlaves1 = reader["Llaves"].ToString();
                documentos.Verificacion1 = Convert.ToBoolean(reader["Verificacion"]);

                documentos.CantidadCompra1 = reader["CantidadCompra"].ToString();
                documentos.CantidadCompraEscrita1 = reader["CantidadCompraEscrita"].ToString();

                documentos.FechaEscrita1 = reader["FechaEscrita"].ToString();

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
            Cell cell1 = new Cell(1,1); 
            cell1.SetBorder(Border.NO_BORDER);
            //Paragraph marca = new Paragraph(documentos.Marca1).SetUnderline();
            cell1.Add(new Paragraph("Marca: " + documentos.Marca1).SetPaddings(0,1,0,1).SetFontSize(14));

            Cell cell2 = new Cell(1,2);
            cell2.SetBorder(Border.NO_BORDER);
            cell2.Add(new Paragraph("Modelo: " + documentos.Modelo1).SetPaddings(0, 1, 0, 1).SetFontSize(14));

            Cell cell3 = new Cell(2,1);
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
                "cantidad de: $"+documentos.CantidadCompra1+" ("+documentos.CantidadCompraEscrita1+"  " +
                "pesos  00/100 M.N.) ").SetFontSize(8).SetTextAlignment(TextAlignment.JUSTIFIED));

            documento.Add(saltoDeLinea2);
            documento.Add(new Paragraph("Estando de conformidad ambas partes, " +
                "con los derechos y obligaciones, firma alcance para  " +
                "la constancia.").SetFontSize(8).SetTextAlignment(TextAlignment.JUSTIFIED));

            documento.Add(new Paragraph(documentos.EstadoMunicipio1 +" "+ documentos.FechaEscrita1).SetFontSize(10).SetBold());

            Table tabla3 = new Table(2).SetWidth(500);

            Cell cell7 = new Cell(1, 1);            
            cell7.Add(new Paragraph("Vendedor").SetPaddings(0, 1, 0, 1).SetFontSize(14).SetTextAlignment(TextAlignment.CENTER));

            Cell cell8 = new Cell(1, 2);
            cell8.Add(new Paragraph("Comprador").SetPaddings(0, 1, 0, 1).SetFontSize(14).SetTextAlignment(TextAlignment.CENTER))

            Cell cell9 = new Cell(2, 1);
            cell9.Add(new Paragraph("Nombre: "+ documentos.NombreVendedor1).SetPaddings(0, 1, 0, 1).SetFontSize(14).SetTextAlignment(TextAlignment.JUSTIFIED)).SetWidth(250).SetFontFamily(FontFamily);

            Cell cell10 = new Cell(2, 1);
            cell10.Add(new Paragraph("Nombre: Automotriz Marbra S.A. DE C.V." + documentos.NombreVendedor1).SetPaddings(0, 1, 0, 1).SetFontSize(14).SetTextAlignment(TextAlignment.JUSTIFIED).SetWidth(250));


            tabla3.AddCell(cell7);
            tabla3.AddCell(cell8);
            tabla3.AddCell(cell9);
            tabla3.AddCell(cell10);


            documento.Add(tabla3);
            
            documento.Close();



        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM documento where iddocumento = 1;";
            MySqlConnection conexion = ConnectionToSql.getConnection();
            conexion.Open();
            MySqlDataReader reader;

            MySqlCommand comando = new MySqlCommand(query, conexion);
            reader = comando.ExecuteReader();

            reader.Read();

            bool a2021 = Convert.ToBoolean(reader["2021"]);


        }
    }
}
