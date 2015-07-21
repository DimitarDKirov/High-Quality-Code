using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling
{
    public static class FileUtils
    {
        public static string GetFileExtension(string fileName)
        {
            if (!IsFileNameValid(fileName))
            {
                throw new ArgumentOutOfRangeException("Invalid file name provided");
            }

            int indexOfLastDot = fileName.LastIndexOf(".");
            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            if (!IsFileNameValid(fileName))
            {
                return fileName;
            }

            int indexOfLastDot = fileName.LastIndexOf(".");
            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }

        private static bool IsFileNameValid(string fileName)
        {
            if (fileName == null)
            {
                return false;
            }

            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return false;
            }

            return true;
        }
    }
}
