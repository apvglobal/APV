using System;
using CoreTransaction = Apv.Core.Transaction;

namespace Apv.Implementations.Wallets.EntityFramework
{
    public class TransactionInfo
    {
        public CoreTransaction Transaction;
        public uint? Height;
        public DateTime Time;
    }
}
