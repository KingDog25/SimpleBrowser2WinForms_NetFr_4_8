using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBrowser2WinForms_NetFr_4_8
{
    public partial class MainForm : Form
    {
        private string homePage;
        private Timer timerHidePanel;

        //private bool isHidden = true;
        public MainForm()
        {
            InitializeComponent();
            InitializeBrowser();

            tableLayoutPanel2.Visible = false; // изначально панель скрыта

            //this.Controls.Add(tableLayoutPanel2);
            //this.MouseMove += MainForm_MouseMove;

            // Create the timer
            timerHidePanel = new Timer();
            timerHidePanel.Interval = 2000; // 2000 ms delay
            timerHidePanel.Tick += timerHidePanel_Tick;

            // Set up event handlers
            menuStrip1.MouseEnter += menuStrip1_MouseEnter;
            tableLayoutPanel2.MouseEnter += tableLayoutPanel2_MouseEnter;
            tableLayoutPanel2.MouseLeave += tableLayoutPanel2_MouseLeave;
            tableLayoutPanel1.MouseEnter += tableLayoutPanel1_MouseEnter;
            tableLayoutPanel1.MouseLeave += tableLayoutPanel1_MouseLeave;
            buttonMain.MouseEnter += buttonMain_MouseEnter;
            buttonBackClick.MouseEnter += buttonBackClick_MouseEnter;
            buttonFowardClick.MouseEnter += buttonFowardClick_MouseEnter;
            buttonRefresh.MouseEnter += buttonRefresh_MouseEnter;
            buttonMain.MouseMove += buttonMain_MouseMove;
            buttonBackClick.MouseMove += buttonBackClick_MouseMove;
            buttonFowardClick.MouseMove += buttonFowardClick_MouseMove;
            buttonRefresh.MouseMove += buttonRefresh_MouseMove;
            menuStrip1.MouseMove += menuStrip1_MouseMove;
        }


        private void InitializeBrowser()
        {
            //webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.ScriptErrorsSuppressed = true; // Разрешаем выполнение скриптов
            Controls.Add(webBrowser1);
            homePage = Properties.Settings.Default.searchEngine;
            webBrowser1.Navigate(homePage);

            webBrowser1.NewWindow += WebBrowser1_NewWindow;
            webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompleted; //получение ссылок в адр. стр.

            //groupBox1.MouseEnter += GroupBox1_MouseEnter;
            //groupBox1.MouseLeave += GroupBox1_MouseLeave;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            webBrowser1.Dispose(); // Освобождение ресурсов при закрытии формы
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                homePage = FormatUrl(Properties.Settings.Default.searchEngine);
                webBrowser1.Navigate(homePage);
            }
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(homePage);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void WebBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true; // Cancel the new window creation
            webBrowser1.Navigate(webBrowser1.StatusText); // Navigate to the new URL in the current window
            //txtbox_address_bar.Text = webBrowser1.Url.ToString();
        }

        private void buttonBackClick_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
                //txtbox_address_bar.Text = webBrowser1.Url.ToString();
            }
        }

        private void buttonFowardClick_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }
        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            txtbox_address_bar.Text = webBrowser1.Url.ToString();
        }

        private string FormatUrl(string url)
        {
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }
            return url;
        }

        private void txtbox_address_bar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string url = txtbox_address_bar.Text;
                url = FormatUrl(url);
                webBrowser1.Navigate(url);
            }
        }
 

        private void menuStrip1_MouseEnter(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = true;
            tableLayoutPanel1.Visible = true;
            timerHidePanel.Stop();
        }

        private void tableLayoutPanel2_MouseLeave(object sender, EventArgs e)
        {
            timerHidePanel.Start();
        }

        private void timerHidePanel_Tick(object sender, EventArgs e)
        {
            timerHidePanel.Stop();
            tableLayoutPanel1.Visible = false;
            tableLayoutPanel2.Visible = false;
        }

        private void tableLayoutPanel2_MouseMove(object sender, MouseEventArgs e)
        {
            timerHidePanel.Stop();
        }

        private void tableLayoutPanel2_MouseEnter(object sender, EventArgs e)
        {
            timerHidePanel.Stop();
        }

        private void tableLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
            timerHidePanel.Stop();
        }

        private void tableLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            timerHidePanel.Stop();
        }

        private void tableLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
            timerHidePanel.Start();
        }

        private void txtbox_address_bar_MouseEnter(object sender, EventArgs e)
        {
            timerHidePanel.Stop();
        }

        private void txtbox_address_bar_MouseMove(object sender, MouseEventArgs e)
        {
            timerHidePanel.Stop();
        }

        private void buttonMain_MouseEnter(object sender, EventArgs e)
        {
            timerHidePanel.Stop();
        }

        private void buttonMain_MouseMove(object sender, MouseEventArgs e)
        {
            timerHidePanel.Stop();
        }

        private void buttonBackClick_MouseEnter(object sender, EventArgs e)
        {
            timerHidePanel.Stop();
        }

        private void buttonFowardClick_MouseEnter(object sender, EventArgs e)
        {
            timerHidePanel.Stop();
        }

        private void buttonRefresh_MouseEnter(object sender, EventArgs e)
        {
            timerHidePanel.Stop();
        }

        private void buttonRefresh_MouseMove(object sender, MouseEventArgs e)
        {
            timerHidePanel.Stop();
        }

        private void buttonBackClick_MouseMove(object sender, MouseEventArgs e)
        {
            timerHidePanel.Stop();
        }

        private void buttonFowardClick_MouseMove(object sender, MouseEventArgs e)
        {
            timerHidePanel.Stop();
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            timerHidePanel.Stop();
        }

        /*
         //не работает!
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < 500) // если курсор мыши находится в верхней части окна (менее 50 пикселей от верхнего края)
            {
                tableLayoutPanel2.Visible = true; // отображаем панель
            }
            else
            {
                tableLayoutPanel2.Visible = false; // скрываем панель
            }
        }

        */
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Получаем информацию о текущей сборке
            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyProductAttribute productAttribute = (AssemblyProductAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyProductAttribute));
            string product = productAttribute.Product;
            Version version = assembly.GetName().Version;

            // Формируем сообщение для отображения
            string message = $"Product: {product}\nVersion: {version} Author: Roslyakov Aleksandr";

            // Отображаем MessageBox с информацией о продукте и версии
            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Демонстрационная версия программы. Для личного не коммерческого использования. Предоставляется как есть." +
                "Браузер ориентирован на простоту применения построен на движке Edge и компонентe Web Wiev NetF 4.8. Уступает IE. Пока не все сайты поддерживаются." +
                "Имеются идеи по обновлению дизайна, добавлению вкладок, закладок. Возможно запуск на друкгих платформах." +
                "Буду рад вашей поддержке, как финансовой, так и репостам, лайкам, комментариям и предложениям");
        }

        private void txtbox_address_bar_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string url = txtbox_address_bar.Text;
                url = FormatUrl(url);
                webBrowser1.Navigate(url);
            }
        }
    }
}
