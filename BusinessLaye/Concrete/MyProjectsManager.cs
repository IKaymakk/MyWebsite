using BusinessLaye.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLaye.Concrete
{
    public class MyProjectsManager : IMyProjectService
    {
        IProjectsDal _iprojectsdal;

        public MyProjectsManager(IProjectsDal iprojectsdal)
        {
            _iprojectsdal = iprojectsdal;
        }

        public void AddProject(MyProjects project)
        {
            _iprojectsdal.Add(project);
        }

        public void DeleteProject(MyProjects project)
        {
            _iprojectsdal.Remove(project);
        }

        public MyProjects GetProject(int id)
        {
            return _iprojectsdal.Get(x=>x.ProjectID==id);
        }

        public List<MyProjects> ProjectList()
        {
            return _iprojectsdal.List();
        }

        public void UpdateProject(MyProjects project)
        {
            _iprojectsdal.Update(project);
        }
    }
}
