using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownListDemo.Models
{
    public class ViewModel
    {
        public int ID { get; set; }
        public IEnumerable<SelectListItem> ViewModels { get; set; }
        public ViewModel()
        {
            ViewModels = new List<SelectListItem>();
        }
    }
}