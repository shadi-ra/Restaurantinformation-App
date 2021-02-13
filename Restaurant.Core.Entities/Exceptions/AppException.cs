using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Entities.Exceptions
{
   public class AppException: ApplicationException
    {
        public AppException(string massage) : base(massage)
        {

        }
    }
}
