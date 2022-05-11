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
            Verificacion , EstucheHerramienta, CompVerificacion, Tenencia, A2022, NoAplica,Limpiadores;

        string CantidadCompra, CantidadCompraEscrita, ColorExterior, ColorInterior, CP, Curp, Domicilio,
            FacturaNumero, FechaEscrita, JuegoLlaves, JuegoPlacasNumero, Marca, Modelo, Motor, NombreVendedor,
            NumeroIdentificacion, Rfc, Serie, TelefonoVendedor, Tipo, EstadoMunicipio;

        DateTime Fecha;

        public bool A20131 { get => A20132; set => A20132 = value; }
        public bool A20141 { get => A20142; set => A20142 = value; }
        public bool A20151 { get => A20152; set => A20152 = value; }
        public bool A20161 { get => A20162; set => A20162 = value; }
        public bool A20171 { get => A20172; set => A20172 = value; }
        public bool A20181 { get => A20182; set => A20182 = value; }
        public bool A20191 { get => A20192; set => A20192 = value; }
        public bool A20201 { get => A20202; set => A20202 = value; }
        public bool A20211 { get => A20212; set => A20212 = value; }
        public bool Antena1 { get => Antena2; set => Antena2 = value; }
        public bool Bocinas1 { get => Bocinas2; set => Bocinas2 = value; }
        public bool Calefaccion1 { get => Calefaccion2; set => Calefaccion2 = value; }
        public bool CarroceriaGolpes1 { get => CarroceriaGolpes2; set => CarroceriaGolpes2 = value; }
        public bool Ceniceros1 { get => Ceniceros2; set => Ceniceros2 = value; }
        public bool CinturonesSeguridad1 { get => CinturonesSeguridad2; set => CinturonesSeguridad2 = value; }
        public bool Claxon1 { get => Claxon2; set => Claxon2 = value; }
        public bool ComprobantesVerificacionVehi1 { get => ComprobantesVerificacionVehi2; set => ComprobantesVerificacionVehi2 = value; }
        public bool ComprobantesTendencia1 { get => ComprobantesTendencia2; set => ComprobantesTendencia2 = value; }
        public bool EspejoRetrovisor1 { get => EspejoRetrovisor2; set => EspejoRetrovisor2 = value; }
        public bool EspejosLaterales1 { get => EspejosLaterales2; set => EspejosLaterales2 = value; }
        public bool Extinguidor1 { get => Extinguidor2; set => Extinguidor2 = value; }
        public bool FacturaOrigen1 { get => FacturaOrigen2; set => FacturaOrigen2 = value; }
        public bool FactuaOriginal1 { get => FactuaOriginal2; set => FactuaOriginal2 = value; }
        public bool InstrumentoTablero1 { get => InstrumentoTablero2; set => InstrumentoTablero2 = value; }
        public bool LlantaRefaccion1 { get => LlantaRefaccion2; set => LlantaRefaccion2 = value; }
        public bool LlantaRuedas1 { get => LlantaRuedas2; set => LlantaRuedas2 = value; }
        public bool Llaves { get => Llaves1; set => Llaves1 = value; }
        public bool Luces1 { get => Luces2; set => Luces2 = value; }
        public bool ManeralGato1 { get => ManeralGato2; set => ManeralGato2 = value; }
        public bool MoldurasCompletas1 { get => MoldurasCompletas2; set => MoldurasCompletas2 = value; }
        public bool Placas { get => Placas1; set => Placas1 = value; }
        public bool Radio1 { get => Radio2; set => Radio2 = value; }
        public bool TaponGasolina1 { get => TaponGasolina2; set => TaponGasolina2 = value; }
        public bool TarjetaCirculacion1 { get => TarjetaCirculacion2; set => TarjetaCirculacion2 = value; }
        public bool TrianguloSeguridad1 { get => TrianguloSeguridad2; set => TrianguloSeguridad2 = value; }
        public bool UnidadesLuces1 { get => UnidadesLuces2; set => UnidadesLuces2 = value; }
        public bool Verificacion1 { get => Verificacion2; set => Verificacion2 = value; }
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
        public bool EstucheHerramienta1 { get => EstucheHerramienta2; set => EstucheHerramienta2 = value; }
        public bool CompVerificacion1 { get => CompVerificacion2; set => CompVerificacion2 = value; }
        public bool Tenencia1 { get => Tenencia2; set => Tenencia2 = value; }
        public string EstadoMunicipio1 { get => EstadoMunicipio; set => EstadoMunicipio = value; }
        public bool A20221 { get => A20222; set => A20222 = value; }
        public bool A20132 { get => A2013; set => A2013 = value; }
        public bool A20142 { get => A2014; set => A2014 = value; }
        public bool A20152 { get => A2015; set => A2015 = value; }
        public bool A20162 { get => A2016; set => A2016 = value; }
        public bool A20172 { get => A2017; set => A2017 = value; }
        public bool A20182 { get => A2018; set => A2018 = value; }
        public bool A20192 { get => A2019; set => A2019 = value; }
        public bool A20202 { get => A2020; set => A2020 = value; }
        public bool A20212 { get => A2021; set => A2021 = value; }
        public bool Antena2 { get => Antena; set => Antena = value; }
        public bool Bocinas2 { get => Bocinas; set => Bocinas = value; }
        public bool Calefaccion2 { get => Calefaccion; set => Calefaccion = value; }
        public bool CarroceriaGolpes2 { get => CarroceriaGolpes; set => CarroceriaGolpes = value; }
        public bool Ceniceros2 { get => Ceniceros; set => Ceniceros = value; }
        public bool CinturonesSeguridad2 { get => CinturonesSeguridad; set => CinturonesSeguridad = value; }
        public bool Claxon2 { get => Claxon; set => Claxon = value; }
        public bool ComprobantesVerificacionVehi2 { get => ComprobantesVerificacionVehi; set => ComprobantesVerificacionVehi = value; }
        public bool ComprobantesTendencia2 { get => ComprobantesTendencia; set => ComprobantesTendencia = value; }
        public bool EspejoRetrovisor2 { get => EspejoRetrovisor; set => EspejoRetrovisor = value; }
        public bool EspejosLaterales2 { get => EspejosLaterales; set => EspejosLaterales = value; }
        public bool Extinguidor2 { get => Extinguidor; set => Extinguidor = value; }
        public bool FacturaOrigen2 { get => FacturaOrigen; set => FacturaOrigen = value; }
        public bool FactuaOriginal2 { get => FactuaOriginal; set => FactuaOriginal = value; }
        public bool InstrumentoTablero2 { get => InstrumentoTablero; set => InstrumentoTablero = value; }
        public bool LlantaRefaccion2 { get => LlantaRefaccion; set => LlantaRefaccion = value; }
        public bool LlantaRuedas2 { get => LlantaRuedas; set => LlantaRuedas = value; }
        public bool Llaves1 { get => llaves; set => llaves = value; }
        public bool Luces2 { get => Luces; set => Luces = value; }
        public bool ManeralGato2 { get => ManeralGato; set => ManeralGato = value; }
        public bool MoldurasCompletas2 { get => MoldurasCompletas; set => MoldurasCompletas = value; }
        public bool Placas1 { get => placas; set => placas = value; }
        public bool Radio2 { get => Radio; set => Radio = value; }
        public bool TaponGasolina2 { get => TaponGasolina; set => TaponGasolina = value; }
        public bool TarjetaCirculacion2 { get => TarjetaCirculacion; set => TarjetaCirculacion = value; }
        public bool TrianguloSeguridad2 { get => TrianguloSeguridad; set => TrianguloSeguridad = value; }
        public bool UnidadesLuces2 { get => UnidadesLuces; set => UnidadesLuces = value; }
        public bool Verificacion2 { get => Verificacion; set => Verificacion = value; }
        public bool EstucheHerramienta2 { get => EstucheHerramienta; set => EstucheHerramienta = value; }
        public bool CompVerificacion2 { get => CompVerificacion; set => CompVerificacion = value; }
        public bool Tenencia2 { get => Tenencia; set => Tenencia = value; }
        public bool A20222 { get => A2022; set => A2022 = value; }
        public bool NoAplica1 { get => NoAplica; set => NoAplica = value; }
        public bool Limpiadores1 { get => Limpiadores; set => Limpiadores = value; }
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
