using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Prototype1.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }
        public string RM2Number { get; set; }

        public ICollection<PatientDiagnosis> PatientDiagnoses { get; set; }


    }
}
