﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SRB.Frame;

namespace SRB.NodeType.Du_motor
{
    class ConfigCluster : ICluster
    {
        public ushort min_pwm_a { get => getBankUshort(0); set => setBankUshort(value, 0); }
        public ushort min_pwm_b { get => getBankUshort(2); set => setBankUshort(value, 2); }
        public ushort  period { get => getBankUshort(4); set => setBankUshort(value, 4);}
        public byte lose_control_ms { get => getBankByte(6); set => setBankByte(value, 6);}
        public byte lose_behavior  { get => getBankByte(7); set => setBankByte(value, 7);}

        public ConfigCluster(BaseNode n)
            : base(n, 10, 8)
        {
        }
        public override System.Windows.Forms.UserControl createControl()
        {
            return new ConfigCC(this);
        }
        public override string ToString()
        {
            return string.Format("Du Motor<ID={0}>", Clustr_ID.ToHexSt());
        }
    }
}
