using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Star_Path_Finding_Implementation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            Node n11 = new Node(1, 1);
            Node n21 = new Node(2, 1);
            Node n31 = new Node(3, 1);
            Node n12 = new Node( 1,2 );
            Node n22 = new Node(2 ,2 );
            Node n32 = new Node(3 ,2 );
            Node n13 = new Node(1 ,3 );
            Node n23 = new Node(2 ,3 );
            Node n33 = new Node(3 ,3 );
            Node n41 = new Node( 4,1 );
            Node n42= new Node(4,2 );
            Node n43 = new Node( 4, 3);
            Node n51 = new Node(5 ,1 );
            Node n52 = new Node( 5, 2);
            Node n53 = new Node( 5, 3);

       

            n11.Neighbors.Add(n21);

            n21.Neighbors.Add(n11);
            n21.Neighbors.Add(n22);
            n21.Neighbors.Add(n31);

            n22.Neighbors.Add(n21);
            n22.Neighbors.Add(n23);

            n23.Neighbors.Add(n22);


            n31.Neighbors.Add(n21);
            n31.Neighbors.Add(n41);

            n41.Neighbors.Add(n31);
            n41.Neighbors.Add(n42);
            n41.Neighbors.Add(n51);

            n51.Neighbors.Add(n41);

            n42.Neighbors.Add(n41);
            n42.Neighbors.Add(n43);

            n43.Neighbors.Add(n42);
            n43.Neighbors.Add(n53);

            n53.Neighbors.Add(n43);


            AStar astar = new AStar();
            List<Node> path = astar.Search(n11, n53);
           

        }

        
    }
}
