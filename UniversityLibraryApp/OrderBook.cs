using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityLibraryApp.Models;

namespace UniversityLibraryApp
{
    public partial class OrderBook : Form
    {
        UniLibraryDbEntities _context = new UniLibraryDbEntities();
        Book selectedBook;
        Reader_to_Book selectedName;
        public OrderBook()
        {
            InitializeComponent();
        }
        private void FillBookDataGridView()
        {
            dtgOrderBook.DataSource = _context.Reader_to_Book.Select(b => new
            {
                b.Id,
                b.Reader.Fullname,
                b.Book.Book_Name,
                b.Get_Book,
                b.Deadline

            }).ToList();
            dtgOrderBook.Columns[0].Visible = false;
        }
        private void FillBooksComboBox()
        {
            cmbBookName.Items.AddRange(_context.Books.Select(a => a.Book_Name).ToArray());

        }
        private void ClearAllField()
        {
            txtFullname.Text = string.Empty;
            dtGetBook.Value = DateTime.Now;
            dtDeadline.Value = DateTime.Now;
            cmbBookName.Items.Clear();
        }
        private void OrderBook_Load(object sender, EventArgs e)
        {
            FillBooksComboBox();
            FillBookDataGridView();
        }
        private void FillField()
        {
            ClearAllField();
            FillBooksComboBox();
            FillBookDataGridView();
        }
        private void buttonVisible(string text)
        {
            if (text == "add")
            {
                btnSelect.Visible = false;
                btnEdit.Visible = true;
                btnCancel.Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                btnSelect.Visible = true;
                btnEdit.Visible = false;
                btnCancel.Visible = false;
                btnDelete.Visible = false;
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string bookName = cmbBookName.Text;
            string fullName = txtFullname.Text;
            DateTime getDate = dtGetBook.Value;
            DateTime deadLine = dtDeadline.Value;
            Reader_to_Book reader_To_Book = new Reader_to_Book();
            if (!string.IsNullOrWhiteSpace(bookName) && !string.IsNullOrWhiteSpace(fullName))
            {
                lblError.Visible = false;
                reader_To_Book.BookId = _context.Books.First(a => a.Book_Name == bookName).Id;
                reader_To_Book.ReaderId = _context.Readers.First(a => a.Fullname == fullName).Id;
                reader_To_Book.Deadline = deadLine;
                reader_To_Book.Get_Book = getDate;
                _context.Reader_to_Book.Add(reader_To_Book);
                _context.SaveChanges();
                MessageBox.Show("Book selected successfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillField();
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void dtgOrderBook_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            buttonVisible("add");
            int bookId = (int)dtgOrderBook.Rows[e.RowIndex].Cells[0].Value;
            selectedName = _context.Reader_to_Book.First(b => b.Id == bookId);
            txtFullname.Text = selectedName.Reader.Fullname;
            cmbBookName.Text = selectedName.Book.Book_Name;
            dtDeadline.Value = selectedName.Deadline;
            dtGetBook.Value = selectedName.Get_Book;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            buttonVisible("cancel");
            FillField();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            buttonVisible("delete");
            DialogResult dialogResult = MessageBox.Show("Are you sure delete book?", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)
            {
                _context.Reader_to_Book.Remove(selectedName);
                _context.SaveChanges();
                FillField();
            }       
         }
    }
}
