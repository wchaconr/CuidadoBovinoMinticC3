using bovino.dominio;
using System.Collections.Generic; 
using System.Linq;

namespace PROGRAMA_BOVINO.persistencia{
    public class repositorioVacas : interRepositorioVacas {
        
        private readonly appContext _appContext;
        public repositorioVacas(appContext appContext1){
            _appContext=appContext1;
        }
        
        Aper_vaca interRepositorioVacas.AddVaca(Aper_vaca vaca){
            var addedVaca=_appContext.Aper_vaca.Add(vaca);
            _appContext.SaveChanges();
            return addedVaca.Entity;
            
        }
        IEnumerable<Aper_vaca> interRepositorioVacas.GetAllVaca(){
            return _appContext.Aper_vaca;
        }
        void interRepositorioVacas.DeleteVaca(int idVaca){
            var foundVaca = _appContext.Aper_vaca.FirstOrDefault(p=>p.id==idPatient);
            if(foundVaca==null){
                return;
            }
            _appContext.Aper_vaca.Remove(foundVaca);
            _appContext.SaveChanges();
        }
        Aper_vaca interRepositorioVacas.UpdateVaca(Aper_vaca newVaca){
            var foundVaca = _appContext.Aper_vaca.FirstOrDefault(p=>p.id==newPatient.id);
            if(foundVaca!=null){
                foundVaca.Cod_Vaca=newVaca.Cod_Vaca;
                foundVaca.Nombre=newVaca.Nombre;
                foundVaca.Color=newVaca.Color;
                foundVaca.Raza=newVaca.Raza;
                foundVaca.Edad=newVaca.Edad;
                foundVaca.Propietario=newVaca.Propietario;
                foundVaca.Veterinario=newVaca.Veterinario;
                foundVaca.Ubicacion=newVaca.Ubicacion;
                _appContext.SaveChanges();
            }
            return foundVaca;
        }
        Aper_vaca interRepositorioVacas.GetVaca(int idVaca){
            return _appContext.Aper_vaca.FirstOrDefault(p=>p.id==idVaca);
        }
    }
}