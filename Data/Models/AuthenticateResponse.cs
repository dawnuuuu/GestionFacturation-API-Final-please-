using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionFacturation.Data.Models
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }


        public AuthenticateResponse(Utilisateur user, string token)
        {
            Id = user.Id;
            FirstName = user.Prenom;
            LastName = user.Nom;
            Username = user.UserName;
            Token = token;
        }
    }
}
