using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neo4jClient;

namespace neo4j_ubl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)


        {
            if(txtUsername.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Credential Not Empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else
            {
                try
                {
                    GraphClient client = new GraphClient(new Uri("http://localhost:7474/db/data"), txtUsername.Text, txtPass.Text);
                    client.Connect();
                    lblConnected.Text = "Database Connected";
                    lblConnected.ForeColor = Color.Green;
                }
                catch
                {
                    lblConnected.Text = "Database Failed";
                    lblConnected.ForeColor = Color.Red;
                }
            }
            
        }

        
    }
}
