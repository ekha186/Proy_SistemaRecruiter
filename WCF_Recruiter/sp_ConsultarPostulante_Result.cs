//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Recruiter
{
    using System;
    
    public partial class sp_ConsultarPostulante_Result
    {
        public int codPostulante { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public Nullable<System.DateTime> Fec_Nac { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public System.DateTime Fec_Reg { get; set; }
        public string Usu_Reg { get; set; }
        public System.DateTime Fec_Mod { get; set; }
        public string Usu_Mod { get; set; }
        public Nullable<int> codCargo { get; set; }
        public int codDistrito { get; set; }
        public int codPregrado { get; set; }
        public Nullable<int> codDoctorado { get; set; }
        public Nullable<int> codMaster { get; set; }
        public int codCent_Estu { get; set; }
        public bool Estado { get; set; }
    }
}
