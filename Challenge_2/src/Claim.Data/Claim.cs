using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//namespace Challenge_2.src

    public class Claim
    {
        Claim(){}

        public int ClaimID{get;set;}
        public string ClaimType{get;set;}
        public string Description{get;set;}
        public double ClaimAmount{get;set;}
        public DateOnly DateOfIncident{get;set;}
        public DateOnly DateOfClaim{get;set;}
        public bool isValid{get;set;}
    }
