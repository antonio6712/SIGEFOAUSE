using DataAccess;
using Domain;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
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

                documentos.Marca1 = reader["Marca"].ToString();

            }
           
            //ruta de la carpeta documentos del sistema.
            var rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //Creación de la carpeta reportes.
            string FolderReportes = @""+ rutaDocumentos +"/Reportes";
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

            var p1 = new Paragraph("("+documentos.NombreVendedor1+") en mi propio derecho " +
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
                "("+documentos.Tipo1+"  "+documentos.Serie1+") ")
                .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontContenido).SetFontSize(12);

            var p8 = new Paragraph("Atentamente")
                .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontContenido).SetFontSize(12);

            var p9 = new Paragraph("___________________________")
                .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontContenido).SetFontSize(12);

            var p10 = new Paragraph(""+documentos.NombreVendedor1+"")
                .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontContenido).SetFontSize(12);

            var p11 = new Paragraph("" + documentos.Rfc1 + "")
               .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontContenido).SetFontSize(12);

            var p12 = new Paragraph("EMPLEADO")
               .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontContenido).SetFontSize(12);

            var p13 = new Paragraph(""+documentos.Domicilio1+" C.P. "+documentos.CP1+"")
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


            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);
            documento.Add(saltoDeLinea2);

            var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("C:/Users/anton/" +
                "Documents/Antonio/PROYECTOS/SIGEFOAUSE/Presentacion/img/mazdalo.jpeg")).SetWidth(100).SetHeight(50);

            Table table = new Table(10).SetWidth(480).SetHeight(180);
            

            table.AddCell("Factura de Origen");
            table.AddCell("Valor");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");

            table.AddCell("Factura Original");
            table.AddCell("Valor");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");

            table.AddCell("Tarjeta de Circulación");
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
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");

            
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

            
            table.AddCell("LLaves");
            table.AddCell("2");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");
            table.AddCell("");

            
            table.AddCell("Verificación");
            table.AddCell("Valor");
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

            var p15 = new Paragraph( documentos.Marca1  ) 
               .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontcolumnas).SetFontSize(14).SetUnderline();

            var p16 = new Paragraph("Marca: " + documentos.Marca1 + "           Modelo: ")
              .SetTextAlignment(TextAlignment.JUSTIFIED).SetFont(fontcolumnas).SetFontSize(14);
                        

            documento.Add(logo);
            documento.Add(p14);
            documento.Add(p16);
            documento.Add(saltoDeLinea2);
            documento.Add(table);
            documento.Close();



        }
    }
}
