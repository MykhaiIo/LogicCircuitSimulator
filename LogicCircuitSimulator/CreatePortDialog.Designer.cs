namespace LogicCircuitSimulator
{
    partial class CreatePortDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePortDialog));
            this.bCreatePort = new System.Windows.Forms.Button();
            this.cbDirection = new System.Windows.Forms.ComboBox();
            this.cbValue = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bCreatePort
            // 
            this.bCreatePort.Location = new System.Drawing.Point(64, 156);
            this.bCreatePort.Name = "bCreatePort";
            this.bCreatePort.Size = new System.Drawing.Size(75, 23);
            this.bCreatePort.TabIndex = 9;
            this.bCreatePort.Text = "Create";
            this.bCreatePort.UseVisualStyleBackColor = true;
            // 
            // cbDirection
            // 
            this.cbDirection.FormattingEnabled = true;
            this.cbDirection.Location = new System.Drawing.Point(41, 12);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(121, 21);
            this.cbDirection.TabIndex = 10;
            this.cbDirection.Text = "Direction";
            // 
            // cbValue
            // 
            this.cbValue.FormattingEnabled = true;
            this.cbValue.Location = new System.Drawing.Point(41, 59);
            this.cbValue.Name = "cbValue";
            this.cbValue.Size = new System.Drawing.Size(121, 21);
            this.cbValue.TabIndex = 11;
            this.cbValue.Text = "Value";
            // 
            // CreatePortDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 191);
            this.Controls.Add(this.cbValue);
            this.Controls.Add(this.cbDirection);
            this.Controls.Add(this.bCreatePort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(230, 230);
            this.Name = "CreatePortDialog";
            this.Text = "CreatePort";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCreatePort;
        private System.Windows.Forms.ComboBox cbDirection;
        private System.Windows.Forms.ComboBox cbValue;
    }
}