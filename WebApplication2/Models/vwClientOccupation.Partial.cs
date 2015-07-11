namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(vwClientOccupationMetaData))]
    public partial class vwClientOccupation
    {
    }
    
    public partial class vwClientOccupationMetaData
    {
        [Required]
        public int ClientId { get; set; }
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        public string FirstName { get; set; }
        
        [StringLength(60, ErrorMessage="欄位長度不得大於 60 個字元")]
        public string OccupationName { get; set; }
    }
}
