using bovino.dominio;
using System.Collections.Generic;

namespace PROGRAMA_BOVINO.persistencia 
{
    public interface I_Repo_Propietario 
    {
        IEnumerable<Aper_propietario>GetAllPropietario();
        Aper_propietario AddPropietario(Aper_propietario propietario);
        Aper_propietario UpdatePropietario(Aper_propietario propietario);
        void DeletePropietario(int Id_Propietario);
        Aper_propietario GetPropietario(int Id_Propietario);

    }
    
    
   
}