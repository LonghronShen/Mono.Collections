using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections
{

    internal sealed class CollectionDebuggerView
    {
        readonly ICollection c;

        public CollectionDebuggerView(ICollection col)
        {
            this.c = col;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public object[] Items
        {
            get
            {
                var o = new object[c.Count];
                c.CopyTo(o, 0);
                return o;
            }
        }

    }

}
