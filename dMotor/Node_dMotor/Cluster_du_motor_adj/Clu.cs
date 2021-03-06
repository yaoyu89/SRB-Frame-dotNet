﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SRB_CTR.SRB_Frame;

namespace SRB_CTR.nsBrain.Node_dMotor.Cluster_du_motor_adj
{
    class Clu:Cluster
    {
        public byte adj { get => getBankByte(0); set => setBankByte(value, 0); }
        public bool motor_a_tog { get => getBankBool(1); set => setBankBool(value, 1); }	
	   public bool motor_b_tog { get => getBankBool(2); set => setBankBool(value, 2); }

        public Clu(byte ID, Node n)
            : base(ID, n,3) { }
        public override System.Windows.Forms.UserControl createControl()
        {
            return new Ctrl(this);
        }
        public override string ToString()
        {
            return string.Format("Adjest<ID={0}>", Clustr_ID.ToHexSt());
        }
    }
}
