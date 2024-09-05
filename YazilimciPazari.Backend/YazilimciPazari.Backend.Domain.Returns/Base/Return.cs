﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Returns.Abstract;

namespace YazilimciPazari.Backend.Domain.Returns.Base
{
    public record Return : IReturn
    {
        public Return(bool status, string? message, Exception? exception) 
        {
            Status = status;
            Message = message;
            Exception = exception;
        }
        public bool Status { get; init; }
        public string? Message { get; init; }
        public Exception? Exception { get; init; }
    }
    public record Return<T> : Return, IReturn<T>
    {
        public Return(bool status, T? data, string? message, Exception? exception) : base(status, message, exception)
        {
            Data = data;
        }
        public T? Data { get; init; }
    }
}
