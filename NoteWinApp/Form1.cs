using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteWinApp
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void noteTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if(dataGridTable.SelectedRows.Count > 0)
            {
                Console.WriteLine("Yeah !");
                try
                {
                    DataGridViewRow row = dataGridTable.SelectedRows[0];    
                    if(row != null && row.Cells[0].Value.ToString() == labelID.Text)
                    {
                        row.Cells[1].Value = noteTitle.Text;
                        row.Cells[2].Value = noteContentTextBox.Text;
                    }
                    else
                    {
                        Note newNote = new Note(noteTitle.Text, noteContentTextBox.Text);
                        table.Rows.Add(newNote.ID, newNote.NoteTitle, newNote.NoteContent);
                    }
                } catch(Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                Note newNote = new Note(noteTitle.Text, noteContentTextBox.Text);
                table.Rows.Add(newNote.ID, newNote.NoteTitle, newNote.NoteContent);
            }


            noteTitle.Clear();
            noteContentTextBox.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 index = dataGridTable.CurrentCell.RowIndex;
            if (index > -1)
            {
                labelID.Text = dataGridTable.Rows[index].Cells[0].Value.ToString();
                noteTitle.Text = dataGridTable.Rows[index].Cells[1].Value.ToString();
                noteContentTextBox.Text = dataGridTable.Rows[index].Cells[2].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Content", typeof(string));

            dataGridTable.DataSource = table;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            labelID.Text = "ID";
            noteTitle.Clear();
            noteContentTextBox.Clear();
        }

        private void dataGridTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 index = dataGridTable.CurrentCell.RowIndex;
            if (index > -1)
            {
                labelID.Text = dataGridTable.Rows[index].Cells[0].Value.ToString();
                noteTitle.Text = dataGridTable.Rows[index].Cells[1].Value.ToString();
                noteContentTextBox.Text = dataGridTable.Rows[index].Cells[2].Value.ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Int32 index = dataGridTable.CurrentCell.RowIndex;
            if(index > -1)
            {
                dataGridTable.Rows.RemoveAt(index);
            }
        }
    }
}
