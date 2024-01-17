namespace DirectoryReader
{
    internal static class Program
    {
        static void Main()
        {
            var app = new Application(
                "Путь до файла чтения",
                "Путь до файла записи"
                );
            app.Run();
        }
    }
}
