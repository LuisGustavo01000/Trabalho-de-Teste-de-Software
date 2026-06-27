using System.Security.Cryptography;

namespace BlackBelt.Models
{
    public class CriptografiaSenha
    {
        // Gera um hash seguro com sal
        public static string SenhaHash(string password)
        {
            // Gera um salt aleatório
            byte[] salt = RandomNumberGenerator.GetBytes(16);

            // Gera o hash usando PBKDF2
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(32);

            // Combina salt e hash
            byte[] hashBytes = new byte[48];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 32);

            // Converte para Base64 para armazenar
            return Convert.ToBase64String(hashBytes);
        }

        // Verifica a senha
        public static bool ValidarSenha(string senha, string hashArmazenado)
        {
            byte[] hashBytes = Convert.FromBase64String(hashArmazenado);

            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            var pbkdf2 = new Rfc2898DeriveBytes(senha, salt, 10000, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(32);

            for (int i = 0; i < 32; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                    return false;
            }

            return true;
        }
    }
}
