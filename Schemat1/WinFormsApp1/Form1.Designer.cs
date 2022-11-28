namespace WinFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.but_ok = new System.Windows.Forms.Button();
            this.but_zamknij = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajGaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.odczyt = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(433, 300);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(75, 23);
            this.but_ok.TabIndex = 0;
            this.but_ok.Text = "Ok";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // but_zamknij
            // 
            this.but_zamknij.Location = new System.Drawing.Point(433, 377);
            this.but_zamknij.Name = "but_zamknij";
            this.but_zamknij.Size = new System.Drawing.Size(75, 23);
            this.but_zamknij.TabIndex = 1;
            this.but_zamknij.Text = "Zamknij";
            this.but_zamknij.UseVisualStyleBackColor = true;
            this.but_zamknij.Click += new System.EventHandler(this.but_zamknij_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajGaToolStripMenuItem,
            this.dodajToolStripMenuItem,
            this.usuńToolStripMenuItem,
            this.zmieńToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 92);
            // 
            // dodajGaToolStripMenuItem
            // 
            this.dodajGaToolStripMenuItem.Name = "dodajGaToolStripMenuItem";
            this.dodajGaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dodajGaToolStripMenuItem.Text = "Dodaj gałąź";
            this.dodajGaToolStripMenuItem.Click += new System.EventHandler(this.dodajGaToolStripMenuItem_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj podgałąź";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // zmieńToolStripMenuItem
            // 
            this.zmieńToolStripMenuItem.Name = "zmieńToolStripMenuItem";
            this.zmieńToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.zmieńToolStripMenuItem.Text = "Zmień";
            this.zmieńToolStripMenuItem.Click += new System.EventHandler(this.zmieńToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.FullRowSelect = true;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(392, 426);
            this.treeView1.TabIndex = 3;
            // 
            // odczyt
            // 
            this.odczyt.Location = new System.Drawing.Point(433, 339);
            this.odczyt.Name = "odczyt";
            this.odczyt.Size = new System.Drawing.Size(75, 23);
            this.odczyt.TabIndex = 4;
            this.odczyt.Text = "odczyt";
            this.odczyt.UseVisualStyleBackColor = true;
            this.odczyt.Click += new System.EventHandler(this.odczyt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.odczyt);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.but_zamknij);
            this.Controls.Add(this.but_ok);
            this.Name = "Form1";
            this.Text = "Schemat organizacyjny ";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button but_ok;
        private Button but_zamknij;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem dodajGaToolStripMenuItem;
        private ToolStripMenuItem dodajToolStripMenuItem;
        private ToolStripMenuItem usuńToolStripMenuItem;
        private ToolStripMenuItem zmieńToolStripMenuItem;
        private TreeView treeView1;
        private Button odczyt;
    }
}