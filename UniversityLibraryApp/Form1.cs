using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityLibraryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcImage.Location = new Point((pcImage.Parent.ClientSize.Width - pcImage.ClientSize.Width) / 2,
                (pcImage.Parent.ClientSize.Height - pcImage.ClientSize.Height) / 2
                );
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderBook orderBook = new OrderBook();
            orderBook.ShowDialog();
        }
    }
}
