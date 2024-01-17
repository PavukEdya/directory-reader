namespace DirectoryReader.Tree
{
    internal class TreeNodeComparer : Comparer<TreeNode>
    {
        public override int Compare(TreeNode? x, TreeNode? y)
        {

            if (x == null && y == null)
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;
            if (x.Size == null && y.Size == null)
            {
                return string.Compare(x.Name, y.Name);
            }
            if (x.Size == null)
            {
                return -1;
            }
            if (y.Size == null)
            {
                return 1;
            }
            if (x.Size != y.Size)
            {
                return y.Size.Value.CompareTo(x.Size.Value);
            }
            return string.Compare(x.Name, y.Name);
        }
    }
}
