using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class ClassBook : ClassConnect
    {
        static public DataTable dataTable = new DataTable();
        static public DataTable dataTableAvtor = new DataTable();
        static public DataTable dataTableClient = new DataTable();
        static public void SelectBook()
        {
            command.CommandText = $@"
            SELECT book.idbook, book.name, book.izdatelstvo, book.year_izdatel, book.chifr, SUM(kolvobook.kolvo) AS kol 
            FROM book, kolvobook WHERE book.idbook = kolvobook.nomer_book GROUP BY book.name";
            dataTable.Clear();
            adapter.Fill(dataTable);
        }
        static public void SelectBookAvtor(string nomer)
        {
            command.CommandText = $@"
            SELECT sp_avtor.avtor
            FROM sp_avtor, book, avtorbook
            WHERE avtorbook.nomer_book = book.idbook AND sp_avtor.idsp_avtor = avtorbook.nomer_avtor AND book.idbook = '{nomer}'";
            dataTableAvtor.Clear();
            adapter.Fill(dataTableAvtor);
        }
        static public void FiltrBookShifr(string name)
        {
            command.CommandText = $@"
            SELECT book.idbook, book.name, book.izdatelstvo, book.year_izdatel, book.chifr, SUM(kolvobook.kolvo) AS kol 
            FROM book, kolvobook 
            WHERE book.idbook = kolvobook.nomer_book AND book.chifr LIKE '%{name}%' GROUP BY book.name";
            dataTable.Clear();
            adapter.Fill(dataTable);
        }
        static public void FiltrBookName(string name)
        {
            command.CommandText = $@"
            SELECT book.idbook, book.name, book.izdatelstvo, book.year_izdatel, book.chifr, SUM(kolvobook.kolvo) AS kol 
            FROM book, kolvobook 
            WHERE book.idbook = kolvobook.nomer_book AND book.name LIKE '%{name}%' GROUP BY book.name";
            dataTable.Clear();
            adapter.Fill(dataTable);
        }
        static public void SelectClient()
        {
            command.CommandText = $@"SELECT idreader, familia FROM reader";
            dataTableClient.Clear();
            adapter.Fill(dataTableClient);
        }
        static public void SelectBookClient(string reader)
        {
            command.CommandText = $@"
            SELECT book.idbook, book.`name`, book.izdatelstvo, book.year_izdatel, book.chifr, COUNT(reader_hall.nomer_book) AS kol
            FROM book, reader_hall, reader, hall
            WHERE reader.idreader = reader_hall.nomer_reader
            AND hall.idhall = reader_hall.nomer_hall
            AND book.idbook = reader_hall.nomer_book
            AND reader_hall.nomer_reader = '{reader}'";
            dataTable.Clear();
            adapter.Fill(dataTable);
        }
    }
}
