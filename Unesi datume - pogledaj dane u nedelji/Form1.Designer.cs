namespace Unesi_datume___pogledaj_dane_u_nedelji
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboxUnos = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gboxProvera = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.gboxUnos.SuspendLayout();
            this.gboxProvera.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxUnos
            // 
            this.gboxUnos.Controls.Add(this.listBox1);
            this.gboxUnos.Controls.Add(this.btnDodaj);
            this.gboxUnos.Controls.Add(this.dateTimePicker1);
            this.gboxUnos.Location = new System.Drawing.Point(26, 33);
            this.gboxUnos.Name = "gboxUnos";
            this.gboxUnos.Size = new System.Drawing.Size(486, 657);
            this.gboxUnos.TabIndex = 0;
            this.gboxUnos.TabStop = false;
            this.gboxUnos.Text = "Unos";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(129, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 544);
            this.listBox1.TabIndex = 5;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(243, 31);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(127, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // gboxProvera
            // 
            this.gboxProvera.Controls.Add(this.richTextBox1);
            this.gboxProvera.Controls.Add(this.listBox2);
            this.gboxProvera.Location = new System.Drawing.Point(529, 42);
            this.gboxProvera.Name = "gboxProvera";
            this.gboxProvera.Size = new System.Drawing.Size(614, 648);
            this.gboxProvera.TabIndex = 1;
            this.gboxProvera.TabStop = false;
            this.gboxProvera.Text = "Provera";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(292, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(299, 606);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(16, 22);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(229, 604);
            this.listBox2.TabIndex = 2;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 702);
            this.Controls.Add(this.gboxProvera);
            this.Controls.Add(this.gboxUnos);
            this.Name = "Form1";
            this.Text = "Unesi dane, proveri dane u nedelji";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxUnos.ResumeLayout(false);
            this.gboxProvera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gboxUnos;
        private ListBox listBox1;
        private Button btnDodaj;
        private DateTimePicker dateTimePicker1;
        private GroupBox gboxProvera;
        private RichTextBox richTextBox1;
        private ListBox listBox2;
    }
}