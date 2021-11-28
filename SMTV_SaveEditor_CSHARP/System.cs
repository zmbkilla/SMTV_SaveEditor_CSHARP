using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTV_SaveEditor_CSHARP
{
    class Systemind
    {
        public readonly struct Index
        {
            // To use the "hat" operator (^), the following is required:
            public Index(int value, bool fromEnd);

            // To use the System.Index type as an argument in an array element access, the following member is required:
            int GetOffset(int length);
        }

        // The .. syntax for System.Range will require the System.Range type, as well as one or more of the following members:
        public readonly struct Range
        {
            public Range(System.Index start, System.Index end);
            public static Range StartAt(System.Index start);
            public static Range EndAt(System.Index end);
            public static Range All { get; }
        }
    }

    namespace System.Runtime.CompilerServices
    {
        public static class RuntimeHelpers
        {
            // For a value of type System.Range to be used in an array element access expression, the following member must be present:
            public static T[] GetSubArray<T>(T[] array, System.Range range);
        }
    }

}
