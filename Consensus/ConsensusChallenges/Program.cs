using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsensusChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Proposers p1 = new Proposers(1, true, "");
            Proposers p2 = new Proposers(2, true, "");
            Proposers p3 = new Proposers(3, true, "");
            Acceptor a1 = new Acceptor(101, -1, "");
            Acceptor a2 = new Acceptor(102, -1, "");
            Acceptor a3 = new Acceptor(103, -1, "");
            Acceptor a4 = new Acceptor(104, -1, "");
            Acceptor a5 = new Acceptor(105, -1, "");
        }
    }
}
