﻿using MDTManagment.Models;
using MDTManagment.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDTManagment.ViewModels.Dentists
{
    public class DentistViewModel
    {
        public Dentist Dentist { get; set; }

        private DentistService dentistService;

        public DentistViewModel(int dentistId)
        {
            this.dentistService = new DentistService();
            var databaseDentist = dentistService.GetDentistById(dentistId);
            this.Dentist = databaseDentist;
        }
    }
}