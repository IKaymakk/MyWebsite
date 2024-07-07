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
    public class MySkillsManager : IMySkillsService
    {
        ISkillsDal _iskillsdal;

        public MySkillsManager(ISkillsDal iskillsdal)
        {
            _iskillsdal = iskillsdal;
        }

        public void AddSkill(MySkills skill)
        {
            _iskillsdal.Add(skill);
        }

        public void DeleteSkill(MySkills skill)
        {
            _iskillsdal.Remove(skill);
        }

        public List<MySkills> SkillsList()
        {
            return _iskillsdal.List();
        }

        public void UpdateSkill(MySkills skill)
        {
            _iskillsdal.Update(skill);
        }
    }
}
