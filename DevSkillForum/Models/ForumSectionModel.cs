using DevSkillForum.BLL;
using DevSkillForum.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevSkillForum.Models
{
    public class ForumSectionModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

        internal void Save()
        {
            ForumSection section = new ForumSection();
            section.ID = ID;
            section.Name = Name;
            section.DisplayOrder = DisplayOrder;

            ForumSectionRepository repository = new ForumSectionRepository();
            repository.Add(section);
        }
    }
}