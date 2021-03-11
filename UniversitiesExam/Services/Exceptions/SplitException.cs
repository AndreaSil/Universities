using System;

namespace UniversitiesExam.Services.Exceptions
{
    public class SplitException : Exception
    {
        public SplitException(string message) : base(message) { }
        public SplitException(string message, Exception inner) : base(message, inner) { }
    }
}
