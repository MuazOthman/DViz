using System;
using System.Collections.Generic;
using System.Linq;

namespace DViz.SimpleDot
{
    internal class Parser
    {

        private string _startNodeName;
        /// <summary>
        /// Syntax:
        /// - Every line is for an edge: node1 -> node2
        /// - First node to appear is the root
        /// - no styling or attributes are allowed
        /// </summary>
        /// <param name="simpleDot"></param>
        /// <returns></returns>
        public SimpleDotGraph Parse(string simpleDot)
        {
            var lines = simpleDot.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            ParserNode rootParserNode = new ParserNode(_startNodeName);
            var parserNodesLookup = new Dictionary<string, ParserNode>
            {
                {_startNodeName,  rootParserNode}
            };

            var nodeHasParentLookup = new Dictionary<string, bool>
            {
                {_startNodeName, true }
            };

            var lineNumber = 1;
            foreach (var line in lines)
            {
                var parts = line.Split(new[] { "->", "=>" }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 2)
                {
                    throw new Exception($"Cannot parse line {lineNumber}: '{line}'");
                }

                var fromNodeName = parts[0].Trim();
                var toNodeName = parts[1].Trim();
                if (!parserNodesLookup.ContainsKey(fromNodeName))
                {
                    parserNodesLookup.Add(fromNodeName, new ParserNode(fromNodeName));
                }
                if (!parserNodesLookup.ContainsKey(toNodeName))
                {
                    parserNodesLookup.Add(toNodeName, new ParserNode(toNodeName));
                }

                var fromParserNode = parserNodesLookup[fromNodeName];
                var toParserNode = parserNodesLookup[toNodeName];
                fromParserNode.Children.Add(toParserNode);
                if(!nodeHasParentLookup.ContainsKey(toNodeName))
                    nodeHasParentLookup.Add(toNodeName, true);
                lineNumber++;
            }
            foreach (var nodeName in parserNodesLookup.Keys)
            {
                if(!nodeHasParentLookup.ContainsKey(nodeName))
                    rootParserNode.Children.Add(parserNodesLookup[nodeName]);
            }
            _nodesLookup = new Dictionary<string, Node>();
            var root = ConvertToNode(rootParserNode);
            return new SimpleDotGraph(root, _nodesLookup);
        }

        private Dictionary<string, Node> _nodesLookup;

        public Parser(string startNodeName)
        {
            _startNodeName = startNodeName;
        }

        private Node ConvertToNode(ParserNode n)
        {
            if (_nodesLookup.ContainsKey(n.Name))
                return _nodesLookup[n.Name];
            var childs = n.Children.Select(ConvertToNode).ToList();
            var result = new Node(n.Name, childs);
            _nodesLookup.Add(n.Name,result);
            return result;
        }

        private class ParserNode
        {
            public ParserNode(string name)
            {
                Name = name;
                Children = new List<ParserNode>();
            }

            public string Name { get; }
            public List<ParserNode> Children { get; }
        }
    }

    internal class SimpleDotGraph
    {
        public SimpleDotGraph(Node root, IReadOnlyDictionary<string, Node> allNodes)
        {
            Root = root;
            AllNodes = allNodes;
        }

        public IReadOnlyDictionary<string, Node> AllNodes { get; }
        public Node Root { get; }
    }
}
