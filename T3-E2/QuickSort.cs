using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_E2
{
    // Creamos una clase donde definiremos las etapas del ordenamiento quicksort.
    public class QuickSort<T> where T : IComparable<T>
    {
        // Está será el método principal, que iniciará la recursividad. Toma una lista T como parámetro.
        public static void Sort(List<T> list)
        {
            // Se evalua que la lista no esté vacia o tenga 1 solo valor.
            if (list == null || list.Count <= 1)
                return;

            // Se llama al método recursivo.
            QuickSortRecursive(list, 0, list.Count - 1);
        }

        // El ordenamiento recursivo toma la lista T, y un valor en cada extremo de la lista.
        private static void QuickSortRecursive(List<T> list, int left, int right)
        {
            // Se evalua que se haya escojido los valores correctos. 
            if (left < right)
            {
                // Se llama al método partition, que hará el ordenamiento.
                int partitionIndex = Partition(list, left, right);

                // Se continúa aplicando QuickSortRecursive, particionando la lista.
                QuickSortRecursive(list, left, partitionIndex - 1);
                QuickSortRecursive(list, partitionIndex + 1, right);
            }
        }

        // Método Particion.
        private static int Partition(List<T> list, int left, int right)
        {
            // Se define el pivot, en este caso se toma el indice extremo derecho.
            T pivot = list[right];
            int i = left - 1;

            // Se comienza a comparar los elementos con el PIVOT
            for (int j = left; j < right; j++)
            {   
                // Si el elemento precede al pivot. se cambia. Se usa el método CompareTo.
                if (list[j].CompareTo(pivot) < 0)
                {
                    i++;
                    Swap(list, i, j);
                }
            }

            // Finalmente se coloca el pivot en el lugar correcto.
            Swap(list, i + 1, right);
            return i + 1;
        }

        // El método swap resume el intercambio de lugares entre dos elementos de la lista.
        // Toma la lista, y los indices que deseamos intercambiar.
        private static void Swap(List<T> list, int index1, int index2)
        {
            // Se guarda un valor temporal
            T temp = list[index1];
            // Se intercambia el primer valor.
            list[index1] = list[index2];
            // Se reemplaza el segundo valor con el valor guardado.
            list[index2] = temp;
        }

        /*
        internal void Sort(List<int> numList)
        {
            throw new NotImplementedException();
        }
        */
    }
}
