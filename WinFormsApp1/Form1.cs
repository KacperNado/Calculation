namespace WinFormsApp1;

using Calculation;


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    calculatION cal = new calculatION();


    private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
        try
        {
            int i = cal.Add(int.Parse(txtFirstNo.Text), int.Parse(txtSecNo.Text));
            txtResult.Text = i.ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

        private void Odejmij_Click(object sender, EventArgs e)
        {
        try
        {
            int i = cal.Sub(int.Parse(txtFirstNo.Text), int.Parse(txtSecNo.Text));
            txtResult.Text = i.ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
