namespace LogicCircuitSimulator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label3 = new System.Windows.Forms.Label();
            this.xPos = new System.Windows.Forms.Label();
            this.yPos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopSimulationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutLogCircSimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bClear = new System.Windows.Forms.Button();
            this.bRestart = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bAnd = new System.Windows.Forms.Button();
            this.bNand = new System.Windows.Forms.Button();
            this.bOr = new System.Windows.Forms.Button();
            this.bNor = new System.Windows.Forms.Button();
            this.bXor = new System.Windows.Forms.Button();
            this.bXnor = new System.Windows.Forms.Button();
            this.bBuf = new System.Windows.Forms.Button();
            this.bInv = new System.Windows.Forms.Button();
            this.bInPort = new System.Windows.Forms.Button();
            this.bOutPort = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1408, 769);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mode";
            // 
            // xPos
            // 
            this.xPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xPos.AutoSize = true;
            this.xPos.Location = new System.Drawing.Point(296, 769);
            this.xPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xPos.Name = "xPos";
            this.xPos.Size = new System.Drawing.Size(21, 17);
            this.xPos.TabIndex = 10;
            this.xPos.Text = "X:";
            // 
            // yPos
            // 
            this.yPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yPos.AutoSize = true;
            this.yPos.Location = new System.Drawing.Point(367, 769);
            this.yPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yPos.Name = "yPos";
            this.yPos.Size = new System.Drawing.Size(21, 17);
            this.yPos.TabIndex = 11;
            this.yPos.Text = "Y:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(293, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 702);
            this.panel1.TabIndex = 12;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.saveProjectToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Enabled = false;
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.newProjectToolStripMenuItem.Text = "New Project";
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Enabled = false;
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.openProjectToolStripMenuItem.Text = "Open Project";
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // startSimulationToolStripMenuItem
            // 
            this.startSimulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopSimulationToolStripMenuItem,
            this.stopSimulationToolStripMenuItem1});
            this.startSimulationToolStripMenuItem.Name = "startSimulationToolStripMenuItem";
            this.startSimulationToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.startSimulationToolStripMenuItem.Text = "Circuit";
            // 
            // stopSimulationToolStripMenuItem
            // 
            this.stopSimulationToolStripMenuItem.Name = "stopSimulationToolStripMenuItem";
            this.stopSimulationToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.stopSimulationToolStripMenuItem.Text = "Start Simulation";
            this.stopSimulationToolStripMenuItem.Click += new System.EventHandler(this.stopSimulationToolStripMenuItem_Click);
            // 
            // stopSimulationToolStripMenuItem1
            // 
            this.stopSimulationToolStripMenuItem1.Name = "stopSimulationToolStripMenuItem1";
            this.stopSimulationToolStripMenuItem1.Size = new System.Drawing.Size(190, 26);
            this.stopSimulationToolStripMenuItem1.Text = "Stop Simulation";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullscreenToolStripMenuItem,
            this.toolStripSeparator1,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.originalScaleToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // fullscreenToolStripMenuItem
            // 
            this.fullscreenToolStripMenuItem.Enabled = false;
            this.fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            this.fullscreenToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.fullscreenToolStripMenuItem.Text = "Fullscreen";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            // 
            // originalScaleToolStripMenuItem
            // 
            this.originalScaleToolStripMenuItem.Name = "originalScaleToolStripMenuItem";
            this.originalScaleToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.originalScaleToolStripMenuItem.Text = "Original Scale";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.toolStripSeparator2,
            this.aboutLogCircSimToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Enabled = false;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(204, 26);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // aboutLogCircSimToolStripMenuItem
            // 
            this.aboutLogCircSimToolStripMenuItem.Name = "aboutLogCircSimToolStripMenuItem";
            this.aboutLogCircSimToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.aboutLogCircSimToolStripMenuItem.Text = "About LogCircSim";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.startSimulationToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1507, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bClear
            // 
            this.bClear.Image = global::LogicCircuitSimulator.Properties.Resources.Remove;
            this.bClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClear.Location = new System.Drawing.Point(64, 731);
            this.bClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(141, 50);
            this.bClear.TabIndex = 16;
            this.bClear.Text = "Clear      ";
            this.bClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bRestart
            // 
            this.bRestart.Image = global::LogicCircuitSimulator.Properties.Resources.Restart;
            this.bRestart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRestart.Location = new System.Drawing.Point(64, 235);
            this.bRestart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bRestart.Name = "bRestart";
            this.bRestart.Size = new System.Drawing.Size(141, 50);
            this.bRestart.TabIndex = 15;
            this.bRestart.Text = "Restart   ";
            this.bRestart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bRestart.UseVisualStyleBackColor = true;
            this.bRestart.Click += new System.EventHandler(this.bRestart_Click);
            // 
            // bStop
            // 
            this.bStop.Image = global::LogicCircuitSimulator.Properties.Resources.Stop;
            this.bStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bStop.Location = new System.Drawing.Point(64, 177);
            this.bStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(141, 50);
            this.bStop.TabIndex = 14;
            this.bStop.Text = "          Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bStart
            // 
            this.bStart.Image = ((System.Drawing.Image)(resources.GetObject("bStart.Image")));
            this.bStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bStart.Location = new System.Drawing.Point(64, 119);
            this.bStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(141, 50);
            this.bStart.TabIndex = 13;
            this.bStart.Text = "Get Result";
            this.bStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bNext
            // 
            this.bNext.Image = global::LogicCircuitSimulator.Properties.Resources.Next;
            this.bNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNext.Location = new System.Drawing.Point(64, 62);
            this.bNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(141, 50);
            this.bNext.TabIndex = 18;
            this.bNext.Text = "Next Step";
            this.bNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1,
            this.disconnectToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 76);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(151, 24);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // bAnd
            // 
            this.bAnd.Image = global::LogicCircuitSimulator.Properties.Resources._2AND;
            this.bAnd.Location = new System.Drawing.Point(64, 309);
            this.bAnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAnd.Name = "bAnd";
            this.bAnd.Size = new System.Drawing.Size(67, 49);
            this.bAnd.TabIndex = 20;
            this.bAnd.UseVisualStyleBackColor = true;
            this.bAnd.Click += new System.EventHandler(this.bAnd_Click);
            // 
            // bNand
            // 
            this.bNand.Image = global::LogicCircuitSimulator.Properties.Resources._2NAND;
            this.bNand.Location = new System.Drawing.Point(139, 309);
            this.bNand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bNand.Name = "bNand";
            this.bNand.Size = new System.Drawing.Size(67, 49);
            this.bNand.TabIndex = 21;
            this.bNand.UseVisualStyleBackColor = true;
            this.bNand.Click += new System.EventHandler(this.bNand_Click);
            // 
            // bOr
            // 
            this.bOr.Image = global::LogicCircuitSimulator.Properties.Resources._2OR;
            this.bOr.Location = new System.Drawing.Point(64, 384);
            this.bOr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bOr.Name = "bOr";
            this.bOr.Size = new System.Drawing.Size(67, 49);
            this.bOr.TabIndex = 22;
            this.bOr.UseVisualStyleBackColor = true;
            this.bOr.Click += new System.EventHandler(this.bOr_Click);
            // 
            // bNor
            // 
            this.bNor.Image = global::LogicCircuitSimulator.Properties.Resources._2NOR;
            this.bNor.Location = new System.Drawing.Point(139, 384);
            this.bNor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bNor.Name = "bNor";
            this.bNor.Size = new System.Drawing.Size(67, 49);
            this.bNor.TabIndex = 23;
            this.bNor.UseVisualStyleBackColor = true;
            this.bNor.Click += new System.EventHandler(this.bNor_Click);
            // 
            // bXor
            // 
            this.bXor.Image = global::LogicCircuitSimulator.Properties.Resources._2XOR;
            this.bXor.Location = new System.Drawing.Point(64, 459);
            this.bXor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bXor.Name = "bXor";
            this.bXor.Size = new System.Drawing.Size(67, 49);
            this.bXor.TabIndex = 24;
            this.bXor.UseVisualStyleBackColor = true;
            this.bXor.Click += new System.EventHandler(this.bXor_Click);
            // 
            // bXnor
            // 
            this.bXnor.Image = global::LogicCircuitSimulator.Properties.Resources._2XNOR;
            this.bXnor.Location = new System.Drawing.Point(139, 459);
            this.bXnor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bXnor.Name = "bXnor";
            this.bXnor.Size = new System.Drawing.Size(67, 49);
            this.bXnor.TabIndex = 25;
            this.bXnor.UseVisualStyleBackColor = true;
            this.bXnor.Click += new System.EventHandler(this.bXnor_Click);
            // 
            // bBuf
            // 
            this.bBuf.Image = global::LogicCircuitSimulator.Properties.Resources.BUF;
            this.bBuf.Location = new System.Drawing.Point(64, 540);
            this.bBuf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bBuf.Name = "bBuf";
            this.bBuf.Size = new System.Drawing.Size(67, 49);
            this.bBuf.TabIndex = 26;
            this.bBuf.UseVisualStyleBackColor = true;
            this.bBuf.Click += new System.EventHandler(this.bBuf_Click);
            // 
            // bInv
            // 
            this.bInv.Image = global::LogicCircuitSimulator.Properties.Resources.INV;
            this.bInv.Location = new System.Drawing.Point(139, 540);
            this.bInv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bInv.Name = "bInv";
            this.bInv.Size = new System.Drawing.Size(67, 49);
            this.bInv.TabIndex = 27;
            this.bInv.UseVisualStyleBackColor = true;
            this.bInv.Click += new System.EventHandler(this.bInv_Click);
            // 
            // bInPort
            // 
            this.bInPort.Image = global::LogicCircuitSimulator.Properties.Resources.ITerminal;
            this.bInPort.Location = new System.Drawing.Point(75, 608);
            this.bInPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bInPort.Name = "bInPort";
            this.bInPort.Size = new System.Drawing.Size(45, 27);
            this.bInPort.TabIndex = 28;
            this.bInPort.UseVisualStyleBackColor = true;
            this.bInPort.Click += new System.EventHandler(this.bInPort_Click);
            // 
            // bOutPort
            // 
            this.bOutPort.Image = global::LogicCircuitSimulator.Properties.Resources.OTerminal;
            this.bOutPort.Location = new System.Drawing.Point(148, 608);
            this.bOutPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bOutPort.Name = "bOutPort";
            this.bOutPort.Size = new System.Drawing.Size(45, 27);
            this.bOutPort.TabIndex = 29;
            this.bOutPort.UseVisualStyleBackColor = true;
            this.bOutPort.Click += new System.EventHandler(this.bOutPort_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 655);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 28);
            this.button1.TabIndex = 30;
            this.button1.Text = "Create connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 691);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 28);
            this.button2.TabIndex = 31;
            this.button2.Text = "Simulate input";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 796);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bOutPort);
            this.Controls.Add(this.bInPort);
            this.Controls.Add(this.bInv);
            this.Controls.Add(this.bBuf);
            this.Controls.Add(this.bXnor);
            this.Controls.Add(this.bXor);
            this.Controls.Add(this.bAnd);
            this.Controls.Add(this.bNor);
            this.Controls.Add(this.bOr);
            this.Controls.Add(this.bNand);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bRestart);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.yPos);
            this.Controls.Add(this.xPos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1522, 833);
            this.Name = "MainForm";
            this.Text = "LogCircSim";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label xPos;
        private System.Windows.Forms.Label yPos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bRestart;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startSimulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopSimulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopSimulationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutLogCircSimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Button bAnd;
        private System.Windows.Forms.Button bNand;
        private System.Windows.Forms.Button bOr;
        private System.Windows.Forms.Button bNor;
        private System.Windows.Forms.Button bXor;
        private System.Windows.Forms.Button bXnor;
        private System.Windows.Forms.Button bBuf;
        private System.Windows.Forms.Button bInv;
        private System.Windows.Forms.Button bInPort;
        private System.Windows.Forms.Button bOutPort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

