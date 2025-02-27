﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace MethodFun
{
    public class Car
    {
        int NumWhee1s = 4;
        int cylinders;
        public static int carCount = 0;

        public Car()
        {
            carCount++;
        }

        int Cylinders
        {
            get { return cylinders; }
            set { cylinders = value; }
        }

        public void Start() {
            // code in here
        }
        //Page 6: Method overloading
        public void Start(string keyCode) { }
        public void Start(Token token) { }
        public void Start(FingerPrint fingerprint) { }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }

        public void Register(string name, string address, string postCode, string country="USA")
        {
            Name = name;
            Address = address;
            PostCode = postCode;
            Country = country;
            //store this in the DVLA database in Swansea

        }
    }
}
