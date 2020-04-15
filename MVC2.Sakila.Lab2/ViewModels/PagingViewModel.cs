using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC2.Sakila.Lab2.ViewModels
{
    public class PagingViewModel
    {
        public int CurrentPage { get; set; }
        public int MaxPages { get; set; }

        public string pageSize { get; set; }

        public bool ShowPrevButton
        {
            get { return CurrentPage > 1; }
        }
        public bool ShowNextButton
        {
            get { return CurrentPage < MaxPages; }
        }
    }
}
