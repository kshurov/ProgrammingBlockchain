using NBitcoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBlockchain.Chapters
{
    class Chapter2
    {
        BlockrTransactionRepository blockr = new BlockrTransactionRepository();
        int i = 1;
        public void Lesson1(uint256 hash = null)
        {            
            Transaction transaction = blockr.Get(hash);
            Console.WriteLine("Transaction {0}", i++);
            Console.WriteLine(transaction.ToString());
            if (!transaction.IsCoinBase)
            {
                Lesson1(transaction.Inputs.First().PrevOut.Hash);
            }
        }



        public void Lesson2(Script scriptPubKey)
        {        
            BitcoinAddress address = scriptPubKey.GetDestinationAddress(Network.Main);
            Console.WriteLine("Bitcoin Address: {0}", address);
        }

        public void Lesson3(Script scriptPubKey)
        {            
            KeyId hash = (KeyId)scriptPubKey.GetDestination();
            Console.WriteLine("Public Key Hash: {0}", hash);
            BitcoinAddress address = new BitcoinPubKeyAddress(hash, Network.Main);
            Console.WriteLine("Bitcoin Address: {0}", address);
        }

        public void Lesson4()
        {
            Key key = new Key();
            BitcoinSecret secret = key.GetBitcoinSecret(Network.Main);
            Console.WriteLine("Bitcoin Secret: {0}", secret);
        }

    }
}
