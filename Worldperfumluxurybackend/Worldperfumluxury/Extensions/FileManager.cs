using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Worldperfumluxury.Extensions
{
    public static class FileManager
    {

        public static bool CheckContentType(this IFormFile file, string type)
        {
            return file.ContentType.Contains(type);
        }

        public static bool CheckLength(this IFormFile file, double length)
        {
            return (file.Length / 1024) > length;
        }
        public static bool IsImage(this IFormFile photo)
        {
            return photo.ContentType.Contains("image/");
        }
        public async static Task<string> SaveImageAsync(this IFormFile photo, string root, string folder)
        {
            string fileName = Guid.NewGuid().ToString() + photo.FileName;
            string path = Path.Combine(root, folder, fileName);

            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                await photo.CopyToAsync(fileStream);
            }
            return fileName;
        }
    }
}
