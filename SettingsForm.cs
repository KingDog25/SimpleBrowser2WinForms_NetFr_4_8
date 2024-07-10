using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBrowser2WinForms_NetFr_4_8
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                Properties.Settings.Default.searchEngine = comboBox1.Text;
                Properties.Settings.Default.Save();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Действия в случае, если поле пустое
                MessageBox.Show("Выберите поисковую страницу", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
