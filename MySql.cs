using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDate
{
    internal class MySql
    {
        Table table = new Table();
        public string determineCommand(string command)
        {
            if (command.StartsWith("ADD"))
            {
                command = command.Substring(command.IndexOf('(') + 1, command.Length - 6);
                string[] masCommands = command.Split(',');
                table.addLine(uint.Parse(masCommands[0]), masCommands[1],double.Parse(masCommands[2]), uint.Parse(masCommands[3]));
                return "Строка добавлена";
            }
            if ((command.StartsWith("SELECT")))
                return table.getTable();

            return "Ошибка в ключевом слове.";

        }

    }
}
