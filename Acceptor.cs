using System;
using System.Collections.Generic;
using System.Text;

namespace paxos_demo
{
    class Acceptor : Node
    {

        public Acceptor(int _nodeId)
            : base(_nodeId)
        {
            Logger.Log_new_acceptor(nodeId);
        }
    }
}
