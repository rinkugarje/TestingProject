using System.ComponentModel.DataAnnotations;

namespace Task8_UnitTesting.Model
{
    public class GadgetClass
    {
        [Key]
        public int GadgetId { get; set; }
        public string GadgetName { get; set; }
        public string GadgetType { get; set; }
        public int GadgetPrice { get; set; }
    }
}
