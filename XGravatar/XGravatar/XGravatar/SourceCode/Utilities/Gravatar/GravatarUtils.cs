using System.Text;

namespace XGravatar.SourceCode.Utilities.Gravatar
{
    public class GravatarUtils
    {
        public static string GetGravatar(string email)
        {

            return string.Format($"http://www.gravatar.com/avatar/{HashEmailForGravatar(email)}?s=200");
        }
        private static string HashEmailForGravatar(string email)
        {
            // Convert the input string to a byte array and compute the hash.  
            var data = Md5Core.GetHash(email);

            // Create a new Stringbuilder to collect the bytes  
            // and create a string.  
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data  
            // and format each one as a hexadecimal string.  

            foreach (var t in data)
            {
                sBuilder.Append(t.ToString("x2"));
            }

            return sBuilder.ToString();  // Return the hexadecimal string. 
        }
    }
}
