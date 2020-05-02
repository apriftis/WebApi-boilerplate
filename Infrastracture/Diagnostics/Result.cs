using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Diagnostics
{
    public interface IResult<T> { }

    public class Result<T> : IResult<T>
    {

    }
}
