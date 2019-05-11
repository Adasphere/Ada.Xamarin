namespace Ada.Xamarin.FileStorage.Abstractions
{
    public interface IFileStorage
    {
        string Read(string fileName);

        T Read<T>(string fileName);

        void Write(string fileName, string content);
    }
}
