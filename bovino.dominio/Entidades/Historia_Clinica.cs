using System;

namespace bovino.dominio
{
    public class Historia_Clinica
    {
        public int id{get;set;}
        public int Id_Historia{get;set;}
        public String Fecha_Visita{get;set;}
        public int Id_Vaca{get;set;}
        public int Id_Veterinario{get;set;}
        public double Temperatura{get;set;}
        public double Peso{get;set;}
        public int Frecuencia_Respiratoria{get;set;}
        public int Frecuencia_Cardiaca {get;set;}
        public String Estado_Animo{get;set;}
        public String Diagnostico {get;set;}
        public String Recomendaciones {get;set;}
        public String Medicamentos {get;set;}
    }
}