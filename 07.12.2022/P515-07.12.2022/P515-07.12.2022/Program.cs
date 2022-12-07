
using Services;

Notebook notebook = new Notebook("Lenovo",2800);
Notebook notebook1 = new Notebook("Apple", 5000);
Notebook notebook2 = new Notebook("Asus", 2300);

Phone phone = new Phone("Iphone", 2500);
Phone phone1 = new Phone("Samsung", 2000);
Phone phone2 = new Phone("Huawei", 2800);

Store store = new Store();

Store.NotebookLimit = 2;
Store.PhoneLimit = 3;

store.AddProduct(notebook);

store.AddProduct(notebook1);
store.AddProduct(notebook2);
store.AddProduct(phone);
store.AddProduct(phone1);
store.AddProduct(phone2);


foreach (var prod in store.Products)
{
    Console.WriteLine(prod.No);
}

Console.WriteLine(store.CalcNotebookAvg()) ;
Console.WriteLine(store.CalcPhoneAvg());

Console.WriteLine(store.FindByNo(3)?.Name);
