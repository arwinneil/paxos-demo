using System;
using System.Collections.Generic;
using System.Text;

namespace paxos_demo
{
    class Node
    {
        public int? minProposal;
        public int? acceptedProposal;

        public List<string> log;
    }
}
