namespace CalculadorBasico
{
    public partial class CalculadorBasico : Form
    {   //Declara��o de vari�veis
        double n1, n2, resultado = 0;

        public CalculadorBasico()
        { 

            InitializeComponent();
        }

        private void Bt02_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(CaixaTxt01.Text);
            n2 = Convert.ToDouble(CaixaTxt02.Text);

            resultado = n1 - n2;

            Txt01.Text = "Resultado da subtra��o : " + resultado.ToString();
        }

        private void Bt03_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(CaixaTxt01.Text);
            n2 = Convert.ToDouble(CaixaTxt02.Text);

            resultado = n1 * n2;

            Txt01.Text = "Resultado da multiplica��o : " + resultado.ToString();
        }

        private void Bt04_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(CaixaTxt01.Text);
            n2 = Convert.ToDouble(CaixaTxt02.Text);

            resultado = n1 / n2;

            Txt01.Text = "Resultado da divis�o : " + resultado.ToString();
        }

        private void CalculadorBasico_Load(object sender, EventArgs e)
        {
         
        }

        private void Bt01_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(CaixaTxt01.Text);
            n2 = Convert.ToDouble(CaixaTxt02.Text);

            resultado = n1 + n2;

            Txt01.Text = "Resultado da soma : " + resultado.ToString();



        }
    }
}