using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDate
{
    internal class Table
    {
        Product[] table;
        public Table()
        {
            table = new Product[2];
        }

        public string addLine(uint inventNumber, string name, double price, uint countProductInStock)
        {
            if (Product.getNumberOfLines() == table.Length) increaseArray();

            table[Product.getNumberOfLines()] = new Product(inventNumber, name, price, countProductInStock);
            return "Успешно добавлено";
        }

        public string getTable()
        {
            string tableToString = "id\tНазвание\tИнв.номер\tцена\tКол-во на складе\n";
            for(int row = 0; row < Product.getNumberOfLines(); row++)
            {
                tableToString += table[row]+"\n";
            }
            return tableToString;
        }

        void increaseArray()
        {
            Product[] table2 = new Product[table.Length];
            table.CopyTo(table2, 0);
            table = new Product[table2.Length * 2];
            for (int i = 0; i < table2.Length; i++)
            {
                table[i] = table2[i];
            }

        }

    }
}
