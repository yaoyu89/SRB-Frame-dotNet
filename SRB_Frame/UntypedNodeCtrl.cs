﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SRB.Frame;
namespace SRB.Frame{
    public partial class UntypedNodeCtrl : UserControl
    {
        BaseNode node;  
        public UntypedNodeCtrl(BaseNode n)
        {
            node = n;
            InitializeComponent();
            nameL.Text = "Type = \"" +n.NodeType +"\"";
            node.eDataAccessRecv += Node_eDataAccessRecv;
        }

        private void Node_eDataAccessRecv(object sender, BaseNode.AccessEventArgs e)
        {
            recvRTB.Text = e.ac.Recv_data.ToArrayString();
            e.Handled = true;
        }

        private void nameL_Click(object sender, EventArgs e)
        {
            

        }

        private void AccessOnce(object sender, EventArgs e)
        {
            string error;
            byte[] ba = sendRTB.Text.ToByteAsCArroy(out error);
            sendRTB.Text = ba.ToArrayString();  
            node.singleAccess(new Access(node, Access.PortEnum.D0, ba));
        }

        private void accessTimerOnBTN_Click(object sender, EventArgs e)
        {
            if(AccessT.Enabled==true)
            {
                AccessT.Enabled = false;
                accessTimerOnBTN.Text = "Run Access/100ms";
            }
            else
            {
                AccessT.Enabled = true;
                accessTimerOnBTN.Text = "Stop Access";
            }
        }
    }
}
