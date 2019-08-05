using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        void Add(TransferLog transferLog);//added by me

        IEnumerable<TransferLog> GetTransferLogs();
    }
}
