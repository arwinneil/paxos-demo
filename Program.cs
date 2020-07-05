using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace paxos_demo
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            int proposer_no = 3;
            int acceptor_no = 2;

            string[] food = { "Pizza", "Burger", "Noodles" };

            List<Acceptor> acceptors = new List<Acceptor>();

            for (int i = 0; i < acceptor_no; i++)
            {
                acceptors.Add(new Acceptor(i));
            }

            List<Proposer> proposers = new List<Proposer>();

            for (int i = 0; i < proposer_no; i++)
            {
                proposers.Add(new Proposer(i, acceptors, food));
            }

            proposers.ForEach(p => Task.Run( p.StartServer));

            Console.ReadKey();
        }
    }
}