﻿using System;

namespace Basic_OOP.BasicOOP.Interface
{
    public class John : IBaseInterface, ISecondInterface
    {
        public void WriteName()
        {
            Console.WriteLine("I'm John");
        }
        public void ShowAge()
        {
            Console.WriteLine(55);
        }
    }
}
