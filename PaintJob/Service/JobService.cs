using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using PaintJob.Database;

namespace PaintJob.Model
{
    public class JobService
    {
        PaintJobDbEntities ObjContext;
        public JobService()
        {
            ObjContext = new PaintJobDbEntities();
        }

        #region GetAll/Read
        public List<JobDTO> GetAll()
        {
            List<JobDTO> ObjJobsList = new List<JobDTO>();
            try
            {
                var ObjQuery = from obj in ObjContext.Jobs
                               select obj;
                foreach (var job in ObjQuery)
                {
                    ObjJobsList.Add(new JobDTO { 
                        
                        // Basic info

                        Id = job.Id,
                        Worker = job.Worker,
                        MachineName = job.MachineName,
                        Construction = job.Construction,
                        Element = job.Element,
                        PaintJobDate = job.PaintJobDate,
                        ColorCode = job.ColorCode,
                        Preparation = job.Preparation,

                        // Preparation

                        CleanConstruction = job.CleanConstruction,
                        CleanElements = job.CleanElements,
                        ColorQuantity = job.ColorQuantity,
                        ThinnerQuantity = job.ThinnerQuantity,
                        HardenerQuantity = job.HardenerQuantity,
                        MixQuantity = job.MixQuantity,
                        PrefilterM3 = job.PrefilterM3,
                        FilterM3 = job.FilterM3,

                        // Technical details

                        AirPressure = job.AirPressure,
                        WaterInSystem = job.WaterInSystem,
                        GunColorPressure = job.GunColorPressure,
                        GunAirPressure = job.GunAirPressure,
                        GunAngle = job.GunAngle,
                        Temperature = job.Temperature,
                        Wind = job.Wind,
                        OutsideJob = job.OutsideJob,

                        // Other information

                        Ratio = job.Ratio,
                        WorkHours = job.WorkHours,
                        UsedMixQuantity = job.UsedMixQuantity,
                        WastedMixQuantity = job.WastedMixQuantity,
                        CleanGunQuantity = job.CleanGunQuantity,
                        GrainEffect = job.GrainEffect,
                        ColorRepair = job.ColorRepair,
                        Comment = job.Comment
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ObjJobsList;
        }

        #endregion

        #region Add/Insert

        public bool Add(JobDTO objNewJob)
        {
            bool IsAdded = false;
            //Construction must be between 0 and 2
            if (objNewJob.Construction < 0 || objNewJob.Construction > 2)
                throw new ArgumentException("Invalid construction limit for job");

            try
            {
                var ObjJob = new Job();

                // Basic info

                ObjJob.Id = objNewJob.Id;
                ObjJob.Worker = objNewJob.Worker;
                ObjJob.MachineName = objNewJob.MachineName;
                ObjJob.Construction = objNewJob.Construction;
                ObjJob.Element = objNewJob.Element;
                ObjJob.PaintJobDate = objNewJob.PaintJobDate;
                ObjJob.ColorCode = objNewJob.ColorCode;
                ObjJob.Preparation = objNewJob.Preparation;

                // Preparation

                ObjJob.CleanConstruction = objNewJob.CleanConstruction;
                ObjJob.CleanElements = objNewJob.CleanElements;
                ObjJob.ColorQuantity = objNewJob.ColorQuantity;
                ObjJob.ThinnerQuantity = objNewJob.ThinnerQuantity;
                ObjJob.HardenerQuantity = objNewJob.HardenerQuantity;
                ObjJob.MixQuantity = objNewJob.MixQuantity;
                ObjJob.PrefilterM3 = objNewJob.PrefilterM3;
                ObjJob.FilterM3 = objNewJob.FilterM3;

                // Technical details

                ObjJob.AirPressure = objNewJob.AirPressure;
                ObjJob.WaterInSystem = objNewJob.WaterInSystem;
                ObjJob.GunColorPressure = objNewJob.GunColorPressure;
                ObjJob.GunAirPressure = objNewJob.GunAirPressure;
                ObjJob.GunAngle = objNewJob.GunAngle;
                ObjJob.Temperature = objNewJob.Temperature;
                ObjJob.Wind = objNewJob.Wind;
                ObjJob.OutsideJob = objNewJob.OutsideJob;

                // Other information

                ObjJob.Ratio = objNewJob.Ratio;
                ObjJob.WorkHours = objNewJob.WorkHours;
                ObjJob.UsedMixQuantity = objNewJob.UsedMixQuantity;
                ObjJob.WastedMixQuantity = objNewJob.WastedMixQuantity;
                ObjJob.CleanGunQuantity = objNewJob.CleanGunQuantity;
                ObjJob.GrainEffect = objNewJob.GrainEffect;
                ObjJob.ColorRepair = objNewJob.ColorRepair;
                ObjJob.Comment = objNewJob.Comment;

                ObjContext.Jobs.Add(ObjJob);
                var NoOfRowsAffected = ObjContext.SaveChanges();
                IsAdded = NoOfRowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return IsAdded;
        }

        #endregion

        #region Update

        public bool Update(JobDTO objJobToUpdate)
        {
            bool IsUpdated = false;

            try
            {

                // Basic info

                var ObjJob = ObjContext.Jobs.Find(objJobToUpdate.Id);
                ObjJob.Worker = objJobToUpdate.Worker;
                ObjJob.MachineName = objJobToUpdate.MachineName;
                ObjJob.Construction = objJobToUpdate.Construction;
                ObjJob.Element = objJobToUpdate.Element;
                ObjJob.PaintJobDate = objJobToUpdate.PaintJobDate;
                ObjJob.ColorCode = objJobToUpdate.ColorCode;
                ObjJob.Preparation = objJobToUpdate.Preparation;

                // Preparation

                ObjJob.CleanConstruction = objJobToUpdate.CleanConstruction;
                ObjJob.CleanElements = objJobToUpdate.CleanElements;
                ObjJob.ColorQuantity = objJobToUpdate.ColorQuantity;
                ObjJob.ThinnerQuantity = objJobToUpdate.ThinnerQuantity;
                ObjJob.HardenerQuantity = objJobToUpdate.HardenerQuantity;
                ObjJob.MixQuantity = objJobToUpdate.MixQuantity;
                ObjJob.PrefilterM3 = objJobToUpdate.PrefilterM3;
                ObjJob.FilterM3 = objJobToUpdate.FilterM3;

                // Technical details

                ObjJob.AirPressure = objJobToUpdate.AirPressure;
                ObjJob.WaterInSystem = objJobToUpdate.WaterInSystem;
                ObjJob.GunColorPressure = objJobToUpdate.GunColorPressure;
                ObjJob.GunAirPressure = objJobToUpdate.GunAirPressure;
                ObjJob.GunAngle = objJobToUpdate.GunAngle;
                ObjJob.Temperature = objJobToUpdate.Temperature;
                ObjJob.Wind = objJobToUpdate.Wind;
                ObjJob.OutsideJob = objJobToUpdate.OutsideJob;

                // Other information

                ObjJob.Ratio = objJobToUpdate.Ratio;
                ObjJob.WorkHours = objJobToUpdate.WorkHours;
                ObjJob.UsedMixQuantity = objJobToUpdate.UsedMixQuantity;
                ObjJob.WastedMixQuantity = objJobToUpdate.WastedMixQuantity;
                ObjJob.CleanGunQuantity = objJobToUpdate.CleanGunQuantity;
                ObjJob.GrainEffect = objJobToUpdate.GrainEffect;
                ObjJob.ColorRepair = objJobToUpdate.ColorRepair;
                ObjJob.Comment = objJobToUpdate.Comment;

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
                var ObjJobToDelete = ObjContext.Jobs.Find(id);
                ObjContext.Jobs.Remove(ObjJobToDelete);
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
        public JobDTO Search(int id)
        {
            JobDTO ObjJob = null;

            try
            {
                var ObjJobToFind = ObjContext.Jobs.Find(id);
                if (ObjJobToFind != null)
                {
                    ObjJob = new JobDTO()
                    {

                        // Basic info

                        Id = ObjJobToFind.Id,
                        Worker = ObjJobToFind.Worker,
                        MachineName = ObjJobToFind.MachineName,
                        Construction = ObjJobToFind.Construction,
                        Element = ObjJobToFind.Element,
                        PaintJobDate = ObjJobToFind.PaintJobDate,
                        ColorCode = ObjJobToFind.ColorCode,
                        Preparation = ObjJobToFind.Preparation,

                        // Preparation

                        CleanConstruction = ObjJobToFind.CleanConstruction,
                        CleanElements = ObjJobToFind.CleanElements,
                        ColorQuantity = ObjJobToFind.ColorQuantity,
                        ThinnerQuantity = ObjJobToFind.ThinnerQuantity,
                        HardenerQuantity = ObjJobToFind.HardenerQuantity,
                        MixQuantity = ObjJobToFind.MixQuantity,
                        PrefilterM3 = ObjJobToFind.PrefilterM3,
                        FilterM3 = ObjJobToFind.FilterM3,

                        // Technical details

                        AirPressure = ObjJobToFind.AirPressure,
                        WaterInSystem = ObjJobToFind.WaterInSystem,
                        GunColorPressure = ObjJobToFind.GunColorPressure,
                        GunAirPressure = ObjJobToFind.GunAirPressure,
                        GunAngle = ObjJobToFind.GunAngle,
                        Temperature = ObjJobToFind.Temperature,
                        Wind = ObjJobToFind.Wind,
                        OutsideJob = ObjJobToFind.OutsideJob,

                        // Other information

                        Ratio = ObjJobToFind.Ratio,
                        WorkHours = ObjJobToFind.WorkHours,
                        UsedMixQuantity = ObjJobToFind.UsedMixQuantity,
                        WastedMixQuantity = ObjJobToFind.WastedMixQuantity,
                        CleanGunQuantity = ObjJobToFind.CleanGunQuantity,
                        GrainEffect = ObjJobToFind.GrainEffect,
                        ColorRepair = ObjJobToFind.ColorRepair,
                        Comment = ObjJobToFind.Comment
                    };

                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ObjJob;
        }

        #endregion
    }
}


