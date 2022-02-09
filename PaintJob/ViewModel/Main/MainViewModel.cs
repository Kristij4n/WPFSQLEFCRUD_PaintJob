using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintJob.Core;
using PaintJob.ViewModel.Admin;
using PaintJob.ViewModel.Job;
using PaintJob.ViewModel.Job.Manual;
using PaintJob.ViewModel.Register;
using PaintJob.ViewModel.User;

namespace PaintJob.ViewModel.Main
{
    class MainViewModel : ObervableObject
    {
        /// <summary>
        /// commands
        /// </summary>
        ///
        
        // job
        public RelayCommand JobStartViewCommand { get; set; }
        public RelayCommand ManualJobStartViewCommand { get; set; }

        // register
        public RelayCommand RegisterOptionsViewCommand { get; set; }
        public RelayCommand RegisterUserViewCommand { get; set; }
        public RelayCommand RegisterAdminViewCommand { get; set; }

        // user
        public RelayCommand UserViewCommand { get; set; }
        public RelayCommand UserJobPreviewViewCommand { get; set; }
        
        // admin
        public RelayCommand AdminViewCommand { get; set; }
        public RelayCommand AdminJobPreviewViewCommand { get; set; }
        public RelayCommand AccountsViewCommand { get; set; }

        /// <summary>
        /// VM
        /// </summary>

        // job
        public JobStartViewModel JobStartVM { get; set; }
        public ManualJobStartViewModel ManualJobStartVM { get; set; }

        // register
        public RegisterOptionsViewModel RegisterOptionsVM { get; set; }
        public RegisterUserViewModel RegisterUserVM { get; set; }
        public RegisterAdminViewModel RegisterAdminVM { get; set; }

        // user
        public UserViewModel UserVM { get; set; }
        public UserJobPreviewViewModel UserJobPreviewVM { get; set; }
        
        // admin
        public AdminViewModel AdminVM { get; set; }
        public AdminJobPreviewViewModel AdminJobPreviewVM { get; set; }
        public AccountsViewModel AccountsVM { get; set; }

        /// <summary>
        /// current view
        /// </summary>

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// relay command
        /// </summary>
        public MainViewModel()
        {
            // job
            JobStartVM = new JobStartViewModel();
            ManualJobStartVM = new ManualJobStartViewModel();
            
            // register
            RegisterOptionsVM = new RegisterOptionsViewModel();
            RegisterUserVM = new RegisterUserViewModel();
            RegisterAdminVM = new RegisterAdminViewModel();

            // user
            UserVM = new UserViewModel();
            UserJobPreviewVM = new UserJobPreviewViewModel();

            // admin
            AdminVM = new AdminViewModel();
            AdminJobPreviewVM = new AdminJobPreviewViewModel();
            AccountsVM = new AccountsViewModel();
            
            // set current
            CurrentView = JobStartVM;

            // job

            JobStartViewCommand = new RelayCommand(o =>
            {
                CurrentView = JobStartVM;
            });

            ManualJobStartViewCommand = new RelayCommand(o =>
            {
                CurrentView = ManualJobStartVM;
            });
            
            // register
            RegisterOptionsViewCommand = new RelayCommand(o =>
            {
                CurrentView = RegisterOptionsVM;
            });

            RegisterUserViewCommand = new RelayCommand(o =>
            {
                CurrentView = RegisterUserVM;
            });

            RegisterAdminViewCommand = new RelayCommand(o =>
            {
                CurrentView = RegisterAdminVM;
            });

            // user
            UserViewCommand = new RelayCommand(o =>
            {
                CurrentView = UserVM;
            });

            UserJobPreviewViewCommand = new RelayCommand(o =>
            {
                CurrentView = UserJobPreviewVM;
            });

            // admin
            AdminViewCommand = new RelayCommand(o =>
            {
                CurrentView = AdminVM;
            });

            AdminJobPreviewViewCommand = new RelayCommand(o =>
            {
                CurrentView = AdminJobPreviewVM;
            });

            AccountsViewCommand = new RelayCommand(o =>
            {
                CurrentView = AccountsVM;
            });


        }
    }
}