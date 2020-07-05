using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace paxos_demo
{
    internal class Proposer : Node

    {
        public List<Acceptor> acceptors;
        public string[] proposals;

        public Proposer(int _nodeId, List<Acceptor> _acceptors, string[] _proposals)
            : base(_nodeId)
        {
            acceptors = new List<Acceptor>(_acceptors);
            proposals = _proposals;

            Logger.Log_new_proposer(nodeId, acceptors.Count);
        }

        // Indefinitely picks a random value from proposals and broadcasts a prepare
        // request to all acceptors at a random interval
        public async Task StartServer()
        {
            Random rnd = new Random();

            while (true)
            {
                Task.Delay(rnd.Next(3000)).Wait();

                string proposal = proposals[rnd.Next(0, 3)];

                if (minProposal is null)
                {
                    minProposal = 0;
                }
                else
                {
                    minProposal++;
                }

                Logger.Proposer_picked_value(nodeId, proposal, minProposal);

                acceptors.ForEach(a => a.Prepare(minProposal));
            }
        }
    }
}