﻿namespace JQuery.Datatables.Core.Serialization
{
    public class Raw
    {
        string _value;
        public Raw(string value)
        {
            _value = value;
        }
        public override string ToString()
        {
            return _value;
        }
    }
}