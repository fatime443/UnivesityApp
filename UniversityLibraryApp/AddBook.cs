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
    public partial class AddBook : Form
    {
        UniLibraryDbEntities _context = new UniLibraryDbEntities();
        Book selectedBook;
        public AddBook()
        {
            InitializeComponent();
        }
        private void FillBooksDataGridView()
        {
            dtgBooks.DataSource = _context.Books.Select(b => new
            {
                b.Id,
                b.Book_Name,
                b.Count,
                b.Publish_Date,
                b.Author.Author_Name
            }).ToList();
            dtgBooks.Columns[0].Visible = false;
        }
        private void FillAuthorsComboBox()
        {
            cmbAuthors.Items.AddRange(_context.Authors.Select(a => a.Author_Name).ToArray());

        }

        private void ClearAllField()
        {
            txtBookName.Text = string.Empty;
            dtPublishDate.Value = DateTime.Now;
            nmBookCount.Value = 1;
            cmbAuthors.Items.Clear();
        }
        private void AddBook_Load(object sender, EventArgs e)
        {
            FillAuthorsComboBox();
            FillBooksDataGridView();
        }
        private void FillField()
        {
            ClearAllField();
            FillAuthorsComboBox();
            FillBooksDataGridView();
        }
        private void ButtonVisible(string text)
        {
            if (text == "add")
            {
                btnAdd.Visible = false;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
                btnCancel.Visible = true;
            }
            else
            {
                btnAdd.Visible = true;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                btnCancel.Visible = false;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string bookName = txtBookName.Text;
            string authors = cmbAuthors.Text;
            DateTime publishDate = dtPublishDate.Value;
            int bookCount = (int)nmBookCount.Value;
            Book book = new Book();
            if (!string.IsNullOrWhiteSpace(bookName) && !string.IsNullOrWhiteSpace(authors))
            {
                lblError.Visible = false;
                book.Book_Name = bookName;
                book.Count = bookCount;
                book.Publish_Date = publishDate;
                book.AuthorId = _context.Authors.First(a => a.Author_Name == authors).Id;
                _context.Books.Add(book);
                _context.SaveChanges();
                MessageBox.Show("Book added successfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillField();
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void dtgBooks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ButtonVisible("add");
            int bookId = (int)dtgBooks.Rows[e.RowIndex].Cells[0].Value;
            selectedBook = _context.Books.First(b => b.Id == bookId);
            txtBookName.Text = selectedBook.Book_Name;
            nmBookCount.Value = selectedBook.Count;
            dtPublishDate.Value = selectedBook.Publish_Date;
            cmbAuthors.Text = selectedBook.Author.Author_Name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ButtonVisible("cancel");
            FillField();
            lblError.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this book?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)
            {
                _context.Books.Remove(selectedBook);
                _context.SaveChanges();
                MessageBox.Show("Book deleted successfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillField();
                ButtonVisible("delete");

            }
            

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBookName.Text))
            {
                lblError.Visible = false;
                selectedBook.Book_Name = txtBookName.Text;
                selectedBook.Count = (int)nmBookCount.Value;
                selectedBook.Publish_Date = dtPublishDate.Value;
                selectedBook.AuthorId = _context.Authors.First(a => a.Author_Name == cmbAuthors.Text).Id;
                _context.SaveChanges();
                FillField();
                ButtonVisible("edit");
            }

            else
            {
                lblError.Visible = true;
            }  
        }
    }
}
