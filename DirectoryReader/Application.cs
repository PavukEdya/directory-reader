using DirectoryReader.Tree;

namespace DirectoryReader
{
    internal class Application
    {
        private TreeBuilder _treeBuilder = new TreeBuilder();

        private TreeSerializer _serializer = new TreeSerializer();

        private FileManager _fileManager = new FileManager();

        private string _inputPath;

        private string _outputPath;

        internal Application(string inputPath, string outputPath)
        {
            _inputPath = inputPath;
            _outputPath = outputPath;
        }

        internal void Run()
        {
            try
            {
                var paths = _fileManager.GetLinesFromFile(_inputPath);
                var treeRoot = _treeBuilder.Build(paths);
                var treeText = _serializer.Serialize(treeRoot);
                _fileManager.WriteLinesInFile(_outputPath, treeText);
            }
            catch (Exception ex){
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
