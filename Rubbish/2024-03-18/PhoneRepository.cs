using ArtFusionStudio.DataAccess.Data;
using ArtFusionStudio.DataAccess.Repository.IRepository;
using ArtFusionStudio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArtFusionStudio.DataAccess.Repository
{
    public class PhoneRepository : Repository<Phone>, IPhoneRepository
    {

        private ApplicationDbContext _db;
        public PhoneRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Phone obj)
        {
            _db.Phones.Update(obj);
        }
    }
}
