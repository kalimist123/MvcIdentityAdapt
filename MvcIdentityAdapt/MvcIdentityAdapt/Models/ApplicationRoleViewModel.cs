using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcIdentityAdapt.Models
{
    using System.ComponentModel.DataAnnotations;

    namespace IdentitySampleApplication.Models
    {
        public class ApplicationRoleViewModel
        {
            public string Id { get; set; }
            [Display(Name = "Role Name")]
            public string RoleName { get; set; }
            public string Description { get; set; }
        }
    }
}
