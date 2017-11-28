using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /*! This class contains all static constants used throughout the application. Conditional compilations apply. */
    public static class Constants
    {
#if DEBUG
        public const string RegistryKey = "HKEY_CURRENT_USER\\Software\\JaniLamppuFinalExercise_Debug";
#else
        public const string RegistryKey = "HKEY_CURRENT_USER\\Software\\JaniLamppuFinalExercise";
#endif
        public const string GivenIntegerValue = "ProgramRunCount";
    }
}
