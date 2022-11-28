using System.Drawing.Printing;
using System.Security.Cryptography;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OdczytZPliku();
        }

        private void dodajGaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            dialog.Text = "Dodawanie ga��zi";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.Nodes.Add(dialog.nazwa);
            }
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            dialog.Text = "Dodawanie podga��zi";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.SelectedNode.Nodes.Add(dialog.nazwa);
            }
        }

        private void zmie�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            dialog.Text = "Modyfikowanie ga��zi";
            dialog.nazwa = treeView1.SelectedNode.Text;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.SelectedNode.Text = dialog.nazwa;
            }
        }

        private void usu�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void but_zamknij_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Zapisa� zmiany przed zakmni�ciem? ", "Zamykanie", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                ZapisDoPliku();
                Application.Exit();
            }
            else if (res == DialogResult.No)
            {
                Application.Exit();
            }
        }

        public class myNode
        {

            public string rodzic;
            public string nazwa;
             
            public myNode(string rodzic, string nazwa)
            {
                this.rodzic = rodzic;
                this.nazwa = nazwa; 
            }
        }
        public string n;
        private void DodajDoListy(TreeNode node, ref List<myNode> lista)
        {
            if(node == null) return;
            string r; 
            if (node.Parent == null)
            {
                r = "Brak!";
            }
            else
            {
                r = node.Parent.Text;
                n = node.Text;
            }

            lista.Add(new myNode(r, n)); 
            if (node.NextNode != null)
            {
                DodajDoListy(node.NextNode, ref lista);
            }

            if (node.GetNodeCount(true) > 0)
            {
                DodajDoListy(node.FirstNode, ref lista);
            }
        }

        private void ZapisDoPliku()
        {
            List<myNode> lista = new List<myNode>();
            DodajDoListy(treeView1.Nodes[0], ref lista);
            if (lista.Count == 0)
            {
                return;
            }
            string text = "";
            foreach(myNode elem in lista) 
            {
                text += elem.nazwa + " " + elem.rodzic + "\n";
            }

            File.WriteAllText("firma.txt",text);
        }
 private TreeNode ZnajdzRodzica(TreeNode node, string rodzic)
        {
            TreeNode wynik = null;
            if (node == null)
                return null;
            if (node.Text == rodzic)
                return node;

            if (node.NextNode != null)
                wynik = ZnajdzRodzica(node.NextNode, rodzic);
            if (node.GetNodeCount(true) > 0)
                wynik = ZnajdzRodzica(node.FirstNode, rodzic);

            return wynik;
        }
        private void OdczytZPliku()
        {
            treeView1.Nodes.Clear();
            List<myNode> lista = new List<myNode>();
           
            string[] tab = File.ReadAllLines("firma.txt");
            foreach (string elem in tab)
            {
                string[] pom = elem.Split(' ');
                lista.Add(new myNode(pom[1], pom[0]));
            }

            foreach(myNode node in lista) 
            {
                if (node.rodzic == "Brak")
                {
                    treeView1.Nodes.Add(new TreeNode(node.nazwa));
                }
                else
                {
                    TreeNode rodzic = ZnajdzRodzica(node.rodzic); 
                    if(rodzic != null) 
                    {
                        rodzic.Nodes.Add(node.nazwa);
                    }
                }
            }
        }

        private TreeNode ZnajdzRodzica(string rodzic)
        {
            
            return null;
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            ZapisDoPliku();
            Application.Exit();
         
        }

        private void odczyt_Click(object sender, EventArgs e)
        {
            OdczytZPliku();
        }
    }
}