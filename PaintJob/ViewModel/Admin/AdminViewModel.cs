using PaintJob.Commands;
using PaintJob.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintJob.ViewModel.Admin
{
    public class AdminViewModel : INotifyPropertyChanged
    {

        #region INotiyfPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        AdminService ObjAdminService;
        public AdminViewModel()
        {
            ObjAdminService = new AdminService();
            LoadData();
            CurrentAdmin = new AdminDTO();
            searchCommand = new RelayCommand(Search);
            updateCommand = new RelayCommand(Update);
            deleteCommand = new RelayCommand(Delete);
        }

        #region Properties

        private AdminDTO currentAdmin;

        public AdminDTO CurrentAdmin
        {
            get { return currentAdmin; }
            set { currentAdmin = value; OnPropertyChanged("CurrentAdmin"); }
        }

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }

        #endregion

        #region Display Operation
        private ObservableCollection<AdminDTO> adminsList;

        public ObservableCollection<AdminDTO> AdminsList
        {
            get { return adminsList; }
            set { adminsList = value; OnPropertyChanged("AdminsList"); }
        }
        private void LoadData()
        {
            AdminsList = new ObservableCollection<AdminDTO>(ObjAdminService.GetAll());
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
                var ObjAdmin = ObjAdminService.Search(CurrentAdmin.Id);

                if (ObjAdmin != null)
                {
                    CurrentAdmin.Id = ObjAdmin.Id;
                    CurrentAdmin.Administrator = ObjAdmin.Administrator;
                    CurrentAdmin.Password = ObjAdmin.Password;
                }
                else
                {
                    Message = "Admin not found";
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
                var IsUpdated = ObjAdminService.Update(CurrentAdmin);

                if (IsUpdated)
                {
                    Message = "Admin Updated";
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
                var IsDelete = ObjAdminService.Delete(CurrentAdmin.Id);

                if (IsDelete)
                {
                    Message = "Admin deleted";
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
