namespace Unesi_datume___pogledaj_dane_u_nedelji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DateTime datum = dateTimePicker1.Value;
            listBox2.Items.Add(datum.ToShortDateString());
            listBox1.Items.Add(datum.Day + ". " + datum.Month + ". " + datum.Year + ".");
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox2.SelectedIndex;
            DateTime datum = DateTime.Parse(listBox1.Items[index].ToString());
            richTextBox1.Text = "Engleski: " + datum.DayOfWeek;
            richTextBox1.Text += "\n";
            int redniBroj = 0;
            if ((int)datum.DayOfWeek == 0) redniBroj = 7;
            else redniBroj = (int)datum.DayOfWeek;
            richTextBox1.Text += "Redni broj: " + redniBroj;
            richTextBox1.Text += "\n";
            richTextBox1.Text += "Srpski: " + Srpski(redniBroj);
        }

        private string Srpski(int redniBroj)
        {
            string[] dani = { "Ponedeljak", "Utorak", "Sreda", "Cetvrtak", "Petak", "Subota", "Nedelja" };
            int ind = redniBroj - 1;
            return dani[ind];
        }
    }
}