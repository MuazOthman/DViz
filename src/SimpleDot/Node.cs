using System.Collections.Generic;

namespace DViz.SimpleDot
{
    internal class Node
    {
        private readonly List<Node> _children;
        private readonly string _name;
        public int Tag { get; set; } = 0;

        public Node(string name, List<Node> children)
        {
            _name = name;
            _children = children;
        }

        public IReadOnlyList<Node> Children => _children.AsReadOnly();

        public IReadOnlyList<Node> GetSubtree()
        {
            var result = new List<Node> {this};
            var i = 0;
            while (i<result.Count)
            {
                var n = result[i];
                foreach (var child in n.Children)
                {
                    if(!result.Contains(child))
                        result.Add(child);
                }
                i++;
            }
            return result.AsReadOnly();
        }

        // ReSharper disable once ConvertToAutoProperty
        public string Name => _name;

        public override string ToString()
        {
            return $"{Name} => {Children.Count}";
        }
    }

}
