using System.Collections.Generic;

namespace paxos_demo
{
    internal class Node
    {
        public int nodeId;

        public int? minProposal;
        public int? acceptedProposal;

        public List<string> log;

        public Node(int _nodeId)
        {
            nodeId = _nodeId;
        }
    }
}