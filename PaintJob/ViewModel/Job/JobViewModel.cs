using System;
using System.ComponentModel;
using PaintJob.Model;
using PaintJob.Commands;
using System.Collections.ObjectModel;

namespace PaintJob.ViewModel.Job
{
    public class JobViewModel : INotifyPropertyChanged
    {

        #region INotiyfPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        JobService ObjJobService;
        public JobViewModel()
        {
            ObjJobService = new JobService();
            LoadData();
            CurrentJob = new JobDTO();
            saveCommand = new RelayCommand(Save);
            searchCommand = new RelayCommand(Search);
            updateCommand = new RelayCommand(Update);
            deleteCommand = new RelayCommand(Delete);
        }

        #region Properties

        private JobDTO currentJob;

        public JobDTO CurrentJob
        {
            get { return currentJob; }
            set { currentJob = value; OnPropertyChanged("CurrentJob"); }
        }

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }

        #endregion

        #region Display Operation
        private ObservableCollection<JobDTO> jobsList;

        public ObservableCollection<JobDTO> JobsList
        {
            get { return jobsList; }
            set { jobsList = value; OnPropertyChanged("JobsList"); }
        }
        private void LoadData()
        {
            JobsList = new ObservableCollection<JobDTO>(ObjJobService.GetAll());
        }

        #endregion

        #region SaveOperation

        private RelayCommand saveCommand;

        public RelayCommand SaveCommand
        {
            get { return saveCommand; }
        }

        public void Save()
        {
            try
            {
                var IsSaved = ObjJobService.Add(CurrentJob);
                LoadData();
                if (IsSaved)
                    Message = "Job saved";
                else
                    Message = "Save operation failed";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }

        #endregion

        #region SearchOperation

        private RelayCommand searchCommand;

        public RelayCommand SearchCommand
        {
            get { return searchCommand; }
        }

        public void Search()
        {
            try
            {
                var ObjJob = ObjJobService.Search(CurrentJob.Id);

                if (ObjJob != null)
                {

                    // Basic info

                    CurrentJob.Id = ObjJob.Id;
                    CurrentJob.Worker = ObjJob.Worker;
                    CurrentJob.MachineName = ObjJob.MachineName;
                    CurrentJob.Construction = ObjJob.Construction;
                    CurrentJob.Element = ObjJob.Element;
                    CurrentJob.PaintJobDate = ObjJob.PaintJobDate;
                    CurrentJob.ColorCode = ObjJob.ColorCode;
                    CurrentJob.Preparation = ObjJob.Preparation;

                    // Preparation

                    CurrentJob.CleanConstruction = ObjJob.CleanConstruction;
                    CurrentJob.CleanElements = ObjJob.CleanElements;
                    CurrentJob.ColorQuantity = ObjJob.ColorQuantity;
                    CurrentJob.ThinnerQuantity = ObjJob.ThinnerQuantity;
                    CurrentJob.HardenerQuantity = ObjJob.HardenerQuantity;
                    CurrentJob.MixQuantity = ObjJob.MixQuantity;
                    CurrentJob.PrefilterM3 = ObjJob.PrefilterM3;
                    CurrentJob.FilterM3 = ObjJob.FilterM3;

                    // Technical details

                    CurrentJob.AirPressure = ObjJob.AirPressure;
                    CurrentJob.WaterInSystem = ObjJob.WaterInSystem;
                    CurrentJob.GunColorPressure = ObjJob.GunColorPressure;
                    CurrentJob.GunAirPressure = ObjJob.GunAirPressure;
                    CurrentJob.GunAngle = ObjJob.GunAngle;
                    CurrentJob.Temperature = ObjJob.Temperature;
                    CurrentJob.Wind = ObjJob.Wind;
                    CurrentJob.OutsideJob = ObjJob.OutsideJob;

                    // Other information

                    CurrentJob.Ratio = ObjJob.Ratio;
                    CurrentJob.WorkHours = ObjJob.WorkHours;
                    CurrentJob.UsedMixQuantity = ObjJob.UsedMixQuantity;
                    CurrentJob.WastedMixQuantity = ObjJob.WastedMixQuantity;
                    CurrentJob.CleanGunQuantity = ObjJob.CleanGunQuantity;
                    CurrentJob.GrainEffect = ObjJob.GrainEffect;
                    CurrentJob.ColorRepair = ObjJob.ColorRepair;
                    CurrentJob.Comment = ObjJob.Comment;

                }
                else
                {
                    Message = "Job not found";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }

        #endregion

        #region UpdateOperation

        private RelayCommand updateCommand;

        public RelayCommand UpdateCommand
        {
            get { return updateCommand; }
        }

        public void Update()
        {
            try
            {
                var IsUpdated = ObjJobService.Update(CurrentJob);

                if (IsUpdated)
                {
                    Message = "Job Updated";
                    LoadData();
                }
                else
                {
                    Message = "Update operation failed";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }

        #endregion

        #region DeleteOperation

        private RelayCommand deleteCommand;

        public RelayCommand DeleteCommand
        {
            get { return deleteCommand; }
        }

        public void Delete()
        {
            try
            {
                var IsDelete = ObjJobService.Delete(CurrentJob.Id);

                if (IsDelete)
                {
                    Message = "Job deleted";
                    LoadData();
                }
                else
                {
                    Message = "Delete operation failed";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }

        #endregion

    }
}
