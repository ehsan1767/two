using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonVoteMachine
{
    public abstract class RegisterVote
    {
        public abstract int TotalVotes { get; }

        public abstract void RegisterVotee();

    }
}
