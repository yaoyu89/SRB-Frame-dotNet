﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SRB.Frame;

namespace SRB.NodeType.Charger
{
    partial class BatteryCC : IClusterControl
    {
        BatteryCluster cluster;
        public BatteryCC(BatteryCluster c) : base(c)
        {
            InitializeComponent();
            cluster = c;
            cluster.read();
        }


        protected override void DataUpdata()
        {
            LEDCB.CheckState = cluster.power_on_led_enable ? CheckState.Checked : CheckState.Unchecked;
            ChargeEnableCB.CheckState = cluster.power_on_enable_charge ? CheckState.Checked : CheckState.Unchecked;
            MuteCB.CheckState = cluster.power_on_mute ? CheckState.Checked : CheckState.Unchecked;
            CurrentNUM.Value = (decimal)((cluster.Max_charge_current)/1000.0);
            LowVotNUM.Value = (decimal)((cluster.Low_voltage)/1000.0);
            CapacityNUM.Value = (decimal)(cluster.Capacity_mAh);
            InnResNUM.Value = (decimal)(cluster.inn_res_mOhm);            
        }

        protected override void WriteData()
        {
            cluster.writeBankinit();
            cluster.power_on_led_enable = LEDCB.Checked;
            cluster.power_on_enable_charge = ChargeEnableCB.Checked;
            cluster.power_on_mute = MuteCB.Checked;
            cluster.Max_charge_current = (int)(CurrentNUM.Value*1000);
            cluster.Low_voltage = (int)(LowVotNUM.Value*1000);
            cluster.Capacity_mAh = (int)(CapacityNUM.Value);
            cluster.inn_res_mOhm = (int)(InnResNUM.Value);
            cluster.write();
        }

        private void BatteryCC_Load(object sender, EventArgs e)
        {

        }

        private void lowVotNUM_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
