using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using System.IO;

namespace FO_Code
{
    public partial class Form1 : Form
    {
        Get_Data get = new Get_Data();
        List<string> Files = new List<string>();
        List<Tag> tags = new List<Tag>();
        List<Tag> Selected_Tags = new List<Tag>();
        int N_Click = 0;
        public Form1()
        {
            InitializeComponent();
            Files = get.Get_MP3_Files(@"C:\Users\Nader\Desktop\Music\New Folder");
            for (int i = 0; i < Files.Count; i++)
            {
                tags.Add(get.getTag(Files[i]));
                tags[i].Order = (i + 1).ToString();
            }
            dataGridView.DataSource = tags;
        }

        private void Edit_Comment()
        {
            for (int i = 0; i < Files.Count; i++)
            {
                TagLib.File f = TagLib.File.Create(Files[i], TagLib.ReadStyle.Average);
                f.Tag.Comment = (i + 1).ToString();
                f.Save();
            }
        }

        private void view_button_Click(object sender, EventArgs e)
        {
            N_Click = 0;
            Selected_Tags = new List<Tag>();
            dataGridView.DataSource = tags;
        }

        private void sort_button_Click(object sender, EventArgs e)
        {
            if (N_Click == 0)
            {
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridView.Rows[i].Cells[0];
                    if ((string)chk.Value == "True")
                        Selected_Tags.Add(tags[i]);
                }
            }
            else
            {
                List<Tag> New_SelectedTags = new List<Tag>();
                for (int i = 0; i < Selected_Tags.Count; i++)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridView.Rows[i].Cells[0];
                    if ((string)chk.Value == "True")
                        New_SelectedTags.Add(Selected_Tags[i]);
                }
                Selected_Tags = new List<Tag>();
                Selected_Tags = New_SelectedTags;
            }
            if (Selected_Tags.Count > 1 && property_Combobox.ToString() != "")
            {
                if (property_Combobox.Text == "Album") { }
                else if (property_Combobox.Text == "Artist") { }
                else if (property_Combobox.Text == "Title") { }
                else if (property_Combobox.Text == "Genre") { }
                else if (property_Combobox.Text == "Year") { }
                else if (property_Combobox.Text == "Duration") { }
                property_Combobox.Text = "";
                N_Click++;
                dataGridView.DataSource = Selected_Tags;
            }
            else
                MessageBox.Show("Choose Songs & Property");

        }
    }
}
