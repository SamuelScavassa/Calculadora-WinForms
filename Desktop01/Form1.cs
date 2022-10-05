namespace Desktop01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        protected string numUm { get; set; }
        protected string numDois { get; set; }

        protected Calculadora calc = new Calculadora();

        public void Defin()
        {
            numUm = numeroUm.Text;
            numDois = numeroDois.Text;
        }

        public double Mk(string num)
        {
            double umm;
            if ((double.TryParse(num.ToString(), out umm)))
            {}           

            return umm;

        }

        private void botaoSoma_Click(object sender, EventArgs e)
        {
           Defin();
           calc.NumUm = Mk(numUm); 
           calc.NumDois = Mk(numDois);
           resultado.Text = calc.Soma().ToString(); //BO AQUI 
        }

        private void botaoMenos_Click(object sender, EventArgs e)
        {
            Defin();
            calc.NumUm = Mk(numUm);
            calc.NumDois = Mk(numDois);
            resultado.Text = calc.Sub().ToString();
        }

        private void botaoMult_Click(object sender, EventArgs e)
        {
            Defin();
            calc.NumUm = Mk(numUm);
            calc.NumDois = Mk(numDois);
            resultado.Text = calc.Mult().ToString();
        }

        private void botaoDiv_Click(object sender, EventArgs e)
        {
            Defin();
            calc.NumUm = Mk(numUm);
            calc.NumDois = Mk(numDois);
            resultado.Text = calc.Div().ToString();
        }


    }
}