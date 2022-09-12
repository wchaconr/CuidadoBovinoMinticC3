using bovino.dominio;
using System.Collections.Generic;
using System.Linq;

namespace PROGRAMA_BOVINO.persistencia
{
    public class repositorioVeterinario : interRepositorioVacas
    {

        private readonly appContext _appContext;
        public repositorioVeterinario(appContext appContext1)
        {
            _appContext = appContext1;
        }

        Aper_veterinario interRepositorioVacas.AddVeterinario(Aper_veterinario veterinario)
        {
            var addedVeterinario = _appContext.Aper_veterinario.Add(veterinario);
            _appContext.SaveChanges();
            return addedVeterinario.Entity;

        }
        IEnumerable<Aper_veterinario> interRepositorioVacas.GetAllVeterinarios()
        {
            return _appContext.Aper_veterinario;
        }
        void interRepositorioVacas.DeleteVeterinario(int idVeterinario)
        {
            var foundVeterinario = _appContext.Aper_veterinario.FirstOrDefault(p => p.id == idVeterinario);
            if (foundVeterinario == null)
            {
                return;
            }
            _appContext.Aper_veterinario.Remove(foundVeterinario);
            _appContext.SaveChanges();
        }
        Aper_veterinario interRepositorioVacas.UpdateVeterinario(Aper_veterinario newVeterinario)
        {
            var foundVeterinario = _appContext.Aper_veterinario.FirstOrDefault(p => p.id == newVeterinario.id);
            if (foundVeterinario != null)
            {
                foundVeterinario.Id_Veterinario = newVeterinario.Id_Veterinario;
                foundVeterinario.Tarjeta_Profesional = newVeterinario.Tarjeta_Profesional;
                foundVeterinario.Nombre = newVeterinario.Nombre;
                foundVeterinario.Identificacion = newVeterinario.Identificacion;
                foundVeterinario.Apellido = newVeterinario.Apellido;
                foundVeterinario.Direccion = newVeterinario.Direccion;
                foundVeterinario.Telefono = newVeterinario.Telefono;
                foundVeterinario.E_mail = newVeterinario.E_mail;
                foundVeterinario.Genero = newVeterinario.Genero;
                _appContext.SaveChanges();
            }
            return foundVeterinario;
        }
        Aper_veterinario interRepositorioVacas.GetVeterinario(int idVeterinario)
        {
            return _appContext.Aper_veterinario.FirstOrDefault(p => p.id == idVeterinario);
        }
    }
}