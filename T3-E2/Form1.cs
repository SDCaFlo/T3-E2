using System;

namespace T3_E2
{
    public partial class Form1 : Form
    {
        // Inicializamos la lista donde iremos almacenando los números que agregemos
        List<int> o_numList = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        // Botón que agrega los números que se encuentren en la textbox.
        private void button1_Click(object sender, EventArgs e)
        {
            // Evaluamos que sea posible convertir a INT. Se usará la construcción try, catch, finally
            // para manejar errores.
            try
            {
                int o_NewNum = int.Parse(txtb_Num.Text);
                if (!o_numList.Contains(o_NewNum))
                {
                    // Si no está en la lista, procedemos a agregarlo.
                    o_numList.Add(o_NewNum);
                    string listContents = string.Join(", ", o_numList).Trim(' ').Trim(',');
                    // Actualizamos el textbox donde se muestra la lista.
                    txtb_NumList.Text = listContents;
                    // output indicando correcta adición a la lista.
                    txtb_Output.Text = String.Format("OK: Se agregó el valor {0} a la lista.", o_NewNum);
                }
                else
                {
                    // Output en caso ya se tenga el valor en la lista.
                    txtb_Output.Text = "Error: Este valor ya se encuentra en la lista.";
                }
            }
            // Manejo de errores de formato, en caso se ponga un valor que no pueda ser convertido a INT.
            catch(FormatException)
            {
                // Output indicando el error encontrado.
                txtb_Output.Text = "FormatException: Por favor ingrese un valor válido.";
            }
            finally
            {
                // Se borra el número introducido en el textbox.
                txtb_Num.Text = string.Empty;
            }
            
        }

        // Botón de ordenamiento ascendente
        private void btn_OrdAsc_Click(object sender, EventArgs e)
        {
            // Llamamos al método de ordenamiento QuickSort.
            QuickSort<int>.Sort(o_numList);
            string listContents = string.Join(", ", o_numList).Trim(' ').Trim(',');
            // Actualizamos el textbox donde se muestra la lista.
            if (o_numList.Count > 1)
            {
                txtb_NumList.Text = listContents;
                txtb_Output.Text = "OK: Se ordenó la lista de manera ascendente.";
            }
            else
            {
                txtb_Output.Text = "Error: Se necesita más elementos.";
            }

        }

        // Botón de ordenamiento descendente
        private void btn_OrdDesc_Click(object sender, EventArgs e)
        {
            // Llamamos al método de ordenamiento QuickSort.
            QuickSort<int>.Sort(o_numList);
            // Invertimos el orden de los elementos-
            o_numList.Reverse();
            string listContents = string.Join(", ", o_numList).Trim(' ').Trim(',');
            // Actualizamos el textbox donde se muestra la lista.
            if (o_numList.Count > 1)
            {
                txtb_NumList.Text = listContents;
                txtb_Output.Text = "OK: Se ordenó la lista de manera descendente.";
            }
            else
            {
                txtb_Output.Text = "Error: Se necesita más elementos.";
            }
                
        }
    }
}