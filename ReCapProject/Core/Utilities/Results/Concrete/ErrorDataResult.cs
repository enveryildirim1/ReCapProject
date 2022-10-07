using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        private object maintenanceTime;

        public ErrorDataResult(object maintenanceTime)
        {
            this.maintenanceTime = maintenanceTime;
        }

        public ErrorDataResult(T data, string massage) : base(data, false, massage)
        {
            //1.versiyon data+mesajlı
        }
    }
}
