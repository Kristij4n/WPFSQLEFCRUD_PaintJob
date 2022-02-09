# WPFSQLEFCRUD_PaintJob - app is work in progress!!!
Reduce paint waste using data from paint job
PaintJob application

The purpose of the program is to reduce paint waste by entering actual data after each painting of a particular machine.

using MVVM pattern - open for change later, binding...
using EntityFramework
using SQL server

Programming - Kristijan

**********************************************************************
20211118_0057

create MVVM for Job
create relay commands with CanExecute and Execute for Job

**********************************************************************
**********************************************************************
20211122_2231

create in SQL server table and import with connection in PaintJob, 
add Material design in application
TEST OK

**********************************************************************
**********************************************************************
20211127_0232 

editing view to operate
TEST OK

to do: add images etc...

**********************************************************************
**********************************************************************
20211128_2359

edited sql table for DateTime
edited in PaintJob JobDTO property, 
PaintJobDate, set return DateTime.Now

TEST OK
**********************************************************************
20210118_2040

create Login Window
create Register Window
create sql database on 18 version, changed table jobs to job

tested changing windows from login and register to main to operate... 
Test OK
***********************************************************************
20220118_2311

create connection for username and password to sql, 
tested inserting and select user from sql
block invalid user

TEST OK
***********************************************************************
20220121_0113

create worker login and admin login
register can be done only by admin
tested with sql

TEST OK
***********************************************************************
PaintJob20220124_0042

creating new modern design view with separated information for paint job:

create commands - relay
core - observable object and relay command
fonts - poppins regular
theme - menu button and textbox theme
view - job basic info
       job preparation
       job tech details
       job other info
and JobMainView to show them

ViewModel - basic info
	    preparation
 	    tech detalis
	    other info
and MainViewModel to operate views

in app.xaml include vm and v

tested with login worker, with colors on views

TEST OK
***********************************************************************
PaintJob20220125_0039

window mode,state, resize on max
edit view in main job view horizontal and vertical, create commands

TEST OK
***********************************************************************
PaintJob20220128_0526

added in database new users,admin
added password to sql and password in config in PaintJob
added in Model Admin and User
added in Service AdminService and UserService

added in View Admin - AdminJobPreviewView, 
AdminLoginView,
AdminOptionsMainView,
AdminServerView,

Job - JobBasicInfoView,
JobMainView,
JobOtherInfo,
JobPreparationView,
JobTechnicalDetailsView,
JobView,

Login - LoginView,

Register - RegisterFormView,
RegisterOptionView,

User - UserView

added in ViewModel 
Admin - AdminJobPreviewViewModel, 
AdminLoginViewModel,
AdminOptionsMainViewModel,
AdminServerViewModel,

Job - JobBasicInfoViewModel,
JobMainViewModel,
JobOtherInfoModel,
JobPreparationViewModel,
JobTechnicalDetailsViewModel,
JobViewModel,

Login - LoginViewModel,

Register - RegisterFormViewModel,
RegisterOptionViewModel,

User - UserViewModel
MainViewModel in Main

added in App.xaml view and viewmodel separated
added in JobView logout and reset
added in LoginView exit with mouseDoubleClick with packIcon
added in AdminOptionsMainView - register user, logout, user preview, job preview, admin server manager/preview

tested views, functions

TEST OK
***********************************************************************
PaintJob20220129_0256

added register admin in admin options
added start new job, same as job preview, use for test to separate input and output

in View/Admin new xaml is RegisterAdminFormView and RegisterAdminOptionView
in View/Job new xaml is NewJobBasicView and StartBasicView - use like mainwindow

same in VM
added in app.xaml namespace

TEST OK
***********************************************************************
PaintJob20220130_0113

regroup view and viewModel, better namespaces
View from adminMain regroup for better navigation, include user and logins

TEST OK
***********************************************************************
PaintJob20220202_2343

regroup view and viewModel, new options to select
for admin - automatic job start, manual job start, job preview, service and stock
for user - automatic job start, manual job start, job preview, service and stock
deleted from view and viewModel not used classes and views

TEST OK
***********************************************************************
PaintJob20220204_0510

added SelectColorView with save functions
-combobox with colors, text and color
-inserted in sql
TEST OK
***********************************************************************
PaintJob20220206_0227

-added input options for elementsView
-tested inserting in sql
TEST OK
***********************************************************************
PaintJob20220209_0054

-added input options for PrepareMaterial
-tested inserting in sql
TEST OK
***********************************************************************
