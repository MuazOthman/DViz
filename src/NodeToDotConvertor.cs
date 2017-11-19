using System.Collections.Generic;
using System.Linq;
using DViz.SimpleDot;

namespace DViz
{
    internal static class NodeToDotConvertor
    {
        public static string Convert(Node root)
        {
            var rules = root.GetSubtree().SelectMany(GetDotLinesFromNode);
            return $"digraph G {{ {string.Join(" ", rules)}}}";
        }

        private static readonly Dictionary<int, string> TagRules = new Dictionary<int, string>
        {
            {1,"[style=filled, color=\"red\"]" }
        };


        private static List<string> GetDotLinesFromNode(Node n)
        {
            var result = n.Children.Select(c => $"\"{n.Name}\" -> \"{c.Name}\";").ToList();
            if (TagRules.ContainsKey(n.Tag))
            {
                result.Add($"\"{n.Name}\" {TagRules[n.Tag]};");
            }
            return result;
        }
    }
}
