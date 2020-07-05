namespace paxos_demo
{
    internal class Acceptor : Node
    {
        private static string accepted_value;
        private static int accepted_proposal;

        public Acceptor(int _nodeId)
            : base(_nodeId)
        {
            Logger.Log_new_acceptor(nodeId);
        }

        public (int, string) Prepare(int? prepare_id)
        {
            Logger.Acceptor_recieved_prepare(nodeId, prepare_id);

            if (prepare_id < minProposal)
            {
                Logger.Acceptor_prepare_too_low(nodeId, prepare_id);
            }
            else
            {
                minProposal = prepare_id;
            }

            return (accepted_proposal, accepted_value);
        }
    }
}