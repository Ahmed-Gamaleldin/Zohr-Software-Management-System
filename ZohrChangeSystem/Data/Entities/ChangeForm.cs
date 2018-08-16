using System;
namespace ZohrChangeSystem.Data.Entities
{
    public class ChangeForm
    {
        public int Id { get; set; }
        public string title { get; set; }
        public String date { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public string initiatedBy { get; set; }
        public string implementedBy { get; set; }
        public string status { get; set; }
    }
}
