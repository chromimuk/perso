﻿using MarconnetDotFr_MVC.Models.DAO;

namespace MarconnetDotFr_MVC.Models.Entities
{
    public class ResumeItemModel
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public string Location { get; set; }
        public string ShortLocation { get; set; }
        public string Description { get; set; }
        public string Tech { get; set; }

        public ResumeItemModel()
        {
        }

        public ResumeItemModel(IResumeItemModelDAO dao)
        {
            Image = dao.GetImage();
            Title = dao.GetTitle();
            ShortTitle = dao.GetShortTitle();
            Location = dao.GetLocation();
            ShortLocation = dao.GetShortLocation();
            Description = dao.GetDescription();
            Tech = dao.GetTech();
        }
    }
}