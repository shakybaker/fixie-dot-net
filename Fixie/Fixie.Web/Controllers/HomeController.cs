using Fixie.Models;
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
            //var repo = new BoardRepository(new FixieContext());
            //var boards = repo.FindAll();

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
                Boards = new List<Board> { new Board
            {
                Name = "Test",
                Type = BoardType.Board,
                Lanes =
                            {
                                new Lane
                                    {
                                        Sequence = 1,
                                        Name = "To Do",
                                        Cards = new List<Card>
                                            {
                                                new Card
                                                    {
                                                        Name = "Volutpat metus, quis euismod massa scelerisque",
                                                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                                                        Priority = high,
                                                        Complexity = sp13
                                                    }
                                            }
                                    },
                                new Lane
                                    {
                                        Sequence = 2,
                                        Name = "In Progress",
                                        Cards = new List<Card>
                                            {
                                                new Card
                                                    {
                                                        Name = "Diam fringilla porta",
                                                        Description = "Nulla nec nulla ac ligula ultricies feugiat aliquet eget justo",
                                                        Priority = high,
                                                        Complexity = sp13
                                                    },
                                                new Card
                                                    {
                                                        Name = "Consectetur adipiscing elit",
                                                        Description = "Nunc dapibus volutpat metus, quis euismod massa scelerisque a",
                                                        Priority = medium,
                                                        Complexity = sp3
                                                    }
                                            }
                                    },
                                new Lane
                                    {
                                        Sequence = 3,
                                        Name = "Developed",
                                        Cards = new List<Card>
                                            {
                                                new Card
                                                    {
                                                        Name = "Lorem ipsum dolor",
                                                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                                                        Priority = high,
                                                        Complexity = sp20
                                                    },
                                                new Card
                                                    {
                                                        Name = "Consectetur adipiscing elit",
                                                        Description = "Cras consequat ipsum quis purus dignissim eu molestie nulla sagittis",
                                                        Priority = low,
                                                        Complexity = sp1, 
                                                        Bugs = new List<Bug> { new Bug { Description = "OH NO!!!!!!" } }
                                                    },
                                                new Card
                                                    {
                                                        Name = "Lorem ipsum dolor",
                                                        Description = "Proin facilisis odio eget odio rhoncus quis lobortis est commodo",
                                                        Priority = medium,
                                                        Complexity = sp5
                                                    }
                                            }
                                    },
                                new Lane
                                    {
                                        Sequence = 4,
                                        Name = "Ready to Test",
                                        Cards = new List<Card>
                                            {
                                                new Card
                                                    {
                                                        Name = "Consectetur adipiscing elit",
                                                        Description =
                                                            "Donec ullamcorper ante a massa imperdiet at ullamcorper ligula consectetur",
                                                        Priority = high,
                                                        Complexity = sp20
                                                    },
                                                new Card
                                                    {
                                                        Name = "Diam fringilla porta",
                                                        Description = "Morbi tincidunt enim quis risus tincidunt ornare",
                                                        Priority = low,
                                                        Complexity = sp1
                                                    },
                                                new Card
                                                    {
                                                        Name = "Lorem ipsum dolor",
                                                        Description = "Nulla nec nulla ac ligula ultricies feugiat aliquet eget justo",
                                                        Priority = medium,
                                                        Complexity = sp5
                                                    }
                                            }
                                    },
                                new Lane
                                    {
                                        Sequence = 5,
                                        Name = "Ready for UAT",
                                        Cards = new List<Card>
                                            {
                                                new Card
                                                    {
                                                        Name = "Lorem ipsum dolor",
                                                        Description = "Phasellus vel urna eget mi feugiat aliquam id quis risus",
                                                        Priority = low,
                                                        Complexity = sp20
                                                    },
                                                new Card
                                                    {
                                                        Name = "Consectetur adipiscing elit",
                                                        Description = "Nulla quis turpis sem, sed aliquet ipsum",
                                                        Priority = low,
                                                        Complexity = sp1
                                                    }
                                            }
                                    },
                                new Lane
                                    {
                                        Sequence = 6,
                                        Name = "Passed",
                                        Cards = new List<Card>
                                            {
                                                new Card
                                                    {
                                                        Name = "Lorem ipsum dolor",
                                                        Description = "In non nunc sed sem imperdiet porttitor",
                                                        Priority = medium,
                                                        Complexity = sp8
                                                    }
                                            }
                                    },
                                new Lane
                                    {
                                        Sequence = 7,
                                        Name = "Done",
                                        Cards = new List<Card>
                                            {
                                                new Card
                                                    {
                                                        Name = "Diam fringilla porta",
                                                        Description =
                                                            "Integer vulputate quam sit amet diam fringilla porta rutrum dolor pharetra",
                                                        Priority = medium,
                                                        Complexity = sp5
                                                    }
                                            }
                                    }
                            }
            }}

            };

            //projectRepo.Add(new[] { project });

            return View();
        }
    }
}
