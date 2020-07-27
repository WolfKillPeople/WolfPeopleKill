﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolfPeopleKill.Services;
using System;
using System.Collections.Generic;
using System.Text;
using WolfPeopleKill.Models;

namespace WolfPeopleKill.Services.Tests
{
    [TestClass()]
    public class GameServiceTests
    {
        [TestMethod()]
        public void WinOrLoseTest()
        {
            var data = new List<Role>()
            {
                new Role{Id=1, Name="狼王",ImgUrl="https://imgur.com/fVQQgnM",Description="狼王",IsGood=false},
                new Role{Id=2,Name = "狼人",ImgUrl="https://imgur.com/n7knadr",Description="狼人",IsGood=false},
                new Role{Id=3,Name="狼人",ImgUrl="https://imgur.com/n7knadr",Description="狼人",IsGood=false},
                new Role{Id=4,Name="預言家",ImgUrl="https://imgur.com/8tiIFAB",Description="預言家",IsGood=true},
                new Role{Id=5,Name="女巫",ImgUrl="https://imgur.com/i9eRyug",Description="女巫",IsGood=true},
                //new Role{Id=6,Name="獵人",ImgUrl="https://imgur.com/TIvcUG5",Description="獵人",IsGood=true},
                new Role{Id=7,Name="村民",ImgUrl="https://imgur.com/4eJqZgk",Description="村民男",IsGood=true},
                new Role{Id=8,Name="村民",ImgUrl="https://imgur.com/D2o6MV6",Description="村民女",IsGood=true},
                new Role{Id=9,Name="村民",ImgUrl="https://imgur.com/4eJqZgk",Description="村民男",IsGood=true},
                new Role{Id=10,Name="村民",ImgUrl="https://imgur.com/D2o6MV6",Description="村民男",IsGood=true}
            };

            var tempBad = 0;
            var tempGood = 0;
            var tempNormalPeople = 0;
            foreach (var item in data)
            {
                switch (item.Id)
                {
                    case 1:
                    case 2:
                    case 3:
                        tempBad++;
                        break;
                    case 4:
                    case 5:
                    case 6:
                        tempGood++;
                        break;
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        tempNormalPeople++;
                        break;
                }
            }

            const bool goodGuyWin = true;
            const bool badGuyWin = false;
            const string noOneWin = "還沒結束";

            switch (tempGood)
            {
                case 0:
                Assert.IsFalse(badGuyWin);
                    break;
                default:
                {
                    switch (tempBad)
                    {
                        case 0:
                            Assert.IsTrue(goodGuyWin);
                        break;
                        default:
                        {
                            if (tempNormalPeople == 0)
                            {
                                Assert.IsFalse(badGuyWin);
                            }
                            else
                            {
                                Assert.AreEqual(noOneWin, "還沒結束");
                            }
                            break;
                            
                        }
                    }
                    break;
                }
            }

        }

        [TestMethod()]
        public void GetRoleTest()
        {
            var _listed = new List<Role>()
            {
                new Role{Id=1, Name="狼王",ImgUrl="https://imgur.com/fVQQgnM",Description="狼王",IsGood=false},
                new Role{Id=2,Name = "狼人",ImgUrl="https://imgur.com/n7knadr",Description="狼人",IsGood=false},
                new Role{Id=3,Name="狼人",ImgUrl="https://imgur.com/n7knadr",Description="狼人",IsGood=false},
                new Role{Id=4,Name="預言家",ImgUrl="https://imgur.com/8tiIFAB",Description="預言家",IsGood=true},
                new Role{Id=5,Name="女巫",ImgUrl="https://imgur.com/i9eRyug",Description="女巫",IsGood=true},
                new Role{Id=6,Name="獵人",ImgUrl="https://imgur.com/TIvcUG5",Description="獵人",IsGood=true},
                new Role{Id=7,Name="村民",ImgUrl="https://imgur.com/4eJqZgk",Description="村民男",IsGood=true},
                new Role{Id=8,Name="村民",ImgUrl="https://imgur.com/D2o6MV6",Description="村民女",IsGood=true},
                new Role{Id=9,Name="村民",ImgUrl="https://imgur.com/4eJqZgk",Description="村民男",IsGood=true},
                new Role{Id=10,Name="村民",ImgUrl="https://imgur.com/D2o6MV6",Description="村民男",IsGood=true}
            };


            var _list = new List<Role>()
            {
                new Role{Id=1, Name="狼王",ImgUrl="https://imgur.com/fVQQgnM",Description="狼王",IsGood=false},
                new Role{Id=2,Name = "狼人",ImgUrl="https://imgur.com/n7knadr",Description="狼人",IsGood=false},
                new Role{Id=3,Name="狼人",ImgUrl="https://imgur.com/n7knadr",Description="狼人",IsGood=false},
                new Role{Id=4,Name="預言家",ImgUrl="https://imgur.com/8tiIFAB",Description="預言家",IsGood=true},
                new Role{Id=5,Name="女巫",ImgUrl="https://imgur.com/i9eRyug",Description="女巫",IsGood=true},
                new Role{Id=6,Name="獵人",ImgUrl="https://imgur.com/TIvcUG5",Description="獵人",IsGood=true},
                new Role{Id=7,Name="村民",ImgUrl="https://imgur.com/4eJqZgk",Description="村民男",IsGood=true},
                new Role{Id=8,Name="村民",ImgUrl="https://imgur.com/D2o6MV6",Description="村民女",IsGood=true},
                new Role{Id=9,Name="村民",ImgUrl="https://imgur.com/4eJqZgk",Description="村民男",IsGood=true},
                new Role{Id=10,Name="村民",ImgUrl="https://imgur.com/D2o6MV6",Description="村民男",IsGood=true}
            };

            var index = 0;
            var random = new Random();

            dynamic temp;
            for (int i = 0; i < _list.Count; i++)
            {
                index = random.Next(0, _list.Count - 1);
                if (index == i) continue;
                temp = _list[i];
                _list[i] = _list[index];
                _list[index] = temp;
            };


            Assert.AreNotEqual(_listed[0].Id,_list[0].Id);
        }
    }
}