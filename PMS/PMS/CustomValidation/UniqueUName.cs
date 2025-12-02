using PMS.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PMS.CustomValidation
{
    public class UniqueUName : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if (value != null) {
                var db = new PMS_Fall25_BEntities();
                var u = (from user in db.Customers 
                        where user.Username.Equals(value.ToString())
                        select user).SingleOrDefault();
                if (u == null) return ValidationResult.Success;
                else return new ValidationResult("Username Exists");
            }
            return new ValidationResult("Check Values");
        }
    }
}