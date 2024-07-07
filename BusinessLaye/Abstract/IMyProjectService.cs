using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLaye.Abstract
{
    public interface IMyProjectService
    {
        List<MyProjects> ProjectList();
        void AddProject (MyProjects project);
        void UpdateProject (MyProjects project);
        void DeleteProject (MyProjects project);
        MyProjects GetProject(int id);
    }
}
