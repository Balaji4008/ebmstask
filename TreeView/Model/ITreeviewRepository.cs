using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreeView.Model
{
    public interface ITreeviewRepository
    {
        List<TreeviewModel> GetList();
    }
}
