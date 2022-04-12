using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.BitConverter;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        MW_EasyPOD EasyPOD;

        UInt32 dwResult, Index;

        unsafe public void btnGetUID_Click(object sender, EventArgs e)
        {
            UInt32 uiLength, uiRead, uiResult, uiWritten;
            byte[] ReadBuffer = new byte[0x40];


            string Skey1 = key1.Text;
            byte[] Akey1 = { 0x00 };

            if (Skey1 == "A")
            {
                Akey1[0] = 0x60;
            }
            if (Skey1 == "B")
            {
                Akey1[0] = 0x61;
            }
            
            string SLoadKey = LoadKey.Text;
            byte[] LoadKey1 = { Convert.ToByte(SLoadKey.Substring(0, 2), 16) };

            byte[] LoadKey2 = { Convert.ToByte(SLoadKey.Substring(2, 2), 16) };

            byte[] LoadKey3 = { Convert.ToByte(SLoadKey.Substring(4, 2), 16) };

            byte[] LoadKey4 = { Convert.ToByte(SLoadKey.Substring(6, 2), 16) };

            byte[] LoadKey5 = { Convert.ToByte(SLoadKey.Substring(8, 2), 16) };

            byte[] LoadKey6 = { Convert.ToByte(SLoadKey.Substring(10, 2), 16) };

            byte[] tmp1Array = { Convert.ToByte(sector1.Text.Substring(0, 2), 16) };
            byte bSector1 = tmp1Array[0];

            byte[] tmp2Array = { Convert.ToByte(block1.Text.Substring(0, 2), 16) };
            byte bBlock1 = tmp2Array[0];

            byte[] WriteBuffer = new byte[] { 0x2, 0xA, 0x15, Akey1[0], LoadKey1[0], LoadKey2[0], LoadKey3[0], LoadKey4[0], LoadKey5[0], LoadKey6[0], bSector1, bBlock1 };
            Console.WriteLine(BitConverter.ToString(WriteBuffer));



            byte[] sResponse = null;
            sResponse = new byte[21];

            EasyPOD.VID = 0xe6a;
            EasyPOD.PID = 0x317;

            Index = 1;
            uiLength = 64;

            fixed (MW_EasyPOD* pPOD = &EasyPOD)
            {

                dwResult = PODfuncs.ConnectPOD(pPOD, Index);

                if ((dwResult != 0))
                {
                    MessageBox.Show("Not connected yet");
                }
                else
                {
                    EasyPOD.ReadTimeOut = 200;
                    EasyPOD.WriteTimeOut = 200;

                    dwResult = PODfuncs.WriteData(pPOD, WriteBuffer, 12, &uiWritten);    //Send a request command to reader
                    uiResult = PODfuncs.ReadData(pPOD, ReadBuffer, uiLength, &uiRead);  //Read the response data from reader
                    

                    txbGetUIDh.Text = BitConverter.ToString(ReadBuffer, 4, (Int32)uiRead).Replace("-", " ");  //HEX
                    //txbGetUIDd.Text = BitConverter.ToInt32(ReadBuffer, 4).ToString();  //DEC
                }
                dwResult = PODfuncs.ClearPODBuffer(pPOD);
                dwResult = PODfuncs.DisconnectPOD(pPOD);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
 
            string sector1_Text = sector1.Text;
            string block1_Text = block1.Text;
            string key1_Text = key1.Text;
            string LoadKey_Text = LoadKey.Text;
            if (block1_Text != "" && sector1_Text != "" && key1_Text != "" && LoadKey_Text.Length == 12)
            {
                button1.Enabled = true;
            }
            else
            {
                label7.Text = "LoadKey長度必須為12，且前方欄位不得為空";

                button1.Enabled = false;
            }
        }

        private void block1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sector1_Text = sector1.Text;
            string block1_Text = block1.Text;
            string key1_Text = key1.Text;
            string LoadKey_Text = LoadKey.Text;
            if (block1_Text != "" && sector1_Text != "" && key1_Text != "" && LoadKey_Text.Length == 12)
            {
                button1.Enabled = true;
            }
            else
            {
                label7.Text = "LoadKey長度必須為12，且前方欄位不得為空";

                button1.Enabled = false;
            }
        }

        private void key1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sector1_Text = sector1.Text;
            string block1_Text = block1.Text;
            string key1_Text = key1.Text;
            string LoadKey_Text = LoadKey.Text;
            if (block1_Text != "" && sector1_Text != "" && key1_Text != "" && LoadKey_Text.Length == 12)
            {
                button1.Enabled = true;
            }
            else
            {
                label7.Text = "LoadKey長度必須為12，且前方欄位不得為空";

                button1.Enabled = false;
            }
        }

        private void LoadKey_TextChanged(object sender, EventArgs e)
        {
            string sector1_Text = sector1.Text;
            string block1_Text = block1.Text;
            string key1_Text = key1.Text;
            string LoadKey_Text = LoadKey.Text;
            if (block1_Text != "" && sector1_Text != "" && key1_Text != "" && LoadKey_Text.Length == 12)
            {
                button1.Enabled = true;
            }
            else
            {
                label7.Text = "LoadKey長度必須為12，且前方欄位不得為空";

                button1.Enabled = false;
            }
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbGetUIDh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
