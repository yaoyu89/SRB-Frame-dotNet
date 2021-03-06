﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRB.Frame
{
    public abstract class ISRB_Master
    {
        public BaseNode[] Nodes;
        public abstract void nodeAddrChange(BaseNode node);
        public abstract void nodeDescriptionChange(BaseNode node);
        public abstract void nodeReplace(BaseNode n, BaseNode node);
        public abstract void nodeRegister(BaseNode node);
        public abstract void nodeUnregister(BaseNode node);

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
