﻿using Fixie.Models;
using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fixie.Web.Controllers
{
    public class HomeController : Controller
    {
        static MongoRepository<Project> projectRepo = new MongoRepository<Project>();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";


            var project = AddTestProject();
            projectRepo.DeleteAll();
            projectRepo.Add(new[] { project });


            //foreach (Project p in projectRepo)
            //{
            //    //p.Boards.Where(x => x.Name == "Test").FirstOrDefault().Lanes.Where(x => x.Sequence == 1).FirstOrDefault().Name = "UPDATED NAME";

            //    //foreach (var b in p.Boards)
            //    //{
            //    //    foreach (var l in b.Lanes)
            //    //    {
            //    //        if (l.Sequence == 2)
            //    //        {
            //    //            l.Name = "ANOTHER UPDATED";
            //    //        }
            //    //    }
            //    //}
            //    //projectRepo.Update(p);


            //};

            return View();
        }

        private static Project AddTestProject()
        {
            var high = new PriorityLevel { Id = 1, Name = "HIGH", Sequence = 1 };
            var medium = new PriorityLevel { Id = 2, Name = "MED", Sequence = 2 };
            var low = new PriorityLevel { Id = 3, Name = "LOW", Sequence = 3 };
            var sp1 = new ComplexityLevel { Id = 1, Name = "1", Sequence = 1 };
            var sp3 = new ComplexityLevel { Id = 3, Name = "3", Sequence = 2 };
            var sp5 = new ComplexityLevel { Id = 5, Name = "5", Sequence = 3 };
            var sp8 = new ComplexityLevel { Id = 8, Name = "8", Sequence = 4 };
            var sp13 = new ComplexityLevel { Id = 13, Name = "13", Sequence = 5 };
            var sp20 = new ComplexityLevel { Id = 20, Name = "20", Sequence = 6 };

            var project = new Project
            {
                Name = "Test Project",
                Boards = new List<Board> 
                { 
                    new Board
                    {
                        Id = 1,
                        Name = "Test me please",
                        LaneTemplate = new LaneTemplate 
                        {
                            Lanes = new List<Lane> 
                            {
                                new Lane
                                {
                                    Id = 1,
                                    Sequence = 1,
                                    Name = "To Do"
                                },
                                new Lane
                                {
                                    Id = 2,
                                    Sequence = 2,
                                    Name = "In Progress"
                                },
                                new Lane
                                {
                                    Id = 3,
                                    Sequence = 3,
                                    Name = "Developed"
                                },
                                new Lane
                                {
                                    Id = 4,
                                    Sequence = 4,
                                    Name = "Ready to Test"
                                },
                                new Lane
                                {
                                    Id = 5,
                                    Sequence = 5,
                                    Name = "Ready for UAT"
                                }
                            }
                        },
                        Cards = new List<Card>
                            {
                                new Card
                                    {
                                        Id = 1,
                                        LaneId = 1,
                                        Name = "Volutpat metus, quis euismod massa scelerisque",
                                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                                        Priority = high,
                                        Complexity = sp13
                                    },
                                new Card
                                    {
                                        Id = 2,
                                        LaneId = 1,
                                        Name = "Diam fringilla porta",
                                        Description = "Nulla nec nulla ac ligula ultricies feugiat aliquet eget justo",
                                        Priority = high,
                                        Complexity = sp13
                                    },
                                new Card
                                    {
                                        Id = 3,
                                        LaneId = 1,
                                        Name = "Consectetur adipiscing elit",
                                        Description = "Nunc dapibus volutpat metus, quis euismod massa scelerisque a",
                                        Priority = medium,
                                        Complexity = sp3
                                    },
                                new Card
                                    {
                                        Id = 4,
                                        LaneId = 2,
                                        Name = "Lorem ipsum dolor",
                                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                                        Priority = high,
                                        Complexity = sp20
                                    },
                                new Card
                                    {
                                        Id = 5,
                                        LaneId = 3,
                                        Name = "Consectetur adipiscing elit",
                                        Description = "Cras consequat ipsum quis purus dignissim eu molestie nulla sagittis",
                                        Priority = low,
                                        Complexity = sp1, 
                                        Bugs = new List<Bug> { new Bug { Description = "OH NO!!!!!!" } }
                                    },
                                new Card
                                    {
                                        Id = 6,
                                        LaneId = 3,
                                        Name = "Lorem ipsum dolor",
                                        Description = "Proin facilisis odio eget odio rhoncus quis lobortis est commodo",
                                        Priority = medium,
                                        Complexity = sp5
                                    },
                                new Card
                                    {
                                        Id = 7,
                                        LaneId = 3,
                                        Name = "Consectetur adipiscing elit",
                                        Description =
                                            "Donec ullamcorper ante a massa imperdiet at ullamcorper ligula consectetur",
                                        Priority = high,
                                        Complexity = sp20
                                    },
                                new Card
                                    {
                                        Id = 8,
                                        LaneId = 3,
                                        Name = "Diam fringilla porta",
                                        Description = "Morbi tincidunt enim quis risus tincidunt ornare",
                                        Priority = low,
                                        Complexity = sp1
                                    },
                                new Card
                                    {
                                        Id = 9,
                                        LaneId = 3,
                                        Name = "Lorem ipsum dolor",
                                        Description = "Nulla nec nulla ac ligula ultricies feugiat aliquet eget justo",
                                        Priority = medium,
                                        Complexity = sp5
                                    },
                                new Card
                                    {
                                        Id = 10,
                                        LaneId = 3,
                                        Name = "Lorem ipsum dolor",
                                        Description = "Phasellus vel urna eget mi feugiat aliquam id quis risus",
                                        Priority = low,
                                        Complexity = sp20
                                    },
                                new Card
                                    {
                                        Id = 11,
                                        LaneId = 4,
                                        Name = "Consectetur adipiscing elit",
                                        Description = "Nulla quis turpis sem, sed aliquet ipsum",
                                        Priority = low,
                                        Complexity = sp1
                                    },
                                new Card
                                    {
                                        Id = 12,
                                        LaneId = 4,
                                        Name = "Lorem ipsum dolor",
                                        Description = "In non nunc sed sem imperdiet porttitor",
                                        Priority = medium,
                                        Complexity = sp8
                                    },
                                new Card
                                    {
                                        Id = 13,
                                        LaneId = 4,
                                        Name = "Diam fringilla porta",
                                        Description =
                                            "Integer vulputate quam sit amet diam fringilla porta rutrum dolor pharetra",
                                        Priority = medium,
                                        Complexity = sp5
                                    }
                            }
                    }
                }
            };

            return project;
        }
    }
}
