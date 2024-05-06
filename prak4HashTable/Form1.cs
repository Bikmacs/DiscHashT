using System.Collections;

namespace prak4HashTable
{
    public partial class Form1 : Form
    {
        Hashtable hash = new Hashtable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (!string.IsNullOrEmpty(text))
            {
                hash.Add(hash.Count + 1, text);
                listBox1.Items.Add(hash[hash.Count]);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите текст");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                hash.Remove(listBox1.SelectedIndex + 1);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Пожалуйста, введите имя");
                return;
            }

            List<string> values = new List<string>();
            foreach (string value in hash.Values)
            {
                if (value.StartsWith(name, StringComparison.CurrentCultureIgnoreCase))
                {
                    values.Add(value);
                }
            }

            listBox1.Items.Clear();

            foreach (string value in values)
            {
                listBox1.Items.Add(value);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            List<string> values = new List<string>(hash.Values.Cast<string>());

            values.Sort();

            listBox1.Items.Clear();

            foreach (string value in values)
            {
                listBox1.Items.Add(value);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Пожалуйста, введите букву для поиска");
                return;
            }

            List<string> values = new List<string>();
            foreach (string value in hash.Values)
            {
                if (value.Contains(name, StringComparison.CurrentCultureIgnoreCase))
                {
                    values.Add(value);
                }
            }

            values.Sort();

            listBox1.Items.Clear();

            foreach (string value in values)
            {
                listBox1.Items.Add(value);
            }

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Clear();
        }
    }
}
