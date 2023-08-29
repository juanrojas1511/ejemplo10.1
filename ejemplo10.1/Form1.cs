namespace ejemplo10._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double consumo;
            double descuento;
            double importe_a_pagar;
            double impuesto;
            double subtotal;
            consumo = double.Parse(consumoTextBox.Text);
            if (consumo <= 100)
            {
                descuento = consumo * 0.1;
            }
            else
            {
                descuento = consumo * 0.2;
            }
            subtotal = consumo - descuento;
            impuesto = subtotal * 0.18;
            importe_a_pagar = subtotal + impuesto;
            descuentoLa.Text = "S/ " + descuento;
            impuestoLa.Text = "S/ " + impuesto;
            subtotalLa.Text = "S/ " + subtotal;
            importe_a_pagarLa.Text = "S/ " + importe_a_pagar;
        }
    }
}
