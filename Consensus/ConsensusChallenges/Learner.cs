using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsensusChallenges
{
    class Learner
    {
        private int proposer_ID { get; set; }
        public string proposed_value { get; set; }

        public Learner() { }
        public Learner(int id, string val)
        {
            proposer_ID = id;
            proposed_value = val;
        }
        public void announceconsensus()
        {
            Console.WriteLine($"A consensus has been reached.Proposer {proposer_ID} has proposed {proposed_value}!");
        }
    }
}
