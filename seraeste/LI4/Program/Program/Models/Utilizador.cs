using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Threading;
namespace Program.Models
{
    public class Utilizador
    {
        public int Username { get; set; }
        public string Nome { get; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public List<int> Pilotosfav { get; set; }
        public List<int> Construtorfav { get; set; }

        public Utilizador() { }

        public Utilizador(int username, string nome, string pass, string email)
        {
            Username = username;
            Nome = nome;
            Pass = pass;
            Email = email;
            Pilotosfav = new List<int>();
            Construtorfav = new List<int>();
        }
    }

    public class CreateModel
    {
        [Required]    
        [Display(Name = "Username")]  
        public string Username { get; set; }

            
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Pass")]
        public string Pass { get; set; }
            
        [Required]  
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
    public class LogInModel
    {
        [Required]
        [Display(Name = "Nome")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}

