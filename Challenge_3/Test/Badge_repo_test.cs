using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

//namespace Challenge_3.Test

    public class Badge_repo_test
    {
        private readonly Badge_Repo _bd = new Badge_Repo();

        private Badge _badge = new Badge();
        [Fact]
        public void AddBadge_True()
        {
            var badge = new Badge();
            bool success = _bd.AddBadge(badge);
            Assert.True(success);
        }
        [Fact]
        public void GetBadgeByID_True()
        {
            _bd.AddBadge(_bd);
            var badge = _bd.GetBadgeByID(1);
            int actual = badge.BadgeID;
            int expected = 1;
            Assert.Equals(expected, actual);
        }
        [Fact]
        public void ViewBadges_List()
        {
            
        }
    }
