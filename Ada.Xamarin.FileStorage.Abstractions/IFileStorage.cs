namespace Ada.Xamarin.FileStorage.Abstractions
{
    public interface IFileStorage
    {
        string Read(string fileName);

        T Read<T>(string fileName);
    }
}
