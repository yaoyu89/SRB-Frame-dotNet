﻿namespace SRB_CTR.SRB_Frame
{
    partial class FrameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.uiTIMER = new System.Windows.Forms.Timer(this.components);
            this.nodesTable = new System.Windows.Forms.FlowLayoutPanel();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.uartTS = new System.Windows.Forms.ToolStrip();
            this.MasterBroadConfigBTN_uc = new System.Windows.Forms.ToolStripButton();
            this.MasterBroadConfigBTN_c = new System.Windows.Forms.ToolStripButton();
            this.ShowAccessBTN = new System.Windows.Forms.ToolStripButton();
            this.left_UpDownSC = new System.Windows.Forms.SplitContainer();
            this.frameCounterFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.mainTSC = new System.Windows.Forms.ToolStripContainer();
            this.nodeScanTS = new System.Windows.Forms.ToolStrip();
            this.ScanNodeBTN = new System.Windows.Forms.ToolStripButton();
            this.runBTN = new System.Windows.Forms.ToolStripButton();
            this.stopBTN = new System.Windows.Forms.ToolStripButton();
            this.stopAddrShowBTN = new System.Windows.Forms.ToolStripButton();
            this.beginAddrShowBTN = new System.Windows.Forms.ToolStripButton();
            this.NodeTipTT = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.uartTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.left_UpDownSC)).BeginInit();
            this.left_UpDownSC.Panel1.SuspendLayout();
            this.left_UpDownSC.Panel2.SuspendLayout();
            this.left_UpDownSC.SuspendLayout();
            this.mainTSC.ContentPanel.SuspendLayout();
            this.mainTSC.TopToolStripPanel.SuspendLayout();
            this.mainTSC.SuspendLayout();
            this.nodeScanTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 579);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(384, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // uiTIMER
            // 
            this.uiTIMER.Enabled = true;
            this.uiTIMER.Interval = 1000;
            this.uiTIMER.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nodesTable
            // 
            this.nodesTable.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.nodesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nodesTable.Location = new System.Drawing.Point(0, 0);
            this.nodesTable.Name = "nodesTable";
            this.nodesTable.Size = new System.Drawing.Size(384, 442);
            this.nodesTable.TabIndex = 0;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            this.LeftToolStripPanel.UseWaitCursor = true;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(551, 557);
            // 
            // uartTS
            // 
            this.uartTS.Dock = System.Windows.Forms.DockStyle.None;
            this.uartTS.ImageScalingSize = new System.Drawing.Size(23, 23);
            this.uartTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MasterBroadConfigBTN_uc,
            this.MasterBroadConfigBTN_c,
            this.ShowAccessBTN});
            this.uartTS.Location = new System.Drawing.Point(3, 0);
            this.uartTS.Name = "uartTS";
            this.uartTS.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.uartTS.Size = new System.Drawing.Size(93, 30);
            this.uartTS.TabIndex = 2;
            this.uartTS.Text = "Bus config";
            // 
            // MasterBroadConfigBTN_uc
            // 
            this.MasterBroadConfigBTN_uc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MasterBroadConfigBTN_uc.Image = ((System.Drawing.Image)(resources.GetObject("MasterBroadConfigBTN_uc.Image")));
            this.MasterBroadConfigBTN_uc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MasterBroadConfigBTN_uc.Name = "MasterBroadConfigBTN_uc";
            this.MasterBroadConfigBTN_uc.Size = new System.Drawing.Size(27, 27);
            this.MasterBroadConfigBTN_uc.Text = "端口配置";
            this.MasterBroadConfigBTN_uc.Click += new System.EventHandler(this.MasterBroadConfigBTN_Click);
            // 
            // MasterBroadConfigBTN_c
            // 
            this.MasterBroadConfigBTN_c.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MasterBroadConfigBTN_c.Image = ((System.Drawing.Image)(resources.GetObject("MasterBroadConfigBTN_c.Image")));
            this.MasterBroadConfigBTN_c.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MasterBroadConfigBTN_c.Name = "MasterBroadConfigBTN_c";
            this.MasterBroadConfigBTN_c.Size = new System.Drawing.Size(27, 27);
            this.MasterBroadConfigBTN_c.Text = "端口配置";
            this.MasterBroadConfigBTN_c.Click += new System.EventHandler(this.MasterBroadConfigBTN_Click);
            // 
            // ShowAccessBTN
            // 
            this.ShowAccessBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ShowAccessBTN.Image = ((System.Drawing.Image)(resources.GetObject("ShowAccessBTN.Image")));
            this.ShowAccessBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowAccessBTN.Name = "ShowAccessBTN";
            this.ShowAccessBTN.Size = new System.Drawing.Size(27, 27);
            this.ShowAccessBTN.Text = "打开监视窗口";
            this.ShowAccessBTN.Click += new System.EventHandler(this.ShowAccessBTN_Click);
            // 
            // left_UpDownSC
            // 
            this.left_UpDownSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left_UpDownSC.Location = new System.Drawing.Point(0, 0);
            this.left_UpDownSC.Name = "left_UpDownSC";
            this.left_UpDownSC.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // left_UpDownSC.Panel1
            // 
            this.left_UpDownSC.Panel1.Controls.Add(this.frameCounterFLP);
            // 
            // left_UpDownSC.Panel2
            // 
            this.left_UpDownSC.Panel2.Controls.Add(this.nodesTable);
            this.left_UpDownSC.Size = new System.Drawing.Size(384, 549);
            this.left_UpDownSC.SplitterDistance = 103;
            this.left_UpDownSC.TabIndex = 0;
            // 
            // frameCounterFLP
            // 
            this.frameCounterFLP.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.frameCounterFLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameCounterFLP.Location = new System.Drawing.Point(0, 0);
            this.frameCounterFLP.Name = "frameCounterFLP";
            this.frameCounterFLP.Size = new System.Drawing.Size(384, 103);
            this.frameCounterFLP.TabIndex = 0;
            // 
            // mainTSC
            // 
            this.mainTSC.BottomToolStripPanelVisible = false;
            // 
            // mainTSC.ContentPanel
            // 
            this.mainTSC.ContentPanel.Controls.Add(this.left_UpDownSC);
            this.mainTSC.ContentPanel.Size = new System.Drawing.Size(384, 549);
            this.mainTSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTSC.LeftToolStripPanelVisible = false;
            this.mainTSC.Location = new System.Drawing.Point(0, 0);
            this.mainTSC.Name = "mainTSC";
            this.mainTSC.RightToolStripPanelVisible = false;
            this.mainTSC.Size = new System.Drawing.Size(384, 579);
            this.mainTSC.TabIndex = 5;
            this.mainTSC.Text = "toolStripContainer1";
            // 
            // mainTSC.TopToolStripPanel
            // 
            this.mainTSC.TopToolStripPanel.Controls.Add(this.uartTS);
            this.mainTSC.TopToolStripPanel.Controls.Add(this.nodeScanTS);
            // 
            // nodeScanTS
            // 
            this.nodeScanTS.Dock = System.Windows.Forms.DockStyle.None;
            this.nodeScanTS.ImageScalingSize = new System.Drawing.Size(23, 23);
            this.nodeScanTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ScanNodeBTN,
            this.runBTN,
            this.stopBTN,
            this.stopAddrShowBTN,
            this.beginAddrShowBTN,
            this.toolStripButton1});
            this.nodeScanTS.Location = new System.Drawing.Point(96, 0);
            this.nodeScanTS.Name = "nodeScanTS";
            this.nodeScanTS.Size = new System.Drawing.Size(205, 30);
            this.nodeScanTS.TabIndex = 4;
            // 
            // ScanNodeBTN
            // 
            this.ScanNodeBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ScanNodeBTN.Image = ((System.Drawing.Image)(resources.GetObject("ScanNodeBTN.Image")));
            this.ScanNodeBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ScanNodeBTN.Name = "ScanNodeBTN";
            this.ScanNodeBTN.Size = new System.Drawing.Size(27, 27);
            this.ScanNodeBTN.Text = "Search Node";
            this.ScanNodeBTN.Click += new System.EventHandler(this.ScanNodeBTN_Click);
            // 
            // runBTN
            // 
            this.runBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runBTN.Image = ((System.Drawing.Image)(resources.GetObject("runBTN.Image")));
            this.runBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runBTN.Name = "runBTN";
            this.runBTN.Size = new System.Drawing.Size(27, 27);
            this.runBTN.Text = "Run";
            this.runBTN.Click += new System.EventHandler(this.runBTN_Click);
            // 
            // stopBTN
            // 
            this.stopBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopBTN.Image = ((System.Drawing.Image)(resources.GetObject("stopBTN.Image")));
            this.stopBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopBTN.Name = "stopBTN";
            this.stopBTN.Size = new System.Drawing.Size(27, 27);
            this.stopBTN.Text = "Stop";
            this.stopBTN.Click += new System.EventHandler(this.stopBTN_Click);
            // 
            // stopAddrShowBTN
            // 
            this.stopAddrShowBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopAddrShowBTN.Image = ((System.Drawing.Image)(resources.GetObject("stopAddrShowBTN.Image")));
            this.stopAddrShowBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopAddrShowBTN.Name = "stopAddrShowBTN";
            this.stopAddrShowBTN.Size = new System.Drawing.Size(27, 27);
            this.stopAddrShowBTN.Text = "Stop Addr Show";
            this.stopAddrShowBTN.Click += new System.EventHandler(this.stopAddrShowBTN_Click);
            // 
            // beginAddrShowBTN
            // 
            this.beginAddrShowBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.beginAddrShowBTN.Image = ((System.Drawing.Image)(resources.GetObject("beginAddrShowBTN.Image")));
            this.beginAddrShowBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.beginAddrShowBTN.Name = "beginAddrShowBTN";
            this.beginAddrShowBTN.Size = new System.Drawing.Size(27, 27);
            this.beginAddrShowBTN.Text = "Begin Addr show";
            this.beginAddrShowBTN.Click += new System.EventHandler(this.beginAddrShowBTN_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(27, 27);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FrameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 601);
            this.Controls.Add(this.mainTSC);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(400, 640);
            this.Name = "FrameForm";
            this.Text = "Simple Robot Bus";
            this.uartTS.ResumeLayout(false);
            this.uartTS.PerformLayout();
            this.left_UpDownSC.Panel1.ResumeLayout(false);
            this.left_UpDownSC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.left_UpDownSC)).EndInit();
            this.left_UpDownSC.ResumeLayout(false);
            this.mainTSC.ContentPanel.ResumeLayout(false);
            this.mainTSC.TopToolStripPanel.ResumeLayout(false);
            this.mainTSC.TopToolStripPanel.PerformLayout();
            this.mainTSC.ResumeLayout(false);
            this.mainTSC.PerformLayout();
            this.nodeScanTS.ResumeLayout(false);
            this.nodeScanTS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer uiTIMER;
        private System.Windows.Forms.FlowLayoutPanel nodesTable;
        private System.Windows.Forms.ToolStrip uartTS;
        private System.Windows.Forms.ToolStripButton MasterBroadConfigBTN_uc;
        private System.Windows.Forms.ToolStripButton MasterBroadConfigBTN_c;
        private System.Windows.Forms.ToolStripButton ShowAccessBTN;
        private System.Windows.Forms.SplitContainer left_UpDownSC;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel topTSP;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripContainer mainTSC;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStrip nodeScanTS;
        private System.Windows.Forms.ToolStripButton ScanNodeBTN;
        private System.Windows.Forms.FlowLayoutPanel frameCounterFLP;
        private System.Windows.Forms.ToolStripButton runBTN;
        private System.Windows.Forms.ToolStripButton stopBTN;
        private System.Windows.Forms.ToolStripButton stopAddrShowBTN;
        private System.Windows.Forms.ToolStripButton beginAddrShowBTN;
        private System.Windows.Forms.ToolTip NodeTipTT;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}