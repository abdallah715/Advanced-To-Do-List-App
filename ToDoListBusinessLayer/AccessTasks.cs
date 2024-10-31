using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using ToDoListDataAccessLayer;

namespace ToDoListBusinessLayer
{
    public class clsToDoListRow
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int ID { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public int CategoryID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }

        public clsToDoListRow()
        {
            this.ID = -1;
            this.Description = "";
            this.CategoryID = -1;
            this.StartDate = DateTime.Now;
            this.EndDate = DateTime.Now.AddDays(1);
            this.Status = "Pending";
            Mode = enMode.AddNew;


        }
        static public DataTable GetAllTasks()
        {
            return clsToDoListDataAccess.GetAllTasks();
        }
        static public DataTable GetAllTasks(DateTime StartDate)
        {
            return clsToDoListDataAccess.GetAllTasks(StartDate);
        }
        static public DataTable GetAllPending()
        {
            return clsToDoListDataAccess.GetAllPendingTasks();
        }
        static public DataTable GetAllComplete()
        {
            return clsToDoListDataAccess.GetAllCompleteTasks();
        }
        static public bool DeleteTaskById(int taskId)
        {
            return clsToDoListDataAccess.DeleteTaskById(taskId);
        }
        static public bool UpdateDescription(int taskId, string newDescription)
        {
            return clsToDoListDataAccess.UpdateDescription(taskId, newDescription);
        }
        static public bool UpdateIsDone(int taskId , bool  isDone)
        {
            return clsToDoListDataAccess.UpdateIsDone(taskId, isDone);
        }
        private bool __AddNewTask()
        {
            this.ID = clsToDoListDataAccess.AddNewTask(this.Description, this.CategoryID, this.StartDate, this.EndDate, this.Status, false);
            return (this.ID != -1);
        }
        public bool Save()
        {
            switch (Mode)
            {

                case enMode.AddNew:
                    if (__AddNewTask())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


            }
            return false;
        }
    }
}
