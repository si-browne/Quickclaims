//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quickclaims.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car_Insurance_Claim
    {
        public int Claim_ID { get; set; }
        public int Policy_ID { get; set; }
        public int Company_ID { get; set; }
        public string claim_title { get; set; }
        public System.DateTime datetimeofaccident { get; set; }
        public string car_reg { get; set; }
        public string car_make { get; set; }
        public string car_model { get; set; }
        public string car_colour { get; set; }
        public bool parked_unparked { get; set; }
        public string weather { get; set; }
        public string light_level { get; set; }
        public string road_quality { get; set; }
        public string damage_description { get; set; }
        public string injury_description { get; set; }
        public string geolocation { get; set; }
        public string manual_location { get; set; }
        public bool to_blame { get; set; }
    }
}