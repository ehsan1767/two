using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonVoteMachine
{
    public class VoteMachine : RegisterVote
    {
            private static readonly VoteMachine _instance = new VoteMachine();
            private int _totalVotes = 0;

            static VoteMachine()
            {}
            private VoteMachine()
            {}
            public static VoteMachine Instance
            {
                get
                {
                    return _instance;
                }
            }

        public override void RegisterVotee()
        {
            _totalVotes += 1;
            Console.WriteLine("Registered Vote #" + _totalVotes);
        }

        public override int TotalVotes
        {
            get
            {
                return _totalVotes;
            }
        }
    }
}
