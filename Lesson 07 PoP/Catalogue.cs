using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_07_PoP
{
    public class Catalogue<T> where T : IVehicle
    {
        private List<T> Items;
        // private Dictionary<Make, List<Model>> MakerModels = new Dictionary<Make, List<Model>>();

        public Catalogue()
        {
            Items = new List<T>();

            //MakerModels.Add(Make.Ford, new List<Model> { Model.Focus, Model.Escape });
            //MakerModels.Add(Make.Toyota, new List<Model> { Model.Camry, Model.Corolla });
            //MakerModels.Add(Make.Peugeot, new List<Model> { Model._306, Model._406 });
            //MakerModels.Add(Make.Renault, new List<Model> { Model.Megane });
        }

        public void Add(T item)
        {
            Items.Add(item);
        }

        public bool Remove(int itemIndex)
        {
            if (itemIndex > 0 && itemIndex < Items.Count)
            {
                Items.RemoveAt(itemIndex);
                return true;
            }
            return false;
        }

        public void List()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void SortBy(string sortField)
        {
            // Using Insertion Sort

            for (int i = 0; i < Items.Count; i++)
            {
                T temp = Items[i];
                int j = i;

                switch (sortField)
                {
                    case "year":
                        while (j > 0 && temp.Year < Items[j - 1].Year)
                        {
                            Items[j] = Items[j - 1];
                            j = j - 1;
                        }
                        break;

                    default: // RegistrationNumber
                        while (j > 0 && string.Compare(temp.RegistrationNumber, Items[j - 1].RegistrationNumber) < 0)
                        {
                            Items[j] = Items[j - 1];
                            j = j - 1;
                        }
                        break;
                }
                Items[j] = temp;
            }
        }

        public T SearchByYear(int year)
        {
            foreach (T item in Items)
            {
                if (item.Year == year)
                {
                    return item;
                }
            }
            return default(T);
        }
    }
}
