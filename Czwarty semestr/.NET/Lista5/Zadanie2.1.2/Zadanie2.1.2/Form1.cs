using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie2._1._2
{
    
    public partial class Form1 : Form
    {
        const string DUMMYNODE = "__dummyNode!!!";
        public Form1()
        {
            InitializeComponent();

            #region ListView

            this.listView1.Clear();
            this.listView1.Columns.Clear();

            this.listView1.Columns.Add("Nazwisko", 80);
            this.listView1.Columns.Add("Imie", -2);


            Person[] people =
                {
                new Person() {name = "Jan", surname = "Kowalski", ID = 1},
                new Person() {name = "Adam", surname = "Adamski", ID = 2},
                new Person() {name = "Piotr", surname = "Nowak", ID = 3},
                };

            foreach(var person in people)
            {
                ListViewItem li = this.listView1.Items.Add(person.surname);
                li.SubItems.Add(person.name);
            }

            #endregion ListView

            for(int i=0; i<10; i++)
            {
                var item = this.treeView1.Nodes.Add(i.ToString());
                item.Nodes.Add(DUMMYNODE);
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if(e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == DUMMYNODE)
            {
                e.Node.Nodes.Clear();
                for (int i = 0; i < 10; i++)
                {
                    var item = e.Node.Nodes.Add(i.ToString());
                    item.Nodes.Add(DUMMYNODE);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }


    }
    public class Person
    {
        public string name;
        public string surname;
        public int ID;
    }
}
