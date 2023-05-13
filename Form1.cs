using System.Windows.Forms;

namespace DM_Encryption_Project
{
    public partial class window : Form
    {
        private string encryption(string msg, int key)
        {
            char[] encryptMsg = new char[msg.Length];
            Console.Clear();
            for (int i = 0; i < msg.Length; i++)
            {
                char chardiff = ' ';
                Console.WriteLine((int)msg[i]);
                if (msg[i] >= 65 && msg[i] <= 90) encryptMsg[i] = (char)((msg[i] + key) % 26 + 'A');
                else if (msg[i] >= 97 && msg[i] <= 122) encryptMsg[i] = (char)((msg[i] - 32 + key) % 26 + 'a');
                Console.WriteLine(chardiff);
            }
            string returnMsg = new(encryptMsg);
            return returnMsg;
        }
        private string decryption(string msg, int key)
        {
            char[] decryptMsg = new char[msg.Length];
            Console.Clear();
            for (int i = 0; i < msg.Length; i++)
            {
                Console.WriteLine((int)msg[i]);
                if (msg[i] >= 65 && msg[i] <= 90) decryptMsg[i] = (char)((msg[i] - key) % 26 + 'A');
                else if (msg[i] >= 97 && msg[i] <= 122) decryptMsg[i] = (char)((msg[i] - 32 - key) % 26 + 'a');
            }
            string returnMsg = new(decryptMsg);
            return returnMsg;
        }
        public window()
        {
            InitializeComponent();
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            encryptBox.Text = decryption(decryptBox.Text, GlobalVars.key);
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            decryptBox.Text = encryption(encryptBox.Text, GlobalVars.key);
        }
    }
    public static class GlobalVars
    {
        public const int key = 43;
    }
}