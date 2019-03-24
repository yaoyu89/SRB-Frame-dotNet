﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRB.Frame
{
    public abstract class ISRB_Master
    {
        public Node[] Nodes;
        public abstract void nodeAddrChange(Node node);
        public abstract void nodeDescriptionChange(Node node);
        public abstract void nodeReplace(Node n, Node node);
        public abstract void nodeRegister(Node node);
        public abstract void nodeUnregister(Node node);

        public abstract void addAccess(Access ac);
        public abstract void singleAccess(Access ac);
        public abstract void sendAccess();
        public virtual bool isNewAddrAvaliable(byte addr)
        {
            if (Nodes[addr] != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
