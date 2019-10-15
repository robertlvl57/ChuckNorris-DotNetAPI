using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuckNorrisAPI;

namespace ChuckNorrisJokeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetJoke_Click(object sender, EventArgs e)
        {
            Joke j = await ChuckNorrisClient.GetRandomJoke();
            MessageBox.Show(j.JokeText);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

        public async void PopulateComboBox()
        {
            var c = await ChuckNorrisClient.GetCategories();
            foreach(var categories in c)
            {
                cmbCategories.Items.Add(categories);
            }
        }
    }
}
