using System.Text.RegularExpressions;

namespace HolaMundo
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener texto ingresado en los textBox
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            // Validar que la contraseña cumpla con los requisitos
            // (?=.*[a-z]) - Una letra minúscula
            // (?=.*[A-Z]) - Una letra mayúscula
            // (?=.*\d)    - Un dígito
            // (?=.*[\W_]) - Un caracter especial
            string patronRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$";

            // Validación con REGEX
            if (!Regex.IsMatch(password, patronRegex))
            {
                MessageBox.Show(
                    "La contraseña debe contener:\n" +
                    "- Al menos una letra mayúscula\n" +
                    "- Al menos una letra minúscula\n" +
                    "- Al menos un símbolo\n" +
                    "- Al menos un número",
                    "Contraseña Inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return; 
            }

            // Validación de coincidencia de contraseñas
            if (password != confirmPassword)
            {
                MessageBox.Show(
                    "Las contraseñas no coinciden.",
                    "Contraseña Inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Si cumple con los requisitos y coinciden muestra el mensaje de éxito
            MessageBox.Show(
                "La contraseña ha sido validada",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
