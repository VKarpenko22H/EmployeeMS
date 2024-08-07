using System.Security.Cryptography;
using System.Text;
using Service.Models;

namespace Service
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            var byted = Encoding.UTF8.GetBytes(password);
            var sha1 = SHA1.Create();
            var hashedBytes = sha1.ComputeHash(byted);
            return Encoding.UTF8.GetString(hashedBytes);
        }

        public static bool IsCorrectPassword(UserModel user, string password)
        {
            var passwordHash = HashPassword(password);
            return passwordHash == user.PasswordHash;
        }
    }
}
