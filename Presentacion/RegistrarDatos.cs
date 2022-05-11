
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class RegistrarDatos : Form
    {
        public RegistrarDatos()
        {
            InitializeComponent();
                        
        }

        private void CheckVisible()
        {
            if (Tenencias.Checked == false)
            {                
                A2013.Visible = false;
                A2014.Visible = false;
                A2015.Visible = false;
                A2016.Visible = false;
                A2017.Visible = false;
                A2018.Visible = false;
                A2019.Visible = false;
                A2020.Visible = false;
                A2021.Visible = false;
                A2022.Visible = false;
            }
            else
            {
                A2013.Visible = true;
                A2014.Visible = true;
                A2015.Visible = true;
                A2016.Visible = true;
                A2017.Visible = true;
                A2018.Visible = true;
                A2019.Visible = true;
                A2020.Visible = true;
                A2021.Visible = true;
                A2022.Visible = true;

            }
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas Seguro de Cancelar el Registro?", "Atención",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Tenencias_CheckedChanged(object sender, EventArgs e)
        {
            CheckVisible();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Documentos documentos = new Documentos();
            documentos.NombreVendedor1 = Nombre.Text;
            documentos.NumeroIdentificacion1 = NumeroIdentificacion.Text;
            documentos.Curp1 = Curp.Text;
            documentos.Rfc1 = Rfc.Text;
            documentos.Domicilio1 = Domicilio.Text;
            documentos.CP1 = Cp.Text;
            documentos.TelefonoVendedor1 = Telefono.Text;
            documentos.EstadoMunicipio1 = EstadoMunicipio.Text;

            documentos.Marca1 = Marca.Text;
            documentos.Modelo1 = Modelo.Text;
            documentos.ColorExterior1 = ColorExterior.Text;
            documentos.ColorInterior1 = ColorInterior.Text;
            documentos.Tipo1 = Tipo.Text;
            documentos.Serie1 = NumeroSerie.Text;
            documentos.JuegoPlacasNumero1 = JuegoPlacas.Text;
            documentos.JuegoLlaves1 = JuegoLLaves.Text;
            documentos.Motor1 = Motor.Text;

            documentos.FacturaOrigen1 = FactuaOrigen.Checked;
            documentos.FactuaOriginal1 = FacturaOriginal.Checked;
            documentos.TarjetaCirculacion1 = TarjetaCirculacion.Checked;
            documentos.ComprobantesTendencia1 = Tenencias.Checked;
            documentos.A20131 = A2013.Checked;
            documentos.A20141 = A2014.Checked;
            documentos.A20151 = A2015.Checked;
            documentos.A20161 = A2016.Checked;
            documentos.A20171 = A2017.Checked;
            documentos.A20181 = A2018.Checked;
            documentos.A20191 = A2019.Checked;
            documentos.A20201 = A2020.Checked;
            documentos.A20211 = A2021.Checked;
            documentos.A20221 = A2022.Checked;
            documentos.Placas = Placas.Checked;
            documentos.Llaves = Llaves.Checked;
            documentos.Verificacion1 = Verificacion.Checked;
            documentos.ComprobantesVerificacionVehi1 = CompVerificacion.Checked;
            documentos.NoAplica1 = NoAplica.Checked;

            documentos.CantidadCompra1 = CantidadCompra.Text;
            documentos.CantidadCompraEscrita1 = CantidadEscrita.Text;
            documentos.Fecha1 = DateTime.Now;
            documentos.FechaEscrita1 = FechaEscrita.Text;
            documentos.FacturaNumero1 = FacturaNumero.Text;

            documentos.UnidadesLuces1 = UnidadesLuces.Checked;
            documentos.Luces1 = CuartoLuces.Checked;
            documentos.Antena1 = Antena.Checked;
            documentos.EspejosLaterales1 = EspejosLaterales.Checked;
            documentos.MoldurasCompletas1 = MolderasCompletas.Checked;
            documentos.TaponGasolina1 = TaponGasolina.Checked;
            documentos.CarroceriaGolpes1 = CarroceriaGolpes.Checked;
            documentos.Claxon1 = Claxon.Checked;

            documentos.InstrumentoTablero1 = InstrumentoTablero.Checked;
            documentos.Calefaccion1 = CalefaccionAire.Checked;
            documentos.Radio1 = Radio.Checked;
            documentos.Bocinas1 = Bocinas.Checked;
            documentos.EspejoRetrovisor1 = EspejoRetrovisor.Checked;
            documentos.Ceniceros1 = Ceniceros.Checked;
            documentos.CinturonesSeguridad1 = CinturonesSeguridad.Checked;

            documentos.ManeralGato1 = ManeralGato.Checked;
            documentos.LlantaRuedas1 = LlaveRuedas.Checked;
            documentos.EstucheHerramienta1 = EstucheHerramientas.Checked;
            documentos.TrianguloSeguridad1 = TrianguloSeguridad.Checked;
            documentos.LlantaRefaccion1 = LlantaRefaccion.Checked;
            documentos.Extinguidor1 = Extinguidor.Checked;
            documentos.Tenencia1 = Tenencias.Checked;

            documentos.Limpiadores1 = Limpiadores.Checked;

            try
            {
                Control control = new Control();
                string respuesta = control.ControlRegistroDocumentos(documentos);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Documentos Registrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListaRegistros ls = new ListaRegistros();
                    
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
