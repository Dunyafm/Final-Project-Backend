using System.IO;

namespace Worldperfumluxury.Helpers
{
    public class Helper
    {
        public static bool DeleteImage(string root, string folder, string fileName)
        {
            string path = Path.Combine(root, folder, fileName);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
                return true;
            }
            return false;
        }
    }
}
