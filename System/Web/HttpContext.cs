﻿namespace System.Web
{
    internal class HttpContext
    {
        public static object Current { get; internal set; }
        public static object Request { get; internal set; }
    }
}