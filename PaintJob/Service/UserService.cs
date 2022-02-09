using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using PaintJob.Database;

namespace PaintJob.Model
{
    public class UserService
    {
        PaintJobDbEntities ObjContext;
        public UserService()
        {
            ObjContext = new PaintJobDbEntities();
        }

        #region GetAll/Read
        public List<UserDTO> GetAll()
        {
            List<UserDTO> ObjUsersList = new List<UserDTO>();
            try
            {
                var ObjQuery = from obj in ObjContext.Users
                               select obj;
                foreach (var user in ObjQuery)
                {
                    ObjUsersList.Add(new UserDTO { 
                        
                        // User

                        Id = user.Id,
                        Username = user.Username,
                        Password = user.Password,
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ObjUsersList;
        }

        #endregion

        #region Update

        public bool Update(UserDTO objUserToUpdate)
        {
            bool IsUpdated = false;

            try
            {

                // Basic info

                var ObjUser = ObjContext.Users.Find(objUserToUpdate.Id);
                ObjUser.Username = objUserToUpdate.Username;
                ObjUser.Password = objUserToUpdate.Password;

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
                var ObjUserToDelete = ObjContext.Users.Find(id);
                ObjContext.Users.Remove(ObjUserToDelete);
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
        public UserDTO Search(int id)
        {
            UserDTO ObjUser = null;

            try
            {
                var ObjUserToFind = ObjContext.Users.Find(id);
                if (ObjUserToFind != null)
                {
                    ObjUser = new UserDTO()
                    {

                        // Basic info

                        Id = ObjUserToFind.Id,
                        Username = ObjUserToFind.Username,
                        Password = ObjUserToFind.Password,

                    };

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ObjUser;
        }

        #endregion

    }
}


