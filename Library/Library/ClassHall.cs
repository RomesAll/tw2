using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class ClassHall : ClassConnect
    {
        static public DataTable dataTable = new DataTable();
        static public DataTable dataTableReader = new DataTable();
        static public void SelectHall()
        {
            command.CommandText = $"SELECT * FROM hall";
            dataTable.Clear();
            adapter.Fill(dataTable);
        }
        static public void SelectHallReader(string nomer)
        {
            command.CommandText = $@"
            SELECT reader_hall.idreader_hall, hall.name, reader.familia, book.name, reader_hall.data_reader
            FROM hall, reader_hall, reader, book
            WHERE hall.idhall = reader_hall.nomer_hall AND reader.idreader = reader_hall.nomer_reader 
            AND book.idbook = reader_hall.nomer_book AND reader_hall.nomer_hall = '{nomer}'";
            dataTableReader.Clear();
            adapter.Fill(dataTableReader);
        }
    }
}
