using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Helpers;
using TestProject.Models;
using TestProject.Services;

namespace TestProject.ViewModels
{
    public class EmployeeShiftListViewModel : ObservableObject
    {
        private ObservableCollection<EmployeeShift> _employeeShifts;

        public ObservableCollection<EmployeeShift> EmployeeShifts
        {
            get { return _employeeShifts; }
            set
            {
                if (_employeeShifts != value)
                {
                    _employeeShifts = value;
                    OnPropertyChanged(nameof(EmployeeShifts));
                }
            }
        }

        public EmployeeShiftListViewModel()
        {
            EmployeeShifts = new ObservableCollection<EmployeeShift>(AuthenticationService.GetEmployeeShifts());
        }
    }
}
