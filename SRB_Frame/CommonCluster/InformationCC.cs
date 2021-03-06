﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SRB.Frame.Cluster
{
    public partial class InformationCC : IClusterControl
    {
        InformationCluster cluster;
        public InformationCC(InformationCluster c) : base(c)
        {
            InitializeComponent();
            cluster = c;
            cluster.read();
        }

        protected override void DataUpdata()
        {
            this.typeL.Text = "Type: " + cluster.type;
            this.versionL.Text = 
            string.Format("Version: Node-{0}.{1}  SRB-{2}.{3}  ", cluster.major_version, cluster.minor_version,
            cluster.SRB_major_version,cluster.SRB_minor_version);
        }


        private void ResetNodeBTN_Click(object sender, EventArgs e)
        {
            cluster.resetNode();
        }

        private void factorySettingBTN_Click(object sender, EventArgs e)
        {
            string st = string.Format
                ("Are you sure to reset Node {0} to factory setting?",
                cluster.Parent_node.Addr);
            if (MessageBox.Show(this, st, "Factory Setting", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                cluster.factorySettingNode();
            }
        }
    }
}
