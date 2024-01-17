namespace DirectoryReader
{
    internal class FileManager
    {
        private bool CorrectLine(string line)
        {
            return line != "";
        }

        internal IEnumerable<string> GetLinesFromFile(string filePath)
        {
            return File.ReadAllLines(filePath).Where(l => CorrectLine(l));
        }

        internal void WriteLinesInFile(string filePath, IEnumerable<string> lines)
        {
            File.WriteAllLines(filePath, lines);
        }
    }
}
