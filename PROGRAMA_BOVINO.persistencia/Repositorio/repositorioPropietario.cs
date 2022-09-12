using bovino.dominio;
using System.Collections.Generic; 
using System.Linq;

namespace PROGRAMA_BOVINO.persistencia{
    public class repositorioPropietario : interRepositorioVacas {
        
        private readonly appContext _appContext;
        public repositorioPropietario(appContext appContext1){
            _appContext=appContext1;
        }
        
        Aper_propietario interRepositorioVacas.AddPropietario(Aper_propietario propietario){
            var addedPropietario=_appContext.Aper_propietario.Add(propietario);
            _appContext.SaveChanges();
            return addedPropietario.Entity;
            
        }
        IEnumerable<Aper_propietario> interRepositorioVacas.GetAllPropíetario(){
            return _appContext.Aper_propietario;
        }
        void interRepositorioVacas.DeletePropietario(int IdPropietario){
            var foundPropietario = _appContext.Aper_propietario.FirstOrDefault(p=>p.id==IdPropietario);
            if(foundPropietario==null){
                return;
            }
            _appContext.Aper_propietario.Remove(foundPropietario);
            _appContext.SaveChanges();
        }
        Aper_propietario interRepositorioVacas.UpdatePropietario(Aper_propietario newPropietario){
            var foundPropietario = _appContext.Aper_propietario.FirstOrDefault(p=>p.id==newPropietario.id);
            if(foundPropietario!=null){
                foundPropietario.Id_Propietario=newPropietario.Id_Propietario;
                foundPropietario.Nombre=newPropietario.Nombre;
                foundPropietario.Apellido=newPropietario.Apellido;
                foundPropietario.Direccion=newPropietario.Direccion;
                foundPropietario.Telefono=newPropietario.Telefono;
                foundPropietario.E_mail=newPropietario.E_mail;
                foundPropietario.Genero=newPropietario.Genero;
                foundPropietario.Nombre_Hacienda=newPropietario.Nombre_Hacienda;
                _appContext.SaveChanges();
            }
            return foundPropietario;
        }
        Aper_propietario interRepositorioVacas.GetPropietario(int IdPropietario){
            return _appContext.Aper_propietario.FirstOrDefault(p=>p.id==IdPropietario);
        }
    }
}