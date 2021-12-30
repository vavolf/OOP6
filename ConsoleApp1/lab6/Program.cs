using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Secretary person = new Secretary("Анна", "Николаева", 32);
            person.DisplayInfo();

            Document document = new Document("ООО \"Братислава\"", 12, 10, 2021, true, 30.1);
            Document receipt = new Receipt("ООО \"Севастополь\"", 13, 10, 2021, true, "квитанция", 11);
            Document invoice = new Invoice("ООО \"Севастополь\"", 12, 10, 2021, true, "накладная", 10.1);
            Document invoice1 = new Invoice("ООО \"Севастополь\"", 12, 12, 2021, true, "накладная", 2.4);
            Document check = new Check("ООО \"Братислава\"", 12, 10, 2021, true, "чек", 9.2);
            Document check1 = new Check("ООО \"Севастополь\"", 10, 10, 2021, true, "чек", 3.5);
            Document receipt1 = new Receipt("ООО \"Севастополь\"", 19, 11, 2021, true, "квитанция", 1.12);

            Document[] someArray = { document, receipt, invoice, check1, check, invoice1, receipt1 };
            Bookkeeping arrayOfDocuments1 = new Bookkeeping(someArray);
            Bookkeeping arrayOfDocuments2 = new Bookkeeping(someArray);

            Console.WriteLine("Вывод исходного массива:\n ");
            arrayOfDocuments1.Display();
            Console.WriteLine("\n\n");

            arrayOfDocuments2.Add(receipt1);
            Console.WriteLine("Вывод второго массива после добавления элемента:\n");
            arrayOfDocuments2.Display();
            Console.WriteLine("\n\n");
            arrayOfDocuments1.Remove();
            Console.WriteLine("Вывод первого массива после удаления элемента");
            arrayOfDocuments1.Display();
            Console.WriteLine("\n\n");

            Console.WriteLine(":Суммарная стоимость продукции заданного наименования по всем накладным:");
            Console.WriteLine("Введите наименование");
            string name = Console.ReadLine();
            Console.WriteLine($"Сумма равна: {Controller.SumPrice(arrayOfDocuments1, name)}");
            Console.WriteLine("");


            //----------------------------------------------//

            Console.WriteLine($"Количество чеков в массиве равно: {Controller.CheckAmount(arrayOfDocuments1)}");
            Console.WriteLine("");

            Console.WriteLine(":Вывод документов за указанную дату:");
            Console.WriteLine("Введите день: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вывод документов");
            Controller.DocumentsForDate(arrayOfDocuments1, day, month, year);
            Console.ReadKey();
        }
    }
}
