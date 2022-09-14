using bovino.dominio;
using System.Collections.Generic; 
using System.Linq;

namespace PROGRAMA_BOVINO.persistencia{
    public class repositorioHistoriaClinica : interRepositorioHistoriaClinica {
        
        private readonly appContext _appContext;
        public repositorioHistoriaClinica(appContext appContext1){
            _appContext=appContext1;
        }
        
        Historia_Clinica interRepositorioHistoriaClinica.AddHistoriaClinica(Historia_Clinica historiaClinica){
            var addedHistoriaClinica=_appContext.Historia_Clinica.Add(historiaClinica);
            _appContext.SaveChanges();
            return addedHistoriaClinica.Entity;
            
        }
        IEnumerable<Historia_Clinica> interRepositorioHistoriaClinica.GetAllHistoriaClinica(){
            return _appContext.Historia_Clinica;
        }
        void interRepositorioHistoriaClinica.DeleteHistoriaClinica(int idHistoriaClinica){
            var foundHistoriaClinica = _appContext.Historia_Clinica.FirstOrDefault(p=>p.id==idHistoriaClinica);
            if(foundHistoriaClinica==null){
                return;
            }
            _appContext.Historia_Clinica.Remove(foundHistoriaClinica);
            _appContext.SaveChanges();
        }
        Historia_Clinica interRepositorioHistoriaClinica.UpdateHistoriaClinica(Historia_Clinica newHistoriaClinica){
            var foundHistoriaClinica = _appContext.Historia_Clinica.FirstOrDefault(p=>p.id==newHistoriaClinica.id);
            if(foundHistoriaClinica!=null){
                foundHistoriaClinica.Fecha_Visita=newHistoriaClinica.Fecha_Visita;
                foundHistoriaClinica.Id_Vaca=newHistoriaClinica.Id_Vaca;
                foundHistoriaClinica.Id_Veterinario=newHistoriaClinica.Id_Veterinario;
                foundHistoriaClinica.Temperatura=newHistoriaClinica.Temperatura;
                foundHistoriaClinica.Peso=newHistoriaClinica.Peso;
                foundHistoriaClinica.Frecuencia_Respiratoria=newHistoriaClinica.Frecuencia_Respiratoria;
                foundHistoriaClinica.Frecuencia_Cardiaca=newHistoriaClinica.Frecuencia_Cardiaca;
                foundHistoriaClinica.Estado_Animo=newHistoriaClinica.Estado_Animo;
                foundHistoriaClinica.Diagnostico=newHistoriaClinica.Diagnostico;
                foundHistoriaClinica.Recomendaciones=newHistoriaClinica.Recomendaciones;
                foundHistoriaClinica.Medicamentos=newHistoriaClinica.Medicamentos;
                _appContext.SaveChanges();
            }
            return foundHistoriaClinica;
        }
        Historia_Clinica interRepositorioHistoriaClinica.GetHistoriaClinica(int idHistoriaClinica){
            return _appContext.Historia_Clinica.FirstOrDefault(p=>p.id==idHistoriaClinica);
        }
    }
}