using System.Collections.Generic;

namespace paxos_demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int proposer_no = 3;
            int acceptor_no = 2;

            List<Acceptor> acceptors = new List<Acceptor>();

            for (int i = 0; i < acceptor_no; i++)
            {
                acceptors.Add(new Acceptor(i));
            }

            List<Proposer> proposers = new List<Proposer>();

            for (int i = 0; i < proposer_no; i++)
            {
                proposers.Add(new Proposer(i, acceptors));
            }
        }
    }
}