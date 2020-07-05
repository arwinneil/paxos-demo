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

        public static void Proposer_picked_value(int id, string value, int? prepare_id)
        {
            Console.WriteLine($"Proposer #{id} up picked value {value} \t[Prepare ID : {prepare_id}]");
        }

        public static void Acceptor_recieved_prepare(int id, int? prepare_id)
        {
            Console.WriteLine($"Accptor #{id} recieved Prepare ID {prepare_id}");
        }

        public static void Acceptor_prepare_too_low(int id, int? prepare_id)
        {
            Console.WriteLine($"Accptor #{id} declined Prepare ID {prepare_id}");
        }
    }
}