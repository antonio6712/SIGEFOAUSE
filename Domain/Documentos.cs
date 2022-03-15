using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Documentos
    {
        int iddocumento;

        bool A2013, A2014, A2015, A2016, A2017, A2018, A2019, A2020, A2021, Antena, Bocinas, Calefaccion,
            CarroceriaGolpes, Ceniceros, CinturonesSeguridad, Claxon, ComprobantesVerificacionVehi,
            ComprobantesTendencia, EspejoRetrovisor, EspejosLaterales, Extinguidor, FacturaOrigen,
            FactuaOriginal, InstrumentoTablero, LlantaRefaccion, LlantaRuedas, llaves,Luces, ManeralGato,
            MoldurasCompletas, placas, Radio, TaponGasolina,TarjetaCirculacion, TrianguloSeguridad,UnidadesLuces,
            Verificacion , EstucheHerramienta, CompVerificacion, Tenencia;

        string CantidadCompra, CantidadCompraEscrita, ColorExterior, ColorInterior, CP, Curp, Domicilio,
            FacturaNumero, FechaEscrita, JuegoLlaves, JuegoPlacasNumero, Marca, Modelo, Motor, NombreVendedor,
            NumeroIdentificacion, Rfc, Serie, TelefonoVendedor, Tipo, EstadoMunicipio;

        DateTime Fecha;

        public bool A20131 { get => A2013; set => A2013 = value; }
        public bool A20141 { get => A2014; set => A2014 = value; }
        public bool A20151 { get => A2015; set => A2015 = value; }
        public bool A20161 { get => A2016; set => A2016 = value; }
        public bool A20171 { get => A2017; set => A2017 = value; }
        public bool A20181 { get => A2018; set => A2018 = value; }
        public bool A20191 { get => A2019; set => A2019 = value; }
        public bool A20201 { get => A2020; set => A2020 = value; }
        public bool A20211 { get => A2021; set => A2021 = value; }
        public bool Antena1 { get => Antena; set => Antena = value; }
        public bool Bocinas1 { get => Bocinas; set => Bocinas = value; }
        public bool Calefaccion1 { get => Calefaccion; set => Calefaccion = value; }
        public bool CarroceriaGolpes1 { get => CarroceriaGolpes; set => CarroceriaGolpes = value; }
        public bool Ceniceros1 { get => Ceniceros; set => Ceniceros = value; }
        public bool CinturonesSeguridad1 { get => CinturonesSeguridad; set => CinturonesSeguridad = value; }
        public bool Claxon1 { get => Claxon; set => Claxon = value; }
        public bool ComprobantesVerificacionVehi1 { get => ComprobantesVerificacionVehi; set => ComprobantesVerificacionVehi = value; }
        public bool ComprobantesTendencia1 { get => ComprobantesTendencia; set => ComprobantesTendencia = value; }
        public bool EspejoRetrovisor1 { get => EspejoRetrovisor; set => EspejoRetrovisor = value; }
        public bool EspejosLaterales1 { get => EspejosLaterales; set => EspejosLaterales = value; }
        public bool Extinguidor1 { get => Extinguidor; set => Extinguidor = value; }
        public bool FacturaOrigen1 { get => FacturaOrigen; set => FacturaOrigen = value; }
        public bool FactuaOriginal1 { get => FactuaOriginal; set => FactuaOriginal = value; }
        public bool InstrumentoTablero1 { get => InstrumentoTablero; set => InstrumentoTablero = value; }
        public bool LlantaRefaccion1 { get => LlantaRefaccion; set => LlantaRefaccion = value; }
        public bool LlantaRuedas1 { get => LlantaRuedas; set => LlantaRuedas = value; }
        public bool Llaves { get => llaves; set => llaves = value; }
        public bool Luces1 { get => Luces; set => Luces = value; }
        public bool ManeralGato1 { get => ManeralGato; set => ManeralGato = value; }
        public bool MoldurasCompletas1 { get => MoldurasCompletas; set => MoldurasCompletas = value; }
        public bool Placas { get => placas; set => placas = value; }
        public bool Radio1 { get => Radio; set => Radio = value; }
        public bool TaponGasolina1 { get => TaponGasolina; set => TaponGasolina = value; }
        public bool TarjetaCirculacion1 { get => TarjetaCirculacion; set => TarjetaCirculacion = value; }
        public bool TrianguloSeguridad1 { get => TrianguloSeguridad; set => TrianguloSeguridad = value; }
        public bool UnidadesLuces1 { get => UnidadesLuces; set => UnidadesLuces = value; }
        public bool Verificacion1 { get => Verificacion; set => Verificacion = value; }
        public string CantidadCompra1 { get => CantidadCompra; set => CantidadCompra = value; }
        public string CantidadCompraEscrita1 { get => CantidadCompraEscrita; set => CantidadCompraEscrita = value; }
        public string ColorExterior1 { get => ColorExterior; set => ColorExterior = value; }
        public string ColorInterior1 { get => ColorInterior; set => ColorInterior = value; }
        public string CP1 { get => CP; set => CP = value; }
        public string Curp1 { get => Curp; set => Curp = value; }
        public string Domicilio1 { get => Domicilio; set => Domicilio = value; }
        public string FacturaNumero1 { get => FacturaNumero; set => FacturaNumero = value; }
        public string FechaEscrita1 { get => FechaEscrita; set => FechaEscrita = value; }
        public string JuegoLlaves1 { get => JuegoLlaves; set => JuegoLlaves = value; }
        public string JuegoPlacasNumero1 { get => JuegoPlacasNumero; set => JuegoPlacasNumero = value; }
        public string Marca1 { get => Marca; set => Marca = value; }
        public string Modelo1 { get => Modelo; set => Modelo = value; }
        public string Motor1 { get => Motor; set => Motor = value; }
        public string NombreVendedor1 { get => NombreVendedor; set => NombreVendedor = value; }
        public string NumeroIdentificacion1 { get => NumeroIdentificacion; set => NumeroIdentificacion = value; }
        public string Rfc1 { get => Rfc; set => Rfc = value; }
        public string Serie1 { get => Serie; set => Serie = value; }
        public string TelefonoVendedor1 { get => TelefonoVendedor; set => TelefonoVendedor = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public int Iddocumento { get => iddocumento; set => iddocumento = value; }
        public bool EstucheHerramienta1 { get => EstucheHerramienta; set => EstucheHerramienta = value; }
        public bool CompVerificacion1 { get => CompVerificacion; set => CompVerificacion = value; }
        public bool Tenencia1 { get => Tenencia; set => Tenencia = value; }
        public string EstadoMunicipio1 { get => EstadoMunicipio; set => EstadoMunicipio = value; }
    }

    public class DocumentosTabla
    {
        int iddocumento;
        string NombreVendedor, Rfc, FacturaNumero, Usuario;
        DateTime Fecha;

        
        public string NombreVendedor1 { get => NombreVendedor; set => NombreVendedor = value; }        
        public string Rfc1 { get => Rfc; set => Rfc = value; }        
        public string FacturaNumero1 { get => FacturaNumero; set => FacturaNumero = value; }        
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public int Iddocumento { get => iddocumento; set => iddocumento = value; }
    }
}
