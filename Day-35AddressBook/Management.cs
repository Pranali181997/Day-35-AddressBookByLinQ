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
            DataColumn column;
            DataRow Row;
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "FirstName";
            BookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "LastName";
            BookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Address";
            BookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "City";
            BookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "State";
            BookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "PhoneNumber";
            BookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Zip";
            BookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Email";
            BookTable.Columns.Add(column);

            // Make the first name and mobile no column the primary key column
            DataColumn[] PrimaryKeyColumns = new DataColumn[2];
            PrimaryKeyColumns[0] = BookTable.Columns["FirstName"];
            PrimaryKeyColumns[1] = BookTable.Columns["PhoneNumber"];
            BookTable.PrimaryKey = PrimaryKeyColumns;
        }
    }
}
