using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Poderia estar em uma pasta DTO também. Já que ele modela uma resposta de uma requisição, mas também é utilizada somente no transporte de dados.
namespace PAM_Study.Models
{
    //Classe que representa a resposta de uma requisição de autenticação.
    public class JwtResponse
    {
        public string Token { get; set; }
        public string Username { get; set; }
        public DateTime Expiration { get; set; }
    }
}
