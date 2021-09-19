using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)  //iş kuralları
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;       //ErrorResult döndürecek
                }
            }

            return null;
        }
    }
}
///İş kuralları için iş motoru
///Bu bir araç olduğu için static olarak kullanıyoruz.
