using System.Collections.Generic;

namespace paxos_demo
{
    internal class Proposer : Node

    {
        public List<Acceptor> acceptors;

        public Proposer(int _nodeId, List<Acceptor> _acceptors)
            : base(_nodeId)
        {
            acceptors = new List<Acceptor>(_acceptors);

            Logger.Log_new_proposer(nodeId, acceptors.Count);

        }
    }
}