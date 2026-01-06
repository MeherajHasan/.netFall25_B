using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;

namespace DAL
{
    public class DataAccessFactoy
    {
        UMSContext db;
        public DataAccessFactoy(UMSContext db) {
            this.db = db;
        }
        public IRepository<Department> DepartmentData() { 
            return new DepartmentRepo(db);
        }
        public IDepartmentFeature DepartmentFeature() {
            return new DepartmentRepo(db);
        }
    }
}
