namespace WinFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nazwa = new System.Windows.Forms.TextBox();
            this.but_ok2 = new System.Windows.Forms.Button();
            this.but_anuluj2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa: ";
            // 
            // textBox_nazwa
            // 
            this.textBox_nazwa.Location = new System.Drawing.Point(97, 6);
            this.textBox_nazwa.Name = "textBox_nazwa";
            this.textBox_nazwa.Size = new System.Drawing.Size(126, 23);
            this.textBox_nazwa.TabIndex = 1;
            // 
            // but_ok2
            // 
            this.but_ok2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.but_ok2.Location = new System.Drawing.Point(43, 43);
            this.but_ok2.Name = "but_ok2";
            this.but_ok2.Size = new System.Drawing.Size(75, 23);
            this.but_ok2.TabIndex = 2;
            this.but_ok2.Text = "Ok";
            this.but_ok2.UseVisualStyleBackColor = true;
            this.but_ok2.Click += new System.EventHandler(this.but_ok2_Click);
            // 
            // but_anuluj2
            // 
            this.but_anuluj2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_anuluj2.Location = new System.Drawing.Point(148, 43);
            this.but_anuluj2.Name = "but_anuluj2";
            this.but_anuluj2.Size = new System.Drawing.Size(75, 23);
            this.but_anuluj2.TabIndex = 3;
            this.but_anuluj2.Text = "Anuluj ";
            this.but_anuluj2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.but_ok2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.but_anuluj2;
            this.ClientSize = new System.Drawing.Size(253, 77);
            this.Controls.Add(this.but_anuluj2);
            this.Controls.Add(this.but_ok2);
            this.Controls.Add(this.textBox_nazwa);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Hierarchia_organizacyjna";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_nazwa;
        private Button but_ok2;
        private Button but_anuluj2;
    }
}