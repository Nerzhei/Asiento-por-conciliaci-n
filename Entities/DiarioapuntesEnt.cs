using System;

namespace ICG.FrontRetail.Datos.Entidades
{
    public class DiarioapuntesEnt
    {
        public string Usuario { get; set; }
        public int Asiento { get; set; }
        public int Apunte { get; set; }
        public string  Nivel { get; set; }
        public DateTime Fecha { get; set; }
        public string Cuenta { get; set; }
        public int Concepto { get; set; }
        public string Comentario { get; set; }
        public string Seriedocumento { get; set; }
        public int? Numerodocumento { get; set; }
        public float? Debe { get; set; }
        public float? Haber { get; set; }
        public string Libroiva { get; set; }
        public int? Costes { get; set; }
        public int? Punteo { get; set; }
        public string Retencion { get; set; }
        public string Centrocoste { get; set; }
        public float Factormoneda { get; set; }
        public int Codmoneda { get; set; }
        public int? Empresagestion { get; set; }
        public float? Debe1 { get; set; }
        public float? Haber2 { get; set; }
        public string Pnorma43Str { get; set; }
        public int? Asientovisible { get; set; }
        public int? Codmonedadc { get; set; }
        public int? Tipodocumento { get; set; }
        public string Seriefiscal { get; set; }
        public int? Codtercero { get; set; }
        public byte[] Terceroescliente { get; set; }
        public int? Numerofiscal { get; set; }
    }
}
