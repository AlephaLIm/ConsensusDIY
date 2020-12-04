using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsensusChallenges
{
    class Proposers
    {
        public int Id { get; set; }
        private bool isUp { get; set; }

        private string value { get; set; }

        public bool IsUp { get; }

        public string Value { get; }
        private int votes { get; set; }
        public int Votes { get; }

        public Proposers() { }
        public Proposers(int i, bool status, string val)
        {
            Id = i;
            isUp = status;
            value = val;
            votes = 0;
        }
        public void fail()
        {
            isUp = false;
        }
        public void reboot()
        {
            isUp = true;
        }
        public void Propose(Acceptor a)
        {
            if (!IsUp)
                return;
           bool success = a.propose(Id, Value);
            // action taken after a proposal // 
        }
    }
}
