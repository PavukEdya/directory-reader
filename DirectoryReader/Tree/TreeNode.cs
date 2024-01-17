namespace DirectoryReader.Tree
{
    public class TreeNode
    {
        public TreeNode(string name, int? size = null)
        {
            Name = name;
            Size = size;
            Children = new SortedSet<TreeNode>(new TreeNodeComparer());
        }

        public string Name { get; set; }

        public int? Size { get; set; }

        public SortedSet<TreeNode> Children { get; set; }
    }
}
