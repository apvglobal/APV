﻿using System.Data.Common;

namespace Apv.Implementations.Blockchains.LevelDB
{
    internal class LevelDBException : DbException
    {
        internal LevelDBException(string message)
            : base(message)
        {
        }
    }
}
