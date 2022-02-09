using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PaintJob.Model
{
    public class JobDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #region Properties

        #region Basic information properties

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }
        }

        private string worker;

        public string Worker
        {
            get { return worker; }
            set { worker = value; OnPropertyChanged("Worker"); }
        }

        private string machineName;

        public string MachineName
        {
            get { return machineName; }
            set { machineName = value; OnPropertyChanged("MachineName"); }
        }

        private int construction;

        public int Construction
        {
            get { return construction; }
            set { construction = value; OnPropertyChanged("Construction"); }
        }

        private int element;

        public int Element
        {
            get { return element; }
            set { element = value; OnPropertyChanged("Element"); }
        }

        private DateTime paintJobDate;

        public DateTime PaintJobDate
        {
            get { return DateTime.Now; }
            set { paintJobDate = value; OnPropertyChanged("PaintJobDate"); }
        }

        private int colorCode;

        public int ColorCode
        {
            get { return colorCode; }
            set { colorCode = value; OnPropertyChanged("ColorCode"); }
        }

        private string preparation;

        public string Preparation
        {
            get { return preparation; }
            set { preparation = value; OnPropertyChanged("Preparation"); }
        }

        #endregion

        #region PaintJob preparation properties

        private int cleanConstruction;

        public int CleanConstruction
        {
            get { return cleanConstruction; }
            set { cleanConstruction = value; OnPropertyChanged("CleanCnstruction"); }
        }

        private int cleanElements;

        public int CleanElements
        {
            get { return cleanElements; }
            set { cleanElements = value; OnPropertyChanged("CleanElements"); }
        }

        private int colorQuantity;

        public int ColorQuantity
        {
            get { return colorQuantity; }
            set { colorQuantity = value; OnPropertyChanged("ColorQuantity"); }
        }

        private int thinnerQuantity;

        public int ThinnerQuantity
        {
            get { return thinnerQuantity; }
            set { thinnerQuantity = value; OnPropertyChanged("ThinnerQuantity"); }
        }

        private int hardenerQuantity;

        public int HardenerQuantity
        {
            get { return hardenerQuantity; }
            set { hardenerQuantity = value; OnPropertyChanged("HardenerQuantity"); }
        }

        private int mixQuantity;

        public int MixQuantity
        {
            get { return mixQuantity; }
            set { mixQuantity = value; OnPropertyChanged("MixQuantity"); }
        }

        private string prefilterM3;

        public string PrefilterM3
        {
            get { return prefilterM3; }
            set { prefilterM3 = value; OnPropertyChanged("Prefilter"); }
        }

        private string filterM3;

        public string FilterM3
        {
            get { return filterM3; }
            set { filterM3 = value; OnPropertyChanged("Filter"); }
        }

        #endregion

        #region Techincal details properties

        private int airPressure;

        public int AirPressure
        {
            get { return airPressure; }
            set { airPressure = value; OnPropertyChanged("AirPressure"); }
        }

        private string waterInSystem;

        public string WaterInSystem
        {
            get { return waterInSystem; }
            set { waterInSystem = value; OnPropertyChanged("WaterInSystem"); }
        }

        private int gunColorPressure;

        public int GunColorPressure
        {
            get { return gunColorPressure; }
            set { gunColorPressure = value; OnPropertyChanged("GunColorPressure"); }
        }

        private int gunAirPressure;

        public int GunAirPressure
        {
            get { return gunAirPressure; }
            set { gunAirPressure = value; OnPropertyChanged("GunAirPressure"); }
        }

        private int gunAngle;

        public int GunAngle
        {
            get { return gunAngle; }
            set { gunAngle = value; OnPropertyChanged("GunAngle"); }
        }

        private int temperature;

        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; OnPropertyChanged("Temperature"); }
        }

        private string wind;

        public string Wind
        {
            get { return wind; }
            set { wind = value; OnPropertyChanged("Wind"); }
        }

        private string outsideJob;

        public string OutsideJob
        {
            get { return outsideJob; }
            set { outsideJob = value; OnPropertyChanged("OutsideJob"); }
        }

        #endregion

        #region Other information properties

        private string ratio;

        public string Ratio
        {
            get { return ratio; }
            set { ratio = value; OnPropertyChanged("Ratio"); }
        }

        private int workHours;

        public int WorkHours
        {
            get { return workHours; }
            set { workHours = value; OnPropertyChanged("WorkHours"); }
        }

        private int usedMixQuantity;

        public int UsedMixQuantity
        {
            get { return usedMixQuantity; }
            set { usedMixQuantity = value; OnPropertyChanged("UsedMixQuantity"); }
        }

        private int wastedMixQuantity;

        public int WastedMixQuantity
        {
            get { return wastedMixQuantity; }
            set { wastedMixQuantity = value; OnPropertyChanged("WastedMixQuantity"); }
        }

        private int cleanGunQuantity;

        public int CleanGunQuantity
        {
            get { return cleanGunQuantity; }
            set { cleanGunQuantity = value; OnPropertyChanged("CleanGunQuantity"); }
        }

        private string grainEffect;

        public string GrainEffect
        {
            get { return grainEffect; }
            set { grainEffect = value; OnPropertyChanged("GrainEffect"); }
        }

        private int colorRepair;

        public int ColorRepair
        {
            get { return colorRepair; }
            set { colorRepair = value; OnPropertyChanged("ColorRepair"); }
        }

        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; OnPropertyChanged("Comment"); }
        }

        #endregion

        #endregion
    }
}
