using System;
using System.Globalization;

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
            catch (FormatException)
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

        // Búsqueda.
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            // Vamos a implementar un errorHandling, ya que puede intentar buscare valores no numéricos.
            try
            {
                // Busca el índice del número introducido.
                int index = o_numList.FindIndex(num => num == int.Parse(txtb_Buscar.Text));
                // Si no se encuentra, devuelve un error en el output.
                if (index < 0)
                {
                    txtb_Output.Text = "Error: No se encontró el elemento.";
                }
                else
                {
                    // Si lo encontramos, devolvemos el index.
                    txtb_Output.Text = String.Format("OK: El elemento se encuentra en la posición {0}.", index);
                }

            }
            catch (FormatException)
            {
                // Output indicando el error encontrado.
                txtb_Output.Text = "FormatException: Por favor ingrese un valor válido.";
            }
            finally
            {
                // Se limpiar el valor de la búsqueda.
                txtb_Buscar.Text = string.Empty;
            }
        }

        // Eliminar elementos.
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            // Se busca el elemento. Se evitar errores con TRY. CATCH
            try
            {
                // convertimos el texto del textbox a INT para evaluar.
                int Num_to_Delete = int.Parse(txtb_Eliminar.Text);
                // Tratamos de eliminar el número. Si se elimina. devuelve true.
                if (o_numList.Remove(Num_to_Delete))
                {
                    // Reporta la correcta eliminación en el output.
                    txtb_Output.Text = string.Format("OK: Se eliminó el número {0}.", Num_to_Delete);
                    // Actualiza la lista.
                    string listContents = string.Join(", ", o_numList).Trim(' ').Trim(',');
                    // Actualizamos el textbox donde se muestra la lista.
                    txtb_NumList.Text = listContents;
                }
                else
                {
                    // Informa que no se encontró dicho número.
                    txtb_Output.Text = string.Format("Error: No se encontró {0}. Entonces, no se eliminó.", Num_to_Delete);
                }

            }
            // Error handling.
            catch (FormatException)
            {
                txtb_Output.Text = "FormatException: Por favor ingrese un valor válido.";
            }
            finally
            {
                txtb_Eliminar.Text = string.Empty;
            }
        }
    }
}