using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cuidadobovinominticc3.Pages
{
    public class aper_vacasModel : PageModel
    {
        
        private string [] TiposOpciones={"Elemento de lista1", "elemento de lista2", "elemento de lista3", "elemento de lista 4"};
        
        public List<string> ListaOpciones{get;set;}
        public void OnGet()
        {
            ListaOpciones= new List<string>();
            ListaOpciones.AddRange(TiposOpciones);
        }
    }
}
