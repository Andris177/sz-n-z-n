namespace szinozon
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
            this.numericUpDownSzinszam = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonJatekInditasa = new System.Windows.Forms.Button();
            this.textBoxFeladvany1 = new System.Windows.Forms.TextBox();
            this.textBoxFeladvany2 = new System.Windows.Forms.TextBox();
            this.textBoxFeladvany3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxTipp1 = new System.Windows.Forms.TextBox();
            this.textBoxTipp2 = new System.Windows.Forms.TextBox();
            this.textBoxTipp3 = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanelSzinek = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelValasztottSzinek = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxKivalasztottSzin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSzinszam)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKivalasztottSzin)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownSzinszam
            // 
            this.numericUpDownSzinszam.Location = new System.Drawing.Point(147, 89);
            this.numericUpDownSzinszam.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownSzinszam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSzinszam.Name = "numericUpDownSzinszam";
            this.numericUpDownSzinszam.Size = new System.Drawing.Size(31, 20);
            this.numericUpDownSzinszam.TabIndex = 1;
            this.numericUpDownSzinszam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elemek száma: 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Használható színek száma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Választható színek:";
            // 
            // buttonJatekInditasa
            // 
            this.buttonJatekInditasa.Location = new System.Drawing.Point(53, 326);
            this.buttonJatekInditasa.Name = "buttonJatekInditasa";
            this.buttonJatekInditasa.Size = new System.Drawing.Size(150, 50);
            this.buttonJatekInditasa.TabIndex = 8;
            this.buttonJatekInditasa.Text = "Új játék indítása";
            this.buttonJatekInditasa.UseVisualStyleBackColor = true;
            // 
            // textBoxFeladvany1
            // 
            this.textBoxFeladvany1.Location = new System.Drawing.Point(13, 3);
            this.textBoxFeladvany1.Name = "textBoxFeladvany1";
            this.textBoxFeladvany1.Size = new System.Drawing.Size(100, 20);
            this.textBoxFeladvany1.TabIndex = 10;
            // 
            // textBoxFeladvany2
            // 
            this.textBoxFeladvany2.Location = new System.Drawing.Point(119, 3);
            this.textBoxFeladvany2.Name = "textBoxFeladvany2";
            this.textBoxFeladvany2.Size = new System.Drawing.Size(100, 20);
            this.textBoxFeladvany2.TabIndex = 11;
            // 
            // textBoxFeladvany3
            // 
            this.textBoxFeladvany3.Location = new System.Drawing.Point(225, 3);
            this.textBoxFeladvany3.Name = "textBoxFeladvany3";
            this.textBoxFeladvany3.Size = new System.Drawing.Size(100, 20);
            this.textBoxFeladvany3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Feladvány";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxFeladvany1);
            this.panel2.Controls.Add(this.textBoxFeladvany2);
            this.panel2.Controls.Add(this.textBoxFeladvany3);
            this.panel2.Location = new System.Drawing.Point(328, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 31);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxTipp1);
            this.panel3.Controls.Add(this.textBoxTipp2);
            this.panel3.Controls.Add(this.textBoxTipp3);
            this.panel3.Location = new System.Drawing.Point(331, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 34);
            this.panel3.TabIndex = 15;
            // 
            // textBoxTipp1
            // 
            this.textBoxTipp1.Location = new System.Drawing.Point(13, 3);
            this.textBoxTipp1.Name = "textBoxTipp1";
            this.textBoxTipp1.Size = new System.Drawing.Size(100, 20);
            this.textBoxTipp1.TabIndex = 2;
            // 
            // textBoxTipp2
            // 
            this.textBoxTipp2.Location = new System.Drawing.Point(119, 3);
            this.textBoxTipp2.Name = "textBoxTipp2";
            this.textBoxTipp2.Size = new System.Drawing.Size(100, 20);
            this.textBoxTipp2.TabIndex = 1;
            // 
            // textBoxTipp3
            // 
            this.textBoxTipp3.Location = new System.Drawing.Point(225, 3);
            this.textBoxTipp3.Name = "textBoxTipp3";
            this.textBoxTipp3.Size = new System.Drawing.Size(100, 20);
            this.textBoxTipp3.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(671, 111);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(48, 34);
            this.buttonOK.TabIndex = 16;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Eddigi tippek:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tipp:";
            // 
            // flowLayoutPanelSzinek
            // 
            this.flowLayoutPanelSzinek.Location = new System.Drawing.Point(16, 148);
            this.flowLayoutPanelSzinek.Name = "flowLayoutPanelSzinek";
            this.flowLayoutPanelSzinek.Size = new System.Drawing.Size(235, 172);
            this.flowLayoutPanelSzinek.TabIndex = 20;
            // 
            // flowLayoutPanelValasztottSzinek
            // 
            this.flowLayoutPanelValasztottSzinek.Location = new System.Drawing.Point(725, 98);
            this.flowLayoutPanelValasztottSzinek.Name = "flowLayoutPanelValasztottSzinek";
            this.flowLayoutPanelValasztottSzinek.Size = new System.Drawing.Size(79, 722);
            this.flowLayoutPanelValasztottSzinek.TabIndex = 21;
            // 
            // pictureBoxKivalasztottSzin
            // 
            this.pictureBoxKivalasztottSzin.Location = new System.Drawing.Point(704, 28);
            this.pictureBoxKivalasztottSzin.Name = "pictureBoxKivalasztottSzin";
            this.pictureBoxKivalasztottSzin.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxKivalasztottSzin.TabIndex = 22;
            this.pictureBoxKivalasztottSzin.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 843);
            this.Controls.Add(this.pictureBoxKivalasztottSzin);
            this.Controls.Add(this.flowLayoutPanelValasztottSzinek);
            this.Controls.Add(this.flowLayoutPanelSzinek);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonJatekInditasa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownSzinszam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSzinszam)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKivalasztottSzin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownSzinszam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonJatekInditasa;
        private System.Windows.Forms.TextBox textBoxFeladvany1;
        private System.Windows.Forms.TextBox textBoxFeladvany2;
        private System.Windows.Forms.TextBox textBoxFeladvany3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxTipp1;
        private System.Windows.Forms.TextBox textBoxTipp2;
        private System.Windows.Forms.TextBox textBoxTipp3;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSzinek;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelValasztottSzinek;
        private System.Windows.Forms.PictureBox pictureBoxKivalasztottSzin;
    }
}

