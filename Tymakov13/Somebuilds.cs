using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov13
{
    internal class Somebuilds
    {
        private Builder[] builds = new Builder[10];
        public Builder[] Builds
        {
            get
            {
                return builds;
            }
        }
        public Builder this[int index]
        {
            get
            {
                return builds[index];
            }
        }
        public void AddBuild(Builder build)
        {
            builds[build.IdBuilding] = build;
        }
    }
}
