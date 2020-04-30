using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatci_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("1984");
            Video video = new Video("Iron Man");
            List<IRentable> whatIsInInventory = new List<IRentable>();
            whatIsInInventory.Add(book);
            whatIsInInventory.Add(video);

            RentingConsolePrinter rentingConsolePrinter = new RentingConsolePrinter();
            rentingConsolePrinter.DisplayItems(whatIsInInventory);
            rentingConsolePrinter.PrintTotalPrice(whatIsInInventory);

            Book newBook = new Book("Zločin i kazna");
            HotItem hotBook = new HotItem(newBook);
            Video newVideo = new Video("Scream");
            HotItem hotVideo = new HotItem(newVideo);
            whatIsInInventory.Add(hotBook);
            whatIsInInventory.Add(hotVideo);

            rentingConsolePrinter.DisplayItems(whatIsInInventory);
            rentingConsolePrinter.PrintTotalPrice(whatIsInInventory);

            List<IRentable> flashSale = new List<IRentable>();

            foreach (IRentable rentables in whatIsInInventory)
            {
                flashSale.Add(new DiscountedItem(rentables));
            }

            rentingConsolePrinter.DisplayItems(flashSale);
            rentingConsolePrinter.PrintTotalPrice(flashSale);

        }
    }
}
