using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //ctor'un farklı kullanımlarına bir örnek
        //     parametre atandı, overload azaltıldı : this(success)        ile birlikte bu ctor'a başka bir ctor'un parametresini atadık. bu sayede overload önüne geçildi
        //            Yanlış, kendini referans alır : this(success, "...")
        public Result(bool success, string message) : this(success)
        {
            Message = message;
            //Success = success; 'tek parametreli ctor' içinde de bu kod bulunduğundan dolayı, bu kod overload sebebidir
        }

        public Result(bool success) //tek parametreli ctor
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message {  get; }
    }
}
