using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTree;

namespace booksManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ID = random.Next(0, 9999);
        }

        BTree<int, Book> bTree = new BTree<int, Book>(4);
        List<string> authorName = new List<string>();
        List<string> bookName = new List<string>();
        Random random = new Random();
        int ID;

        private void Form1_Load(object sender, EventArgs e)
        {
            authorName.Add("Tom");
            authorName.Add("Jerry");
            authorName.Add("Tony");
            authorName.Add("Wu");
            bookName.Add("DS");
            bookName.Add("Operating System");
            bookName.Add("Image captioning");
            bookName.Add("IO");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        { 
            int key = random.Next(0, 999);
            Book book = new Book
            {
                index = key,
                author = authorName[random.Next(0, authorName.Count - 1)],
                libStorage = random.Next(1, 50),
                name = bookName[random.Next(0, bookName.Count - 1)]
            };
            book.libLeft = book.libStorage;
            //if (txtInsert.Text != null)
            try
            {
                if (bTree.Insert(key, book))
                {
                    txtInsertPrint.Clear();
                    bTree.print(txtInsertPrint);
                }
                else txtInsertPrint.AppendText(key + " Has Been In The Tree");
            }
            catch (Exception err)
            {
                txtInsertPrint.AppendText(err.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                txtDelPrint.Clear();
                if (!bTree.Delete(int.Parse(txtDel.Text)))
                    txtDelPrint.AppendText(txtDel.Text + " Not Found\n");
                else
                    txtDelPrint.AppendText(txtDel.Text + " has been deleted\n");
                txtDel.Clear();

                bTree.print(txtDelPrint);
            }
            catch (Exception err)
            {
                txtDelPrint.AppendText(err.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultPrint.Clear();
                Node<int, Book> buffer = null;
                int index = 0;
                var result = bTree.Search(int.Parse(txtSearch.Text), ref index, ref buffer);
                txtResultPrint.AppendText("index: " + result.key + 
                    "                                " +
                    "name: " + result.pointer.name +
                    "                                " +
                    "author: " + result.pointer.author + 
                    "                                " +
                    "curent availability: " + result.pointer.libLeft);
            }
            catch(Exception err)
            {
                txtResultPrint.AppendText(err.ToString());
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                Node<int, Book> buffer = null;
                int index = 0;
                var result = bTree.Search(int.Parse(txtSearch.Text), ref index, ref buffer);
                if (result.pointer.libLeft > 0)
                {
                    result.pointer.libLeft--;
                    Reader reader = new Reader()
                    {
                        borrowDate = 20190101,
                        dateLeft = 30,
                        ID = ID
                    };
                    result.pointer.reader.Add(reader);
                    txtResultPrint.AppendText("index: " + result.key +
                        "                                " +
                        "name: " + result.pointer.name +
                        "                                " +
                        "author: " + result.pointer.author +
                        "                                " +
                        "curent availability: " + result.pointer.libLeft);
                    txtResultPrint.AppendText("borrowed! ID: " + ID +
                        "                                " +
                        result.pointer.reader.ToString());
                }
            }
            catch (Exception err)
            {
                txtResultPrint.AppendText(err.ToString());
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultPrint.Clear();
                Node<int, Book> buffer = null;
                int index = 0;
                var result = bTree.Search(int.Parse(txtSearch.Text), ref index, ref buffer);
                List<Reader> buffer2 = new List<Reader>();
                buffer2.AddRange (result.pointer.reader);
                foreach (var x in buffer2) 
                {
                    if (x.ID == ID)
                    {
                        result.pointer.libLeft++;
                        result.pointer.reader.Remove(x);
                    }
                }
                txtResultPrint.AppendText("index: " + result.key +
                    "                                " +
                    "name: " + result.pointer.name +
                    "                                " +
                    "author: " + result.pointer.author +
                    "                                " +
                    "curent availability: " + result.pointer.libLeft);
                txtResultPrint.AppendText("returned! ID: " + ID +
                        "                                " +
                        result.pointer.reader.ToString());
            }
            catch (Exception err)
            {
                txtResultPrint.AppendText(err.ToString());
            }
        }
    }
}
