using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Infrastructure.Exceptions
{
    public  class OAExceptionBase : Exception
    {
        public string ResponsibleLayer { get; set; }
        public override  string Message => string.Format("sorumlu katman: {0} - mesaj:{1}", ResponsibleLayer, base.Message);

        public OAExceptionBase(string responsibleLayer, string message) : base(message)
        {
            ResponsibleLayer = responsibleLayer;
        }
       
        
    }
}
