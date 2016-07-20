using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JOK_PaaS_2Tier_VC_App.Models
{
    // Models returned by MeController actions.
    public class GetViewModel
    {
        public string Hometown { get; set; }
    }
}