using System;

namespace Apv.Wallets
{
    [Flags]
    internal enum AddressState : byte
    {
        None = 0,

        InWallet = 1 << 0,
        WatchOnly = 1 << 1
    }
}
