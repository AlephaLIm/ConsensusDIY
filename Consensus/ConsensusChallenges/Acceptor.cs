using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsensusChallenges
{
    class Acceptor
    {
        private int accepted_ID { get; set; }
        private string accepted_Value { get; set; }

        private int acceptor_ID { get; set; }
        public int Acceptor_ID { get; }

        public Acceptor() { }
        public Acceptor(int id, int aid, string aval)
        {
            acceptor_ID = id;
            accepted_ID = aid;
            accepted_Value = aval;
        }
        public bool propose(int id, string val)
        {
            /*Condition in which the proposal fails
              Hint: a failed proposal does not always mean the proposer is unable to propose A value*/
            return false;
            //Condition in which the proposal succeeds//
            accepted_ID = id;
            accepted_Value = val;
            return true;

        }
    }
}
