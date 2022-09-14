// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using PROGRAMA_BOVINO.persistencia;
using bovino.dominio;
namespace PROGRAMA_BOVINO.consola
{
    class Programa 
    {
        private static I_Repo_Propietario _Repo_Propietario = new Repo_Propietario (new persistencia.AppContext());
        static void Main (string[] args)
        {
            Console.WriteLine("Hola Mundo");
            AdicionarPropietario();
        }
        private static void AdicionarPropietario()
        {
            var propietario = new Aper_propietario()
            {
                Identificacion      = 79006416,
                Nombre              = "Freddy",
                Apellido            = "Vasquez",
                Direccion           = "Cra 69C # 3 14",
                Telefono            = "3123824288",
                E_mail              = "freddy.vasquez.c@hotmail.com",
                Genero              = "Masculino",


            };
            _Repo_Propietario.AddPropietario(propietario);
            
        }
    }
}
