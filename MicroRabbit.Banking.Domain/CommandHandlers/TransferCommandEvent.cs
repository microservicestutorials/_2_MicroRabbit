namespace MicroRabbit.Banking.Domain.CommandHandlers
{
    internal class TransferCommandEvent
    {
        private int from;
        private int to;
        private decimal amount;

        public TransferCommandEvent(int from, int to, decimal amount)
        {
            this.from = from;
            this.to = to;
            this.amount = amount;
        }
    }
}