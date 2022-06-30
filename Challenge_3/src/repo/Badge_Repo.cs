using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//namespace Challenge_3.src.repo
    public class Badge_Repo
    {
        private readonly Dictionary<int, List<string>> _bdic = new Dictionary<int, List<string>>();
        private int _count = 0;
        public bool AddBadge(Badge b)
        {
            if(Badge is null)
            {
                return false;
            }

            _count++;
            b.BadgeID = _count;
            _bdic.Add(b);
            return true;
        }
        public Dictionary<int, List<string>> ViewBadges()
        {
            return _bdic;
        }
        public Badge GetBadgeByID(int id)
        {
            foreach(KeyValuePair<int,List<string>> badge in _bdic)
            {
                if(badge.Key == id)
                {
                    return badge;
                }
            }
        }
    }
