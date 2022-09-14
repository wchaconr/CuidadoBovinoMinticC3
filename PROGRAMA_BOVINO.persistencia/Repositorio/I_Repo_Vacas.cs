using bovino.dominio;
using System.Collections.Generic;

namespace PROGRAMA_BOVINO.persistencia 
{
    public interface I_Repo_Vacas 
    {
        IEnumerable<Aper_vaca>GetAllVaca();
        Aper_vaca AddVaca(Aper_vaca vaca);
        Aper_vaca UpdateVaca(Aper_vaca vaca);
        void DeleteVaca(int idVaca);
        Aper_vaca GetVaca(int idVaca);

    }
    
    
   
}