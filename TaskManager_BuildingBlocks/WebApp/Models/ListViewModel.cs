using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ListViewModel
    {
        public List<UserViewModel> allusers = new List<UserViewModel>();

        public List<PdfPrintViewModel> allmetrics = new List<PdfPrintViewModel>();
    }
}
