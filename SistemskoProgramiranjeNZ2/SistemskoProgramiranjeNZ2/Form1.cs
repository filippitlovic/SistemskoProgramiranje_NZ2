using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SistemskoProgramiranjeNZ2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void openApplication(string app, Button button)
        {
            Process process = Process.Start(app);
            process.WaitForExit();
            Thread.Sleep(500);
            button.Enabled = true;
        }

        private void btn_word_Click(object sender, EventArgs e)
        {
            btn_word.Enabled = false;
            var thread = new System.Threading.ThreadStart(delegate{openApplication("WINWORD.EXE", btn_word);});
            var thread2= new System.Threading.Thread(thread);
            thread2.Start();
        }
    
        private void btn_tskMngr_Click(object sender, EventArgs e)
        {
            btn_tskMngr.Enabled = false;
            var thread = new System.Threading.ThreadStart(delegate { openApplication("Taskmgr.exe",btn_tskMngr); });
            var thread2 = new System.Threading.Thread(thread);
            thread2.Start();
        }

        private void btn_notepad_Click(object sender, EventArgs e)
        {
            btn_notepad.Enabled = false;
            var thread = new System.Threading.ThreadStart(delegate { openApplication("notepad.exe", btn_notepad); });
            var thread2 = new System.Threading.Thread(thread);
            thread2.Start();
        }
    }

}
