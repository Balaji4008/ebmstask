using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TreeView.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your contact page.";
        }
    }
    public class TreeGridItems
    {

        public TreeGridItems() { }
        public int TaskId { get; set; }
        public string CategoryName { get; set; }
        public DateTime StartDate { get; set; }
        public int Duration { get; set; }
        public List<TreeGridItems> Children { get; set; }
        public static List<object> Getlist()
        {
            List<object> listdata = new List<object>();
            listdata.Add(new
            {
                id = 1,
                name = "(Category)-Assets",
                hasChild = true,
                expanded = true
            });
            listdata.Add(new
            {
                id = 2,
                pid = 1,
                name = "(Subcategory) Current Assets",
                hasChild = true,
            });
            listdata.Add(new
            {
                id = 3,
                pid = 2,
                name = "(Group) Employee",
                hasChild = true,

            });
            listdata.Add(new
            {
                id = 4,
                pid = 3,
                name = "(SubGroup) Staff",
                hasChild = true,

            });

            listdata.Add(new
            {
                id = 5,
                pid = 4,
                name = "Ducoment Form",


            });
            listdata.Add(new
            {
                id = 3,
                pid = 1,
                name = "Victoria"
            });

            listdata.Add(new
            {
                id = 4,
                pid = 1,
                name = "South Australia"
            });
            listdata.Add(new
            {
                id = 6,
                pid = 1,
                name = "Western Australia",

            });
            listdata.Add(new
            {
                id = 7,
                name = "Brazil",
                hasChild = true
            });
            listdata.Add(new
            {
                id = 8,
                pid = 7,
                name = "Paraná"
            });
            listdata.Add(new
            {
                id = 9,
                pid = 7,
                name = "Ceará"
            });
            listdata.Add(new
            {
                id = 10,
                pid = 7,
                name = "Acre"
            });
            listdata.Add(new
            {
                id = 11,
                name = "China",
                hasChild = true
            });
            listdata.Add(new
            {
                id = 12,
                pid = 11,
                name = "Guangzhou"
            });
            listdata.Add(new
            {
                id = 13,
                pid = 11,
                name = "Shanghai"
            });
            listdata.Add(new
            {
                id = 14,
                pid = 11,
                name = "Beijing"
            });
            listdata.Add(new
            {
                id = 15,
                pid = 11,
                name = "Shantou"

            });
            listdata.Add(new
            {
                id = 16,
                name = "France",
                hasChild = true

            });
            listdata.Add(new
            {
                id = 17,
                pid = 16,
                name = "Pays de la Loire"

            });
            listdata.Add(new
            {
                id = 18,
                pid = 16,
                name = "Aquitaine"

            });
            listdata.Add(new
            {
                id = 19,
                pid = 16,
                name = "Brittany"

            });
            listdata.Add(new
            {
                id = 20,
                pid = 16,
                name = "Lorraine"
            });
            listdata.Add(new
            {
                id = 21,
                name = "India",
                hasChild = true

            });
            listdata.Add(new
            {
                id = 22,
                pid = 21,
                name = "Assam"

            });
            listdata.Add(new
            {
                id = 23,
                pid = 21,
                name = "Bihar"
            });
            listdata.Add(new
            {
                id = 24,
                pid = 21,
                name = "Tamil Nadu"

            });

            return listdata;
        }
        public static List<TreeGridItems> GetTreeData()
        {
            List<TreeGridItems> BusinessObjectCollection = new List<TreeGridItems>();

            TreeGridItems Record1 = null;

            Record1 = new TreeGridItems()
            {
                TaskId = 1,
                CategoryName = "Planning",
                StartDate = new DateTime(2016, 06, 07),
                Duration = 5,
                Children = new List<TreeGridItems>(),
            };
            TreeGridItems Child1 = new TreeGridItems()
            {
                TaskId = 2,
                CategoryName = "Plan timeline",
                StartDate = new DateTime(2016, 06, 07),
                Duration = 5,
                Children = new List<TreeGridItems>(),
            };

            TreeGridItems Child2 = new TreeGridItems()
            {
                TaskId = 3,
                CategoryName = "Plan budget",
                StartDate = new DateTime(2016, 06, 07),
                Duration = 5
            };
            TreeGridItems Child3 = new TreeGridItems()
            {
                TaskId = 4,
                CategoryName = "Allocate resources",
                StartDate = new DateTime(2016, 06, 07),
                Duration = 5
            };
            Record1.Children.Add(Child1);
            Record1.Children.Add(Child2);
            Record1.Children.Add(Child3);
            TreeGridItems Record2 = new TreeGridItems()
            {
                TaskId = 6,
                CategoryName = "Design",
                StartDate = new DateTime(2021, 08, 25),
                Duration = 3,
                Children = new List<TreeGridItems>()
            };
            TreeGridItems Child5 = new TreeGridItems()
            {
                TaskId = 7,
                CategoryName = "Software Specification",
                StartDate = new DateTime(2021, 08, 25),
                Duration = 3
            };

            TreeGridItems Child6 = new TreeGridItems()
            {
                TaskId = 8,
                CategoryName = "Develop prototype",
                StartDate = new DateTime(2021, 08, 25),
                Duration = 3
            };
            TreeGridItems Child7 = new TreeGridItems()
            {
                TaskId = 9,
                CategoryName = "Get approval from customer",
                StartDate = new DateTime(2024, 06, 27),
                Duration = 2
            };
            Record2.Children.Add(Child5);
            Record2.Children.Add(Child6);
            Record2.Children.Add(Child7);
            BusinessObjectCollection.Add(Record1);
            BusinessObjectCollection.Add(Record2);
            return BusinessObjectCollection;
        }
    }
}
