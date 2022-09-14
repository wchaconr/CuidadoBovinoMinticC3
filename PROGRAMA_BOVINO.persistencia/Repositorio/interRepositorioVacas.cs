using bovino.dominio;
using System.Collections.Generic;

namespace PROGRAMA_BOVINO.persistencia {
    public interface interRepositorioVacas {
        IEnumerable<Aper_vaca> GetAllVaca();
        Aper_vaca AddVaca(Aper_vaca vaca);
        Aper_vaca UpdateVaca(Aper_vaca vaca);
        void DeleteVaca(int idVaca);
        Aper_vaca GetVaca(int idVaca);

    }
    public interface interPropietario {
        IEnumerable<Aper_propietario> GetAllPropietario();
        Aper_propietario AddPropietario(Aper_propietario propietario);
        Aper_propietario UpdatePropietario(Aper_propietario propietario);
        void DeletePropietario(int IdPropietario);
        Aper_propietario GetPropietario(int IdPropietario);

    }
    
    public interface interVeterinario {
        IEnumerable<Aper_veterinario> GetAllVeterinario();
        Aper_veterinario AddVeterinario(Aper_veterinario veterinario);
        Aper_veterinario UpdateVeterinario(Aper_veterinario veterinario);
        void DeleteVeterinario(int IdVeterinario);
        Aper_veterinario GetVeterinario(int IdVeterinario);

    }
    public interface interHistoriaClinica {
        IEnumerable<Historia_Clinica> GetAllHistoriaClinica();
        Historia_Clinica AddHistoriaClinica(Historia_Clinica historia_Clinica);
        Historia_Clinica UpdateHistoriaClinica(Historia_Clinica historia_Clinica);
        void DeleteHistoriaClinica(int IdHistoriaClinica);
        Historia_Clinica GetHistoria_Clinica(int IdHistoriaClinica);

    }
}