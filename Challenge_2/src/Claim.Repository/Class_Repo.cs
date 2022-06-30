using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//namespace Challenge_2.src.Claim.Repository

    public class Claim_Repo
    {
        private readonly List<Claim> _crepo = new List<Claim>();
        private int _count;
        public void AddClaim(Claim claim)
        {
            if(claim != null)
            {
                _count++;
                claim.ClaimID = _count;
                _crepo.Add(claim);
            }
        }
        public List<Claim> ViewAll()
        {
            return _crepo;
        }
        public bool RemoveClaim(Claim claim)
        {
            if(claim != null)
            {
                bool success = _crepo.Remove(claim);
                if(success)
                {return true;}
            }
            return false;
        }
    }