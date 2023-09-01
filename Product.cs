using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDate
{
    internal class Product
    {
        static uint numberOfLines = 0;
        uint id;
        uint inventNumber;
        string name;
        double price;
        uint countProductInStock;

        public Product(uint inventNumber, string name, double price, uint countProductInStock)
        {
            checkCorrectnessData(inventNumber, price);
            numberOfLines++;
            id = numberOfLines;
            this.inventNumber = inventNumber;
            this.name = name;
            this.price = price;
            this.countProductInStock = countProductInStock;
        }

        void checkCorrectnessData(uint inventNumber, double price)
        {
            if (inventNumber < 100000 || inventNumber > 1000000)
                throw new Exception("Ошибка корректности данных");

            if (price < 0)
                throw new Exception("Ошибка корректности данных");
        }

        public static uint getNumberOfLines()
        {
            return numberOfLines;
        }
        public override string ToString()
        {
            return id +"\t"+name+"\t\t" +inventNumber+ "\t\t" + price+ "\t\t" + countProductInStock+"\n";
        }

    }
}
