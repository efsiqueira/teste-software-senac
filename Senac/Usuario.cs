using System;

namespace Senac
{
    public class Usuario
    {
        public string Login(string pEmail, string pSenha)
        {
            if(string.IsNullOrEmpty(pEmail) || string.IsNullOrEmpty(pSenha))
            {
                return "Preencha todos os dados!";
            }
            else if(pEmail.Equals("eduardo.siqueira1@alunos.sc.senac.br") && pSenha.Equals("123456"))
            {
                return "Usuário logado.";
            }
            else
            {
                return "E-mail ou senha incorretos.";
            }
        }

        public bool VerificarNome(string pNome)
        {
            if(String.IsNullOrEmpty(pNome))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
