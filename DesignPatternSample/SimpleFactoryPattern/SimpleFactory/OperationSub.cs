﻿
namespace SimpleFactoryPattern.SimpleFactory
{
    using System;
    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            try
            {
                double result = 0;
                result = NumberA - NumberB;
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
