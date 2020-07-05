using System.Collections.Generic;

namespace paxos_demo
{
    internal class Proposer : Node

    {
        public List<Acceptor> acceptors;

        public Proposer(List<Acceptor> _acceptors)
        {
            acceptors = new List<Acceptor>(_acceptors);
        }
    }
}