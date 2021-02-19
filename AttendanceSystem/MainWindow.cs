using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystem
{
    public partial class MainWindow : MetroFramework.Forms.MetroForm
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
        }
    }
}
