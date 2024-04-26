using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        public bool Ascending { get; }

        public CompareByName(bool Ascending)
        {
            this.Ascending = Ascending;
        }

        public int Compare(Player x, Player y)
        {
            if (Ascending)
            {
                if (x == null)
                {
                    return 1;
                }
                return x.Name.CompareTo(y.Name);
            }
            else
            {
                if (y == null)
                {
                    return 1;
                }
                return y.Name.CompareTo(x.Name);
            }
        }
    }
}