using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TreeView.Model;

namespace TreeView.Pages
{
    public class IndexModel : PageModel
    {
        public  static ITreeviewRepository _treeviewrepository;
        public IndexModel(ITreeviewRepository treeviewrepository)
        {
            _treeviewrepository = treeviewrepository;
        }
        public static List<TreeviewModel> Getlistdata()
        {
      
            return _treeviewrepository.GetList(); 
        }
        public async Task OnGetAsync()
        {

        }

    }

    

   
    }

