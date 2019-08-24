using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TreeView.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your application description page.";
        }
    }
    public class loadOnDemand
    {
        public int id { get; set; }
        public int? parentId { get; set; }
        public string name { get; set; }
        public bool? hasChild { get; set; }
        public bool? expanded { get; set; }
        public bool? ischecked { get; set; }
        public bool? selected { get; set; }
        public string spriteCss { get; set; }
        public static List<loadOnDemand> GetloadOnDemand()
        {
            List<loadOnDemand> data = new List<loadOnDemand>();
            data.Add(new loadOnDemand { id = 1, name = "Local Disk(C:)", hasChild = true });
            data.Add(new loadOnDemand { id = 2, name = "Local Disk(D:)", hasChild = true });
            data.Add(new loadOnDemand { id = 3, name = "Local Disk(E:)", hasChild = true });
            data.Add(new loadOnDemand { id = 4, parentId = 1, name = "Folder 1", hasChild = true });
            data.Add(new loadOnDemand { id = 5, parentId = 1, name = "Folder 2" });
            data.Add(new loadOnDemand { id = 6, parentId = 1, name = "Folder 3" });
            data.Add(new loadOnDemand { id = 7, parentId = 2, name = "Folder 4" });
            data.Add(new loadOnDemand { id = 8, parentId = 2, name = "Folder 5", hasChild = true });
            data.Add(new loadOnDemand { id = 9, parentId = 2, name = "Folder 6" });
            data.Add(new loadOnDemand { id = 10, parentId = 3, name = "Folder 7" });
            data.Add(new loadOnDemand { id = 11, parentId = 3, name = "Folder 8" });
            data.Add(new loadOnDemand { id = 12, parentId = 3, name = "Folder 9", hasChild = true });
            data.Add(new loadOnDemand { id = 13, parentId = 4, name = "File 1" });
            data.Add(new loadOnDemand { id = 14, parentId = 4, name = "File 2" });
            data.Add(new loadOnDemand { id = 15, parentId = 4, name = "File 3" });
            data.Add(new loadOnDemand { id = 16, parentId = 8, name = "File 4" });
            data.Add(new loadOnDemand { id = 17, parentId = 8, name = "File 5" });
            data.Add(new loadOnDemand { id = 18, parentId = 8, name = "File 6" });
            data.Add(new loadOnDemand { id = 19, parentId = 12, name = "File 7" });
            data.Add(new loadOnDemand { id = 20, parentId = 12, name = "File 8" });
            data.Add(new loadOnDemand { id = 21, parentId = 12, name = "File 9" });
            return data;
        }

    }
}
