using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Store
    {
        public Product[] Products;
        public Phone[] Phones;
        public Notebook[] Notebooks;
        public static int NotebookLimit;
        public static int PhoneLimit;
        public Store()
        {
            Products= new Product[0];
            Phones= new Phone[0];
            Notebooks = new Notebook[0];
        }

        public void AddProduct(Product product)
        {
            if(product is Phone)
            {
                Phone phone = (Phone)product;
                Array.Resize(ref Phones, Phones.Length + 1);
                Phones[Phones.Length-1] = phone;
            }
            else if(product is Notebook)
            {
                Notebook notebook = (Notebook)product;
                Array.Resize(ref Notebooks, Notebooks.Length + 1);
                Notebooks[Notebooks.Length - 1] = notebook;
            }

            if(product is Phone && Phones.Length <= PhoneLimit) {
                
                Array.Resize(ref Products, Products.Length + 1);
                Products[Products.Length - 1] = product;
            }
            else if(product is Notebook && Notebooks.Length <= NotebookLimit) {
                Array.Resize(ref Products,Products.Length + 1);
                Products[Products.Length - 1] = product;
            }
        }

        public Product FindByNo(int no)
        {
            foreach (var prod in Products)
            {
                if(prod.No == no)
                {
                    return prod;
                }
            }
            return null;
        }

        public double CalcNotebookAvg()
        {
            double sum = 0;
            foreach (var notebook in Notebooks) {
                sum += notebook.Price;
            }
            return sum / Notebooks.Length;
        }

        public double CalcPhoneAvg() {
            double sum = 0;
            foreach (var phone in Phones)
            {
                sum += phone.Price;
            }
            return sum / Phones.Length;
        }
    }
}
