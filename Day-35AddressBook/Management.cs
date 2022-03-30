using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Day_35AddressBook
{
    public class Management
    {
        //UC-1-Create datatable 
        public static DataTable BookTable = new DataTable();
        public static void AddTable()
        {

            //UC-2-Insert The columns
            BookTable.Columns.Add("FirstName", typeof(string));
            BookTable.Columns.Add("LastName", typeof(string));
            BookTable.Columns.Add("Address", typeof(string));
            BookTable.Columns.Add("City", typeof(string));
            BookTable.Columns.Add("State", typeof(string));
            BookTable.Columns.Add("Zip", typeof(string));
            BookTable.Columns.Add("PhoneNumber", typeof(string));
            BookTable.Columns.Add(" Email", typeof(string));

            Console.WriteLine("\nDataTable contents:");
            foreach (var v in BookTable.AsEnumerable())
            {
                Console.WriteLine($"ProductID:{v.Field<string>("FirstName")}\tUserID:{v.Field<string>("LastName")}\tRating:{v.Field<string>("Address")}\tReview:{v.Field<string>("City")}\tIsLike:{v.Field<string>("State")}");

            }

        }
    }
}
