using Ada.Xamarin.FileStorage.Abstractions;
using System.IO;
using Android.App;
using Android.Content;
using Newtonsoft.Json;

namespace Ada.Xamarin.FileStorage.Android
{
    public class FileStorage : IFileStorage
    {
        private readonly Context context;

        public FileStorage()
        {
            this.context = Application.Context;
        }

        public string Read(string fileName)
        {
            string content;

            using (Stream asset = this.context.Assets.Open(fileName))
            {
                using (StreamReader streamReader = new StreamReader(asset))
                {
                    content = streamReader.ReadToEnd();
                }
            }

            return content;
        }

        public T Read<T>(string fileName)
        {
            string content = Read(fileName);
            T data = JsonConvert.DeserializeObject<T>(content);

            return data;
        }
    }
}
