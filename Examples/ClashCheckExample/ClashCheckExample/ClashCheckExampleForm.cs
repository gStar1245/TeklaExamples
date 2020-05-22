using System;
using System.Collections;

using Tekla.Structures.Dialog;

namespace ClashCheckExample
{
    public partial class ClashCheckExampleForm : ApplicationFormBase
    {
        private readonly ClashCheckExample clashCheckExample = new ClashCheckExample();

        public ClashCheckExampleForm()
        {
            InitializeComponent();

            BtnCheck.Click += BtnCheck_Click;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if(clashCheckExample.ClashCheck())
            {
                ArrayList ClashCheckData = clashCheckExample.Clashes;
                foreach(string data in ClashCheckData)
                {
                    richTextBox1.AppendText(data + "\r\n");
                }
            }
        }
    }
}
