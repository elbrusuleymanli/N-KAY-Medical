﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Areas.Admin.ViewModel
{
    
        public class ChangePasswordVM
        {
            
            [Required, DataType(DataType.Password)]
            public string NewPassword { get; set; }
            [Required, DataType(DataType.Password), Compare(nameof(NewPassword))]
            public string ConfirmNewPassword { get; set; }


        
    }
}
