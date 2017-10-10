using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public string Mensagem { get; set; }

        public void OnGet()
        {
            Mensagem = $"Ol�, agora s�o {DateTime.Now.ToString("t")}. Seja bem-vindo(a)!";
        }

        public void OnPost()
        {
            Mensagem = $"Voc� clicou no bot�o �s {DateTime.Now.ToString("t")}. Volte sempre!";
        }
    }
}