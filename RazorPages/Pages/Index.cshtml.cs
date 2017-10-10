using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public string Mensagem { get; set; }

        public void OnGet()
        {
            Mensagem = $"Olá, agora são {DateTime.Now.ToString("t")}. Seja bem-vindo(a)!";
        }

        public void OnPost()
        {
            Mensagem = $"Você clicou no botão às {DateTime.Now.ToString("t")}. Volte sempre!";
        }
    }
}