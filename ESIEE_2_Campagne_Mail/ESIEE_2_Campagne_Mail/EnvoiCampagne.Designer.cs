namespace ESIEE_2_Campagne_Mail
{
    partial class EnvoiCampagne
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
            System.Windows.Forms.Label label1;
            this.Send_campaign = new System.Windows.Forms.Button();
            this.sendingTest = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Send_campaign
            // 
            this.Send_campaign.Location = new System.Drawing.Point(324, 221);
            this.Send_campaign.Name = "Send_campaign";
            this.Send_campaign.Size = new System.Drawing.Size(156, 57);
            this.Send_campaign.TabIndex = 0;
            this.Send_campaign.Text = "Send_campaign";
            this.Send_campaign.UseVisualStyleBackColor = true;
            this.Send_campaign.Click += new System.EventHandler(this.button1_Click);
            // 
            // sendingTest
            // 
            this.sendingTest.Location = new System.Drawing.Point(573, 159);
            this.sendingTest.Name = "sendingTest";
            this.sendingTest.Size = new System.Drawing.Size(75, 23);
            this.sendingTest.TabIndex = 1;
            this.sendingTest.Text = "Sending test";
            this.sendingTest.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(171, 163);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 15);
            label1.TabIndex = 3;
            label1.Text = "Sending test";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EnvoiCampagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sendingTest);
            this.Controls.Add(this.Send_campaign);
            this.Name = "EnvoiCampagne";
            this.Text = "EnvoiCampagne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Send_campaign;
        private Button sendingTest;
        private TextBox textBox1;
        private Label label1;
    }
}