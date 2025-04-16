namespace BitcoiniKalkulaatorArtjomSkatškov
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bitcoinamountinput = new System.Windows.Forms.TextBox();
            this.currencyselector = new System.Windows.Forms.ComboBox();
            this.tulemuslabel = new System.Windows.Forms.Label();
            this.resultlabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mitu bitcoini konverteerida tahad?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vali valuuta millesse konverteerida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Konverteeri";
            // 
            // bitcoinamountinput
            // 
            this.bitcoinamountinput.Location = new System.Drawing.Point(38, 62);
            this.bitcoinamountinput.Name = "bitcoinamountinput";
            this.bitcoinamountinput.Size = new System.Drawing.Size(100, 20);
            this.bitcoinamountinput.TabIndex = 4;
            // 
            // currencyselector
            // 
            this.currencyselector.FormattingEnabled = true;
            this.currencyselector.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP",
            "EEK"});
            this.currencyselector.Location = new System.Drawing.Point(38, 101);
            this.currencyselector.Name = "currencyselector";
            this.currencyselector.Size = new System.Drawing.Size(121, 21);
            this.currencyselector.TabIndex = 5;
            this.currencyselector.Text = "Vali valuuta";
            this.currencyselector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tulemuslabel
            // 
            this.tulemuslabel.AutoSize = true;
            this.tulemuslabel.Location = new System.Drawing.Point(35, 349);
            this.tulemuslabel.Name = "tulemuslabel";
            this.tulemuslabel.Size = new System.Drawing.Size(50, 13);
            this.tulemuslabel.TabIndex = 6;
            this.tulemuslabel.Text = "Tulemus:";
            this.tulemuslabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // resultlabel
            // 
            this.resultlabel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.resultlabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.resultlabel.Location = new System.Drawing.Point(38, 365);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(651, 37);
            this.resultlabel.TabIndex = 7;
            this.resultlabel.Text = "Konverteerimist pole toimunud";
            this.resultlabel.Visible = false;
            this.resultlabel.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BitcoiniKalkulaatorArtjomSkatškov.Properties.Resources._1_19;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.resultlabel);
            this.Controls.Add(this.tulemuslabel);
            this.Controls.Add(this.currencyselector);
            this.Controls.Add(this.bitcoinamountinput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bitcoinamountinput;
        private System.Windows.Forms.ComboBox currencyselector;
        private System.Windows.Forms.Label tulemuslabel;
        private System.Windows.Forms.TextBox resultlabel;
    }
}

