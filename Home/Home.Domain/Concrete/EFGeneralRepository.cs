using Home.Domain.Entities;
using System.Collections.Generic;
using Home.Domain.Abstract;

namespace Home.Domain.Concrete
{
    public class EFGeneralRepository : IGeneralRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<General> Generals
        {
            get { return context.Generals; }
        }

        public void Save(General general)
        {
            if (general.ModuleId == 0)
                context.Generals.Add(general);
            else
            {
                General dbEntry = context.Generals.Find(general.ModuleId);
                if (dbEntry != null)
                {
                    dbEntry.Name = general.Name;
                    dbEntry.DescriptionHeader = general.DescriptionHeader;
                    dbEntry.DescriptionBody = general.DescriptionBody;
                    dbEntry.Category = general.Category;
                    dbEntry.Img1 = general.Img1;
                    dbEntry.Img2 = general.Img2;
                    dbEntry.Img3 = general.Img3;
                    dbEntry.Img4 = general.Img4;
                    dbEntry.Img5 = general.Img5;
                    dbEntry.Img6 = general.Img6;
                    dbEntry.video = general.video;
                    dbEntry.Data = general.Data;
                }
            }
            context.SaveChanges();
        }

        public General Delete(int moduleId)
        {
            General dbEntry = context.Generals.Find(moduleId);
            if(dbEntry != null)
            {
                context.Generals.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
