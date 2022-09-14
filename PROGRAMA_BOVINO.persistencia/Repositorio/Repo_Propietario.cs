using bovino.dominio;
using System.Collections.Generic; 
using System.Linq;

namespace PROGRAMA_BOVINO.persistencia
{
    public class Repo_Propietario: I_Repo_Propietario
    {
        private readonly AppContext _appContext;
        public Repo_Propietario(AppContext appContext)
        {
            _appContext=appContext;
        }
        Aper_propietario I_Repo_Propietario.AddPropietario(Aper_propietario propietario)
        {
            var propietarioAdicionado= _appContext.Aper_Propietarios.Add(propietario);
            _appContext.SaveChanges();
            return propietarioAdicionado.Entity;
        }
        IEnumerable <Aper_propietario>I_Repo_Propietario.GetAllPropietario()
        {
            return _appContext.Aper_Propietarios;
        }
        void I_Repo_Propietario.DeletePropietario(int Id_Propietario)
        {
            var propietarioEncontrado=_appContext.Aper_Propietarios.FirstOrDefault(p=>p.id==Id_Propietario);
           if(propietarioEncontrado==null)
           {
                return;
           }
            _appContext.Aper_Propietarios.Remove(propietarioEncontrado);
            _appContext.SaveChanges();
                }
        Aper_propietario I_Repo_Propietario.UpdatePropietario(Aper_propietario propietario){
            var propietarioEncontrado =_appContext.Aper_Propietarios.FirstOrDefault(p=>p.id==propietario.id);
            if(propietarioEncontrado!=null)
            {
                        propietarioEncontrado.Id_Propietario=propietario.Id_Propietario;
                        propietarioEncontrado.Nombre=propietario.Nombre;
                        propietarioEncontrado.Apellido=propietario.Apellido;
                        propietarioEncontrado.Direccion=propietario.Direccion;
                        propietarioEncontrado.Telefono=propietario.Telefono;
                        propietarioEncontrado.E_mail=propietario.E_mail;
                        propietarioEncontrado.Genero=propietario.Genero;
                        propietarioEncontrado.Nombre_Hacienda=propietario.Nombre_Hacienda;
                        _appContext.SaveChanges();
                    }
                    return propietarioEncontrado;
                }
                Aper_propietario I_Repo_Propietario.GetPropietario(int Id_Propietario)
                {
                    return _appContext.Aper_Propietarios.FirstOrDefault(p=>p.id==Id_Propietario);
                }
            }
        }