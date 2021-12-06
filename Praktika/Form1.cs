using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 zadanie_2_3
        private delegate int AsyncSumm(int a, int b);

        AsyncSumm summdelegate = new AsyncSumm(Summ);

        static private int Summ(int a, int b)

        bool Cancel;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
 zadanie_2
        {
            System.Threading.Thread.Sleep(9000);
            return a + b;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int a, b;

            try
            {
                a = Int32.Parse(txtA.Text);
                b = Int32.Parse(txtB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                txtA.Text = txtB.Text = "";
                return;
            }

 zadanie_2_3
            AsyncSumm summdelegate = new AsyncSumm(Summ);
            AsyncCallback cb = new AsyncCallback(CallBackMethod);
            summdelegate.BeginInvoke(a, b, cb, summdelegate);

        public delegate void SerProgressDelegate(int val);

        public void SetProgress(int val)
        {
            if (progressBar1.InvokeRequired)
            {
                SerProgressDelegate del = new SerProgressDelegate(SetProgress);
                this.Invoke(del, new object[] { val });
            }
            else
            {
                progressBar1.Value = val;
            }
        }

        private delegate void TimeConsumingMethodDelegate(int seconds);
        private void TimeConsumingMethod(int seconds)
        {
            for (int j = 1; j <= seconds; j++)
            {
                SetProgress((int)(j * 100 / seconds));
                if (Cancel)
                    break;
                System.Threading.Thread.Sleep(1000);
            }
            if (Cancel)
            {
                System.Windows.Forms.MessageBox.Show("Cancelled");
                Cancel = false;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Complete");
            }
 zadanie_2
        }

        private void CallBackMethod(IAsyncResult ar)
        {
            string str;
            AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState;
            str = String.Format("Сумма введенных чисел равна {0}", summdelegate.EndInvoke(ar));
            MessageBox.Show(str, "Результат операции");
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работа кипит!!!");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
