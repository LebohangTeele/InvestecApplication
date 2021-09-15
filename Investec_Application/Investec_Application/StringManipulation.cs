using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investec_Application
{
    public interface  StringManipulation
    {
    
        public abstract string DublicateCheck(ModelClass modelclass);
        public abstract string VoulCount(ModelClass modelclass);
        public abstract string NumberOfVowels_NonVowels(ModelClass modelclass);
    }
}
