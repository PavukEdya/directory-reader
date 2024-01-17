namespace DirectoryReader.Tree
{
    public class TreeBuilder
    {        
        private void AddFolderInTree(TreeNode root, string fullPath, int? size)
        {
            var folders = fullPath.Split("\\");
            var currentNode = root;
            for(int i = 0; i < folders.Length - 1; i++)
            {
                var folderName = folders[i];
                var nextNode = currentNode.Children.FirstOrDefault(c=>c.Name == folderName);
                if(nextNode == null) {
                    nextNode = new TreeNode(folderName);
                    currentNode.Children.Add(nextNode);
                }
                currentNode = nextNode;
            }
            currentNode.Children.Add(new TreeNode(folders.Last(),size));
        }

        private (string, int?) GetDataFromPath(string path)
        {
            var data = path.Split();
            var fullPath = data[0];
            int? size = null;
            if (data.Length == 2)
            {
                size = int.Parse(data[1]);
            }
            return (fullPath, size);
        }

        public TreeNode Build(IEnumerable<string> paths)
        {
            var root = new TreeNode("");
            
            foreach(var path in paths)
            {
                var data = GetDataFromPath(path);
                var fullPath = data.Item1;
                var size = data.Item2;
                AddFolderInTree(root, fullPath,size);
            }
            return root;
        }

    }
}
