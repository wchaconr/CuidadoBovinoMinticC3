using bovino.dominio;
using System.Collections.Generic; 
using System.Linq;

namespace PROGRAMA_BOVINO.persistencia
{
    public class Repo_Historia_Clinica: I_Repo_Historia_Clinica
    {
        private readonly AppContext _appContext;
        public Repo_Historia_Clinica(AppContext appContext)
        {
            _appContext=appContext;
        }
        Historia_Clinica I_Repo_Historia_Clinica.AddHistoria(Historia_Clinica historia)
        {
            var historiaAdicionado= _appContext.Historias_Clinicas.Add(historia);
            _appContext.SaveChanges();
            return historiaAdicionado.Entity;
        }
        IEnumerable <Historia_Clinica>I_Repo_Historia_Clinica.GetAllHistoria()
        {
            return _appContext.Historias_Clinicas;
        }
        void I_Repo_Historia_Clinica.DeleteHistoria(int Id_Historia)
        {
            var historiaEncontrado=_appContext.Historias_Clinicas.FirstOrDefault(p=>p.id==Id_Historia);
           if(historiaEncontrado==null)
           {
                return;
           }
            _appContext.Historias_Clinicas.Remove(historiaEncontrado);
            _appContext.SaveChanges();
                }
        Historia_Clinica I_Repo_Historia_Clinica.UpdateHistoria(Historia_Clinica historia){
            var historiaEncontrado =_appContext.Historias_Clinicas.FirstOrDefault(p=>p.id==historia.id);
            if(historiaEncontrado!=null)
            {
                        historiaEncontrado.Fecha_Visita=historia.Fecha_Visita;
                        historiaEncontrado.Id_Vaca=historia.Id_Vaca;
                        historiaEncontrado.Id_Veterinario=historia.Id_Veterinario;
                        historiaEncontrado.Temperatura=historia.Temperatura;
                        historiaEncontrado.Peso=historia.Peso;
                        historiaEncontrado.Frecuencia_Respiratoria=historia.Frecuencia_Respiratoria;
                        historiaEncontrado.Frecuencia_Cardiaca=historia.Frecuencia_Cardiaca;
                        historiaEncontrado.Estado_Animo=historia.Estado_Animo;
                        historiaEncontrado.Diagnostico=historia.Diagnostico;
                        historiaEncontrado.Recomendaciones=historia.Recomendaciones;
                        historiaEncontrado.Medicamentos=historia.Medicamentos;
                        _appContext.SaveChanges();
                    }
                    return historiaEncontrado;
                }
                Historia_Clinica I_Repo_Historia_Clinica.GetHistoria(int Id_Historia)
                {
                    return _appContext.Historias_Clinicas.FirstOrDefault(p=>p.id==Id_Historia);
                }
            }
        }