using bovino.dominio;
using System.Collections.Generic; 
using System.Linq;

namespace PROGRAMA_BOVINO.persistencia
{
    public class Repo_Veterinario: I_Repo_Veterinario
    {
        private readonly AppContext _appContext;
        public Repo_Veterinario(AppContext appContext)
        {
            _appContext=appContext;
        }
        Aper_veterinario I_Repo_Veterinario.AddVeterinario(Aper_veterinario veterinario)
        {
            var veterinarioAdicionado= _appContext.Aper_Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }
        IEnumerable <Aper_veterinario>I_Repo_Veterinario.GetAllVeterinario()
        {
            return _appContext.Aper_Veterinarios;
        }
        void I_Repo_Veterinario.DeleteVeterinario(int Id_Veterinario)
        {
            var veterinarioEncontrado=_appContext.Aper_Veterinarios.FirstOrDefault(p=>p.id==Id_Veterinario);
           if(veterinarioEncontrado==null)
           {
                return;
           }
            _appContext.Aper_Veterinarios.Remove(veterinarioEncontrado);
            _appContext.SaveChanges();
                }
        Aper_veterinario I_Repo_Veterinario.UpdateVeterinario(Aper_veterinario veterinario){
            var veterinarioEncontrado =_appContext.Aper_Veterinarios.FirstOrDefault(p=>p.id==veterinario.id);
            if(veterinarioEncontrado!=null)
            {
                        veterinarioEncontrado.Id_Veterinario=veterinario.Id_Veterinario;
                        veterinarioEncontrado.Nombre=veterinario.Nombre;
                        veterinarioEncontrado.Apellido=veterinario.Apellido;
                        veterinarioEncontrado.Identificacion=veterinario.Identificacion;
                        veterinarioEncontrado.Direccion=veterinario.Direccion;
                        veterinarioEncontrado.Telefono=veterinario.Telefono;
                        veterinarioEncontrado.E_mail=veterinario.E_mail;
                        veterinarioEncontrado.Genero=veterinario.Genero;
                        veterinarioEncontrado.Tarjeta_Profesional=veterinario.Tarjeta_Profesional;
                        _appContext.SaveChanges();
                    }
                    return veterinarioEncontrado;
                }
                Aper_veterinario I_Repo_Veterinario.GetVeterinario(int Id_Veterinario)
                {
                    return _appContext.Aper_Veterinarios.FirstOrDefault(p=>p.id==Id_Veterinario);
                }
            }
        }