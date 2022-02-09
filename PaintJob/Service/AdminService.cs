using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using PaintJob.Database;

namespace PaintJob.Model
{
    public class AdminService
    {
        PaintJobDbEntities ObjContext;
        public AdminService()
        {
            ObjContext = new PaintJobDbEntities();
        }

        #region GetAll/Read
        public List<AdminDTO> GetAll()
        {
            List<AdminDTO> ObjAdminsList = new List<AdminDTO>();
            try
            {
                var ObjQuery = from obj in ObjContext.Admins
                               select obj;
                foreach (var admin in ObjQuery)
                {
                    ObjAdminsList.Add(new AdminDTO { 
                        
                        // Admin

                        Id = admin.Id,
                        Administrator = admin.Administrator,
                        Password = admin.Password,
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ObjAdminsList;
        }

        #endregion

        #region Update

        public bool Update(AdminDTO objAdminToUpdate)
        {
            bool IsUpdated = false;

            try
            {

                // Basic info

                var ObjAdmin = ObjContext.Admins.Find(objAdminToUpdate.Id);
                ObjAdmin.Administrator = objAdminToUpdate.Administrator;
                ObjAdmin.Password = objAdminToUpdate.Password;

                var NoOfRowsAffected = ObjContext.SaveChanges();
                IsUpdated = NoOfRowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return IsUpdated;
        }

        #endregion

        #region Delete

        public bool Delete(int id)
        {
            bool IsDeleted = false;
            try
            {
                var ObjAdminToDelete = ObjContext.Admins.Find(id);
                ObjContext.Admins.Remove(ObjAdminToDelete);
                var NoOfRowsAffected = ObjContext.SaveChanges();
                IsDeleted = NoOfRowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return IsDeleted;
        }

        #endregion

        #region Search
        public AdminDTO Search(int id)
        {
            AdminDTO ObjAdmin = null;

            try
            {
                var ObjAdminToFind = ObjContext.Admins.Find(id);
                if (ObjAdminToFind != null)
                {
                    ObjAdmin = new AdminDTO()
                    {

                        // Basic info

                        Id = ObjAdminToFind.Id,
                        Administrator = ObjAdminToFind.Administrator,
                        Password = ObjAdminToFind.Password,

                    };

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ObjAdmin;
        }

        #endregion

    }
}


