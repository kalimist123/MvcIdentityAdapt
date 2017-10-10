using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcIdentityAdapt.Controllers
{
    public class BaseController :Controller
    {



        public void ReplaceModelStateKeyMessage(string keyName, string errorFind, string errorReplacement)
        {


            foreach (var modelStateKey in ViewData.ModelState.Keys)
            {
                var ming = false;
                var modelStateVal = ViewData.ModelState[modelStateKey];
                foreach (var error in modelStateVal.Errors)
                {
                    var key = modelStateKey;
                    var errorMessage = error.ErrorMessage;
                    var exception = error.Exception;

                    if (key == keyName)
                        if (error.ErrorMessage.Contains(errorFind))
                            ming = true;
                }

                if (ming)
                {
                    ModelState.Remove(keyName);
                    ModelState.AddModelError(keyName, errorReplacement);
                }
            }
        }

    }
}
