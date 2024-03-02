using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class State<T>
    {
        public T Value { get; set; }
        public Exception ErrorContent { get; set; }
        public State(T value, Exception errorContent)
        {
            Value = value;
            ErrorContent = errorContent;
        }
        public State(T value)
        {
            Value = value;
        }
        public State(Exception exception)
        {
            ErrorContent = exception;
        }
    }
}
