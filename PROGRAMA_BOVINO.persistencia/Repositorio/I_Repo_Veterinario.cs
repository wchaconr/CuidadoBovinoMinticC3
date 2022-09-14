using bovino.dominio;
using System.Collections.Generic;

namespace PROGRAMA_BOVINO.persistencia 
{
    public interface I_Repo_Veterinario 
    {
        IEnumerable<Aper_veterinario>GetAllVeterinario();
        Aper_veterinario AddVeterinario(Aper_veterinario veterinario);
        Aper_veterinario UpdateVeterinario(Aper_veterinario veterinario);
        void DeleteVeterinario(int Id_Veterinario);
        Aper_veterinario GetVeterinario(int Id_Veterinario);

    }
    
    
   
}