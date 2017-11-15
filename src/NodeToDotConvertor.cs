using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DViz.SimpleDot;

namespace DViz
{
    static class NodeToDotConvertor
    {
        public static string Convert(Node root)
        {
            var rules = root.GetSubtree().SelectMany(GetDotLinesFromNode);
            return $"digraph G {{ rankdir=LR; {string.Join(" ", rules)}}}";
        }

        static readonly Dictionary<int, string> _tagRules = new Dictionary<int, string>
        {
            {1,"[style=filled, color=\".7 .3 1.0\"]" }
        };


        private static List<string> GetDotLinesFromNode(Node n)
        {
            var result = n.Children.Select(c => $"\"{n.Name}\" -> \"{c.Name}\";").ToList();
            if (_tagRules.ContainsKey(n.Tag))
            {
                result.Add($"\"{n.Name}\" {_tagRules[n.Tag]};");
            }
            return result;
        }
    }
}
