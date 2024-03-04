using System.Text;

namespace Infrastructure.Repositories
{
    internal class FileIO
    {
        private const string SHIFT_JIS_CODE = "Shift_JIS";

        public bool WriteFile(string saveText, string fileName)
        {
            try
            {
                //ファイルをオープンする
                using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.GetEncoding(SHIFT_JIS_CODE)))
                {
                    sw.Write(saveText);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return true;
        }

        public string ReadFile(string directoryPath, string fileName)
        {
            if (!string.IsNullOrEmpty(directoryPath))
            {
                directoryPath = "./";
            }

            string fullPath = Path.Combine(directoryPath, fileName);

            var text = string.Empty;
            try
            {
                text = File.ReadAllText(fullPath, Encoding.GetEncoding(SHIFT_JIS_CODE));
            }
            catch (Exception)
            {
                throw;
            }

            return text;
        }

        public string ReadFile(string fileName)
        {
            string fullPath = Path.Combine(fileName);

            if (!File.Exists(fullPath))
            {

            }

            var text = string.Empty;
            try
            {
                text = File.ReadAllText(fullPath, Encoding.GetEncoding(SHIFT_JIS_CODE));
            }
            catch (Exception)
            {
                throw;
            }

            return text;
        }
    }
}
