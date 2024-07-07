using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLaye.Abstract
{
    public interface IMySkillsService
    {
        List<MySkills> SkillsList();
        void AddSkill(MySkills skill);
        void DeleteSkill(MySkills skill);
        void UpdateSkill(MySkills skill);
    }
}
