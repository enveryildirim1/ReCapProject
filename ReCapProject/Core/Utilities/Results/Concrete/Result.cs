﻿using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)
        {
            Message = message;


        }
        public Result(bool success)
        {

            Seccess = success;

        }

        public bool Seccess { get; }

        public string Message { get; }
    }
}
