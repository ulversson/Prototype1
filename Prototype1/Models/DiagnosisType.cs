using System.Collections.Generic;

namespace Prototype1.Models
{
    public class DiagnosisType
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<PatientDiagnosis> PatientDiagnoses { get; set; }

    }
}
