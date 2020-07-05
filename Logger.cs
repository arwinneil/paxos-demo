using System;

namespace paxos_demo
{
    public static class Logger
    {
        public static void Log_new_acceptor(int id)
        {
            Console.WriteLine($"New Accptor #{id} up");
        }

        public static void Log_new_proposer(int id, int acceptor_no)
        {
            Console.WriteLine($"New Proposer #{id} up, connected to {acceptor_no} Acceptors");
        }

        public static void Proposer_picked_value(int id, string value)
        {
            Console.WriteLine($"New Proposer #{id} up picked value {value}");
        }
    }
}