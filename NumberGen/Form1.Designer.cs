
namespace NumberGen
{
    partial class Form1
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
            this.tbStart = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.tbLimit = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblCreator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbStart
            // 
            this.tbStart.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbStart.Location = new System.Drawing.Point(132, 23);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(150, 24);
            this.tbStart.TabIndex = 0;
            this.tbStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStart_KeyPress);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblStart.Location = new System.Drawing.Point(35, 26);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(91, 17);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start Number";
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblLimit.Location = new System.Drawing.Point(35, 64);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(85, 17);
            this.lblLimit.TabIndex = 3;
            this.lblLimit.Text = "End Number";
            // 
            // tbLimit
            // 
            this.tbLimit.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbLimit.Location = new System.Drawing.Point(132, 61);
            this.tbLimit.Name = "tbLimit";
            this.tbLimit.Size = new System.Drawing.Size(150, 24);
            this.tbLimit.TabIndex = 2;
            this.tbLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLimit_KeyPress);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnGenerate.Location = new System.Drawing.Point(22, 97);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(277, 33);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(22, 136);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(277, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.ForeColor = System.Drawing.Color.Silver;
            this.lblCreator.Location = new System.Drawing.Point(213, 164);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(86, 13);
            this.lblCreator.TabIndex = 6;
            this.lblCreator.Text = "created by: djmj";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 186);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.tbLimit);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.tbStart);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Generator (Liquid)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.TextBox tbLimit;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblCreator;
    }
}

