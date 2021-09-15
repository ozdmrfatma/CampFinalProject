using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public class ValidationTool//AOP İlgilendirmez
    {
        public static void Validate(IValidator validator,object entity)
        {

            var context = new ValidationContext<Object>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}

///Statik bir sınıfın metodlarının da statik olması gerekir.
