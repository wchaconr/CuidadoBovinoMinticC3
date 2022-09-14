using bovino.dominio;
using System.Collections.Generic;

namespace PROGRAMA_BOVINO.persistencia 
{
    public interface I_Repo_Historia_Clinica 
    {
        IEnumerable<Historia_Clinica>GetAllHistoria();
        Historia_Clinica AddHistoria(Historia_Clinica historia);
        Historia_Clinica UpdateHistoria(Historia_Clinica historia);
        void DeleteHistoria(int Id_Historia);
        Historia_Clinica GetHistoria(int Id_Historia);

    }
    
    
   
}