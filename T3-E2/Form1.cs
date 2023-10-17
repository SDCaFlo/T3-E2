namespace T3_E2
{
    public partial class Form1 : Form
    {
        // Inicializamos la lista donde iremos almacenando los n�meros que agregemos
        List<int> numList = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        // Definimos el m�todo de ordenamiento por inserci�n.
        static void OrdInsercion(List<int> numList, bool asc = true)
        {
            /*
             * Este m�todo ordena las listas tanto de manera ascendente como descendente
             * dependiendo del par�metro asc.
             */
            int m = numList.Count;
            for (int i = 1; i < m; i++)
            {
                int key_value = numList[i];
                int j = i - 1;
                if (asc == true)
                {
                    while (j >= 0 && numList[j] > key_value)
                    {
                        numList[j + 1] = numList[j];
                        j--;
                    }
                }
                else
                {
                    while (j >= 0 && numList[j] < key_value)
                    {
                        numList[j + 1] = numList[j];
                        j--;
                    }
                }

                numList[j + 1] = key_value;
            }
        }



        // Bot�n que agrega los n�meros que se encuentren en la textbox.
        private void button1_Click(object sender, EventArgs e)
        {
            // Evaluamos que sea posible convertir a INT.
            if (int.TryParse(txtb_Num.Text, out int newNum))
            {
                // Si es posible la conversi�n, primero evaluamos que no est� en la lista.
                if (!numList.Contains(newNum))
                {
                    // Si no est� en la lista, procedemos a agregarlo.
                    numList.Add(newNum);
                    string listContents = string.Join(", ", numList).Trim(' ').Trim(',');
                    // Actualizamos el textbox donde se muestra la lista.
                    txtb_NumList.Text = listContents;
                }

            }
            // Se limpia el valor del textbox para poner otro n�mero.
            txtb_Num.Text = string.Empty;
        }

        // Bot�n de ordenamiento ascendente
        private void btn_OrdAsc_Click(object sender, EventArgs e)
        {
            // Usamos el m�todo de ordenamiento definidio, con el par�metro true : ascendente
            OrdInsercion(numList, true);
            string listContents = string.Join(", ", numList).Trim(' ').Trim(',');
            // Actualizamos el textbox donde se muestra la lista.
            txtb_NumList.Text = listContents;
        }

        // Bot�n de ordenamiento descendente
        private void btn_OrdDesc_Click(object sender, EventArgs e)
        {
            // Usamos el m�todo de ordenamiento definidio, con el par�metro true : descendente
            OrdInsercion(numList, false);
            string listContents = string.Join(", ", numList).Trim(' ').Trim(',');
            // Actualizamos el textbox donde se muestra la lista.
            txtb_NumList.Text = listContents;
        }
    }
}