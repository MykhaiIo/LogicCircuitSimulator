namespace LogicCircuitSimulator
{
    partial class CreateGateDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateGateDialog));
            this.nInputCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bCreateGate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nInputCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // nInputCount
            // 
            this.nInputCount.Location = new System.Drawing.Point(122, 55);
            this.nInputCount.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nInputCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nInputCount.Name = "nInputCount";
            this.nInputCount.Size = new System.Drawing.Size(71, 20);
            this.nInputCount.TabIndex = 0;
            this.nInputCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nInputCount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(122, 102);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input pins count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output pins count:";
            // 
            // bCreateGate
            // 
            this.bCreateGate.Location = new System.Drawing.Point(58, 152);
            this.bCreateGate.Name = "bCreateGate";
            this.bCreateGate.Size = new System.Drawing.Size(75, 23);
            this.bCreateGate.TabIndex = 4;
            this.bCreateGate.Text = "Create";
            this.bCreateGate.UseVisualStyleBackColor = true;
            // 
            // CreateGateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 191);
            this.Controls.Add(this.bCreateGate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.nInputCount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(230, 230);
            this.MinimumSize = new System.Drawing.Size(230, 230);
            this.Name = "CreateGateDialog";
            this.Text = "CreateGate";
            ((System.ComponentModel.ISupportInitialize)(this.nInputCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nInputCount;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCreateGate;
    }
}