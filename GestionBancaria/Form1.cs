namespace GestionBancaria
{
    public partial class Form1 : Form
    {
        private double saldo_zpn_2223 = 1000;  // Saldo inicial de la cuenta, 1000€

        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = false;
            txtSaldo.Text = saldo_zpn_2223.ToString();
            txtCantidad.Text = "0";
        }

        private bool realizarReintegro(double cantidad_zpn_2223)
        {
            if (cantidad_zpn_2223 > 0 && saldo_zpn_2223 > cantidad_zpn_2223)
            {
                saldo_zpn_2223 -= cantidad_zpn_2223;
                return true;
            }
            return false;
        }

        private void realizarIngreso(double cantidad_zpn_2223)
        {
            if (radioButton1.Checked)
            {


                if (cantidad_zpn_2223 > 0)
                    saldo_zpn_2223 += cantidad_zpn_2223;
            }
        }

        private void btOperar_Click(object sender, EventArgs e)
        {
            double cantidad_zpn_2223 = Convert.ToDouble(txtCantidad.Text); // Cogemos la cantidad del TextBox y la pasamos a número
                                                                           //   if (cantidad_zpn_2223 < 0)
            {
                //    MessageBox.Show("Cantidad no válidá, sólo se admiten cantidades positivas.");
                //  }
                if (rbReintegro.Checked) //rbReintegro
                {
                    if (realizarReintegro(cantidad_zpn_2223) == false)
                    {
                        if (cantidad_zpn_2223 > 1000)
                        {
                            MessageBox.Show("No se ha podido realizar la operación (¿Saldo insuficiente?)");
                        }
                    }
                    
                      
                    
                       
                       
                }
                else
                    realizarIngreso(cantidad_zpn_2223);
                txtSaldo.Text = saldo_zpn_2223.ToString();
            }
        }
    }
}