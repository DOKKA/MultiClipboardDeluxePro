using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiClipboardDeluxePro.Data
{
     public class ClipService
    {
        private DBContext db;

        public ClipService(DBContext aa)
        {
            db = aa;
        }



        public string[][] GetList()
        {
            return db.Clips.Select(c => new { ID = c.ID, Title = c.Title, Timestamp = c.Timestamp, Type = c.Type })
                .ToArray().Select(c => new string[] { c.ID.ToString(), c.Title, c.Timestamp.ToString("G"), c.Type }).ToArray();
        }

        public void Create(Clip clip)
        {
            db.Clips.Add(clip);
            db.SaveChanges();
        }

        public Clip Get(long id)
        {
            return db.Clips.Find(id);
        }

        public void Delete(long id)
        {
            var clip = db.Clips.Find(id);
            db.Clips.Remove(clip);
            db.SaveChanges();
        }

        public void UpdateTitle(long id, string Title)
        {
            var clip = db.Clips.Find(id);
            clip.Title = Title;
            db.SaveChanges();
        }

        public void UpdateType(long id, string Type)
        {
            var clip = db.Clips.Find(id);
            clip.Type = Type;
            db.SaveChanges();
        }

        public void UpdateData(long id, string Data)
        {
            var clip = db.Clips.Find(id);
            clip.Data = Data;
            db.SaveChanges();
        }

    }

}
