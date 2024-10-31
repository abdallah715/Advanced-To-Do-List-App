using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListDataAccessLayer;

namespace ToDoListBusinessLayer
{
    public class clsCategories
    {
        public int id {  get; set; }
        public string Categoryname { get; set; }

        public clsCategories() 
        {
            this.id = -1;
            this.Categoryname = "";
        }
        static public DataTable GetAllCategories()
        {
            return clsToDoListDataAccess.GetAllCategories();
        }
        public bool AddNewCategory(string categoryName)
        {
            return clsToDoListDataAccess.AddNewCategory(categoryName);
        }
        static public bool DeleteCategory(string categoryName)
        {
            return clsToDoListDataAccess.DeleteCategory(categoryName) ;
        }
    }
}
