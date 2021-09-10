using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       
        public Result(bool success,string message): this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }


        public bool Success { get; }

        public string Message { get; }
    }

}


//Getter'lar Readonly'dir fakat contructor'da set edilebilir.
//Burada Property'ye Setter vermememizin nedeni kodlayacak olan kişiyi sınırlamamızdır.
