using System.Text.RegularExpressions;

namespace ValidadorApi.Services
{
    public class ValidadorService
    {
        public bool ValidarCpf(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return false;

            string cpfRe = cpf.Replace(".", "").Replace("-", "");

            if (cpfRe.Length == 11)
                return true;
            
            else
                return false;
        }

        public bool ValidarIp(string ip)
        {
            if (string.IsNullOrWhiteSpace(ip))
                return false;
        
            string[] partes = ip.Split(".");

            if (partes.Length != 4)
                return false;

            foreach(string parte in partes)
            {
                if (!int.TryParse(parte, out int numero) || numero < 0 || numero > 255)
                    return false;

                if (parte.Length > 1 && parte.StartsWith("0"))
                    return false;
            }
            return true;
        }

        public bool ValidarSenha(string senha)
        {
            if (string.IsNullOrWhiteSpace(senha))
                return false;

            bool temNumero = false;
            bool temEspecial = false;

            foreach (char c in senha)
            {
                if (char.IsDigit(c))
                    temNumero = true;
                if (!char.IsLetterOrDigit(c))
                    temEspecial = true;
            }
            if (senha.Length >= 9 && temNumero && temEspecial)
                return true;
            return false;
        }
    }
}