﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SRB_CTR.SRB_Frame;

namespace SRB_CTR.nsBrain.Node_dMotor.Cluster_du_motor_adj
{
    partial class Ctrl : UserControl
    {
        private const string No_adjust = "NoAdjust";
        Clu cluster;
        public Ctrl(Clu c)
        {
            InitializeComponent();
            cluster = c;
            c.eDataChanged += new EventHandler(c_dataChanged);
            cluster.read();
        }
        public string adjToName(int adj)
        {
            switch (adj)
            {
                case 1:
                    return "255";
                case 2:
                    return "1000";
                case 3:
                    return "10000";
                default:
                    return "NoAdjust";
            }
        }        
        public int nameToAdj(string st)
        {
            switch (st)
            {
                case No_adjust:
                    return 0;
                case "255":
                    return 1;
                case "1000":
                    return 2;
                case "10000":
                    return 3;
                default:
                    throw (new Exception("不存在的调整值"));
            }
        }

        void c_dataChanged(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                EventHandler d = new EventHandler(c_dataChanged);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.AdjCB.Text = adjToName(cluster.adj);
                motorATogCBOX.CheckState = cluster.motor_a_tog ? CheckState.Checked : CheckState.Unchecked;
                motorBTogCBOX.CheckState = cluster.motor_b_tog ? CheckState.Checked : CheckState.Unchecked;
            }
        }

        private void write(object sender, EventArgs e)
        {
            cluster.writeBankinit();
            cluster.adj = (byte)nameToAdj(AdjCB.Text);
            cluster.motor_a_tog = motorATogCBOX.Checked;
            cluster.motor_b_tog = motorBTogCBOX.Checked;
            cluster.write();
        }
        private void read(object sender, EventArgs e)
        {
            cluster.read();
        }

    }
}
