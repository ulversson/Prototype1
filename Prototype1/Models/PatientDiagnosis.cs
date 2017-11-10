using System.ComponentModel.DataAnnotations.Schema;


namespace Prototype1.Models
{
    public class PatientDiagnosis
    {
        public int ID { get; set; }
        public int PatientId { get; set; }
        public int DiagnosisTypeId { get; set; }
        public int DiagnosisCategoryId { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public Patient Patient { get; set; }
        public DiagnosisType DiagnosisTypes { get; set; }
        public DiagnosisCategory DiagnosisCategories { get; set; }
    }
}
