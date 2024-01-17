namespace DirectoryReader.Tree
{
    public class TreeSerializer
    {
        public IEnumerable<string> Serialize(TreeNode root)
        {
            return PrintNode(root,-1);
        }

        private List<string> PrintNode(TreeNode node,int indentLevel) {
            var result = new List<string>();
            if(!IsRoot(node))
            {
                var nodeStr = new string(' ', indentLevel) + node.Name;
                result.Add(nodeStr);
            }
            foreach(var child in node.Children)
            {
                var childStr = PrintNode(child, indentLevel + 1);
                foreach(var str in childStr)
                {
                    result.Add(str);
                } 
            }
            return result;
        }

        private bool IsRoot(TreeNode node)
        {
            return node.Name == "";
        }
    }
}
