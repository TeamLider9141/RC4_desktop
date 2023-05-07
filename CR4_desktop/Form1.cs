using System.Windows.Forms;

namespace CR4_desktop
{
    public partial class Form1 : Form
    {
        private const int BOX_LEN = 256;

        string message, key, encryptedText, decryptedText;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            message = textData.Text;
            key = textKey.Text;

            encryptedText = Encrypt(message, key);




            //Console.WriteLine(encryptedText);

            label1.Text = encryptedText; //message + " "+key;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                message = textData.Text;
                key = textKey.Text;

                //encryptedText = Encrypt(message, key);
                decryptedText = Decrypt(message, key);

                label1.Text = decryptedText;
            }

            catch
            {
                MessageBox.Show("RC4 algoritmi bo'yicha deshifrlab bo'lmaydi");
            }

        }
        private void textShow_TextChanged(object sender, EventArgs e)
        {
            //button1_Click(sender, e);

            message = textData.Text;
            key = textKey.Text;

            encryptedText = Encrypt(message, key);
            textShow.Text = encryptedText;

            this.Controls.Add(textShow);
            // Console.WriteLine();

        }
        private void textShow2_TextChanged(object sender, EventArgs e)
        {
            message = textData.Text;
            key = textKey.Text;

            // encryptedText = Encrypt(message, key);
            decryptedText = Decrypt(message, key);

            textBox1.Text = decryptedText;

            this.Controls.Add(textBox1);


        }



        static void Swap(ref byte a, ref byte b)
        {
            byte temp = a;
            a = b;
            b = temp;
        }

        static byte[] KSA(byte[] key)
        {
            byte[] mBox = new byte[BOX_LEN];
            for (int i = 0; i < BOX_LEN; i++)
            {
                mBox[i] = (byte)i;
            }
            int j = 0;
            for (int i = 0; i < BOX_LEN; i++)
            {
                j = (j + mBox[i] + key[i % key.Length]) % BOX_LEN;
                Swap(ref mBox[i], ref mBox[j]);
            }
            return mBox;
        }

        static byte[] PRGA(byte[] data, byte[] key)
        {
            byte[] outBytes = new byte[data.Length];
            byte[] mBox = KSA(key);
            int i = 0;
            int j = 0;
            for (int k = 0; k < data.Length; k++)
            {
                i = (i + 1) % BOX_LEN;
                j = (j + mBox[i]) % BOX_LEN;
                Swap(ref mBox[i], ref mBox[j]);
                outBytes[k] = (byte)(data[k] ^ mBox[(mBox[i] + mBox[j]) % BOX_LEN]);
            }
            return outBytes;
        }

        public static string Encrypt(string plainText, string password)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(plainText);
            byte[] key = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] encryptedBytes = PRGA(data, key);
            return BitConverter.ToString(encryptedBytes).Replace("-", "");
        }

        public static string Decrypt(string cipherText, string password)
        {
            byte[] data = new byte[cipherText.Length / 2];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = Convert.ToByte(cipherText.Substring(i * 2, 2), 16);
            }
            byte[] key = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] decryptedBytes = PRGA(data, key);
            return System.Text.Encoding.UTF8.GetString(decryptedBytes);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}