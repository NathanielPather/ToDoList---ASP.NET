using System;
using System.Collections.Generic;
using System.Linq;
using ToDoList.Models;
using Dapper;
using ToDoList.Helpers;
using System.ComponentModel.Design;

namespace ToDoList.ViewModels
{
    public class ToDoListViewModel
    {
        public ToDoListViewModel()
        {
            using(var db = DbHelper.GetConnection())
            {
                this.EditableItem = new ToDoListItem();
                this.ToDoItems = db.Query<ToDoListItem>("SELECT * FROM ToDoListItems ORDER BY AddDate DESC").ToList();
            }
        }

        public List<ToDoListItem> ToDoItems { get; set; }

        public ToDoListItem EditableItem { get; set; }
    }
}
