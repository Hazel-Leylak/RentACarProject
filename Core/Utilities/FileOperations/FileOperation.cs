
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.FileOperations
{
    public class FileOperation
    {

        public static string Add(IFormFile file, string path)
        {
            var sourcePath = Path.GetTempFileName();

            if (file.Length > 0)
                using (var fileStream = new FileStream(sourcePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                }

            File.Move(sourcePath, path);
            string fileName = path.Substring(path.LastIndexOf("\\") + 1);
            return fileName;
        }



        public static IResult Delete(string sourcePath)
        {
            try
            {
                File.Delete(sourcePath);
            }
            catch (Exception exception)
            {
                return new ErrorResult(exception.Message);
            }
            return new SuccessResult();
        }

        public static string Update(string oldPath, IFormFile file, string newPath)
        {
            if (oldPath.Length > 0)
            {
                using(var fileStream = new FileStream(newPath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                }
            }
            string path = Environment.CurrentDirectory + @"\Uploads\CarImages\";
            File.Delete(path + oldPath);
            string fileName = newPath.Substring(newPath.LastIndexOf("\\") + 1);
            return fileName;
        }
    }
}
