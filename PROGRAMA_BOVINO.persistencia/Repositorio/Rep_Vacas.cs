using bovino.dominio;
using System.Collections.Generic; 
using System.Linq;

namespace PROGRAMA_BOVINO.persistencia
{
    public class Rep_Vacas: I_Repo_Vacas
    {
        private readonly AppContext _appContext;
        public Rep_Vacas(AppContext appContext)
        {
            _appContext=appContext;
        }
        Aper_vaca I_Repo_Vacas.AddVaca(Aper_vaca vaca)
        {
            var vacaAdicionado= _appContext.Aper_Vacas.Add(vaca);
            _appContext.SaveChanges();
            return vacaAdicionado.Entity;
        }
        IEnumerable <Aper_vaca>I_Repo_Vacas.GetAllVaca()
        {
            return _appContext.Aper_Vacas;
        }
        void I_Repo_Vacas.DeleteVaca(int idVaca)
        {
            var vacaEncontrado = _appContext.Aper_Vacas.FirstOrDefault(p=>p.id==idVaca);
           if(vacaEncontrado==null)
           {
                return;
           }
            _appContext.Aper_Vacas.Remove(vacaEncontrado);
            _appContext.SaveChanges();
                }
        Aper_vaca I_Repo_Vacas.UpdateVaca(Aper_vaca vaca){
            var vacaEncontrado =_appContext.Aper_Vacas.FirstOrDefault(p=>p.id==vaca.id);
            if(vacaEncontrado!=null)
            {
                        vacaEncontrado.Cod_Vaca=vaca.Cod_Vaca;
                        vacaEncontrado.Nombre=vaca.Nombre;
                        vacaEncontrado.Color=vaca.Color;
                        vacaEncontrado.Raza=vaca.Raza;
                        vacaEncontrado.Edad=vaca.Edad;
                        vacaEncontrado.Propietario=vaca.Propietario;
                        vacaEncontrado.Veterinario=vaca.Veterinario;
                        vacaEncontrado.Ubicacion=vaca.Ubicacion;
                        _appContext.SaveChanges();
                    }
                    return vacaEncontrado;
                }
                Aper_vaca I_Repo_Vacas.GetVaca(int idVaca)
                {
                    return _appContext.Aper_Vacas.FirstOrDefault(p=>p.id==idVaca);
                }
            }
        }