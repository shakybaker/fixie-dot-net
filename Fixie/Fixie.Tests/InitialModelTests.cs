using Fixie.Models;
using Fixie.Models.Enums;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixie.Tests
{
    [TestFixture]
    public class InitialModelTests
    {
        [Test]
        public void Can_create_a_card()
        {
            var sut = new Card();
            Assert.IsNotNull(sut);
        }

        [Test]
        public void Can_create_a_project()
        {
            var sut = new Project();
            Assert.IsNotNull(sut);
        }

        [Test]
        public void Can_add_a_board()
        {
            var sut = new Board();
            Assert.IsNotNull(sut);
        }

        [Test]
        public void Can_add_a_lane_to_a_lane_template()
        {
            var sut = new LaneTemplate();
            var lane = new Lane();

            sut.Lanes.Add(lane);

            Assert.AreEqual(1, sut.Lanes.Count);
        }

        [Test]
        public void Can_add_a_user()
        {
            var sut = new User();
            Assert.IsNotNull(sut);
        }

        [Test]
        public void Can_add_a_user_to_a_card()
        {
            var sut = new Card();
            var user = new User();
            var userLink = new UserLink { User = user };

            sut.UserLinks.Add(userLink);

            Assert.AreEqual(1, sut.UserLinks.Count);
        }

        [Test]
        public void Can_specify_user_as_owner()
        {
            var sut = new Card();
            var user = new User();
            var userLink = new UserLink { User = user, LinkType = UserLinkType.Owner };

            sut.UserLinks.Add(userLink);

            Assert.AreEqual(1, sut.UserLinks.Count);
        }

        [Test]
        public void Can_assign_a_board_to_a_project()
        {
            var sut = new Project();
            var board = new Board();

            sut.Boards.Add(board);

            Assert.AreEqual(1, sut.Boards.Count);
        }

        [Test]
        public void Can_set_the_order_of_a_priority_level()
        {
            var sut = new PriorityLevel { Name = "High", Sequence = 1 };

            Assert.IsNotNull(sut);
            Assert.AreEqual(1, sut.Sequence);
        }

        [Test]
        public void Can_add_a_priority_level_to_a_priority_level_template()
        {
            var sut = new PriorityLevelTemplate();
            var priorityLevel = new PriorityLevel();

            sut.PriorityLevels.Add(priorityLevel);

            Assert.AreEqual(1, sut.PriorityLevels.Count);
        }

        [Test]
        public void Can_assign_a_priority_level_template_to_a_board()
        {
            var sut = new Board();
            var priorityLevel = new PriorityLevelTemplate { Id = 1, Name = "Default" };

            sut.PriorityLevelTemplate = priorityLevel;

            Assert.AreEqual("Default", sut.PriorityLevelTemplate.Name);
        }

        //[Test]
        //public void Can_assign_a_bug_priority_level_template_to_a_board()
        //{
        //    var sut = new Board();
        //    var priorityLevel = new PriorityLevelTemplate { Id = 1, Name = "Bugs" };

        //    sut.BugPriorityLevelTemplate = priorityLevel;

        //    Assert.AreEqual("Bugs", sut.BugPriorityLevelTemplate.Name);
        //}

        [Test]
        public void Can_add_a_complexity_level_template()
        {
            var sut = new ComplexityLevelTemplate { Name = "Default", DisplayName = "Story Points" };

            Assert.IsNotNull(sut);
            Assert.AreEqual("Default", sut.Name);
            Assert.AreEqual("Story Points", sut.DisplayName);
        }

        [Test]
        public void Can_add_a_complexity_level()
        {
            var sut = new ComplexityLevel();

            Assert.IsNotNull(sut);
        }

        [Test]
        public void Can_set_the_order_of_a_complexity_level()
        {
            var sut = new ComplexityLevel { Name = "8", Sequence = 1 };

            Assert.IsNotNull(sut);
            Assert.AreEqual(1, sut.Sequence);
        }

        [Test]
        public void Can_add_a_complexity_level_to_a_complexity_level_template()
        {
            var sut = new ComplexityLevelTemplate();
            var complexityLevel = new ComplexityLevel();

            sut.ComplexityLevels.Add(complexityLevel);

            Assert.AreEqual(1, sut.ComplexityLevels.Count);
        }

        [Test]
        public void Can_assign_a_complexity_level_template_to_a_board()
        {
            var sut = new Board();
            var complexityLevel = new ComplexityLevelTemplate { Id = 1, Name = "Default" };

            sut.ComplexityLevelTemplate = complexityLevel;

            Assert.AreEqual("Default", sut.ComplexityLevelTemplate.Name);
        }

        [Test]
        public void Can_add_a_blocker()
        {
            var sut = new Blocker();

            Assert.IsNotNull(sut);
        }

        [Test]
        public void Can_assign_a_blocker_to_a_card()
        {
            var sut = new Card();
            var blocker = new Blocker();

            sut.Blockers.Add(blocker);

            Assert.AreEqual(1, sut.Blockers.Count);
        }

        [Test]
        public void Can_add_a_comment()
        {
            var sut = new Comment();

            Assert.IsNotNull(sut);
        }

        [Test]
        public void Can_add_a_bug()
        {
            var sut = new Bug();

            Assert.IsNotNull(sut);
        }

        [Test]
        public void Can_assign_a_bug_to_a_card()
        {
            var sut = new Card();
            var bug = new Bug();

            sut.Bugs.Add(bug);

            Assert.AreEqual(1, sut.Bugs.Count);
        }

        [Test]
        public void Can_add_a_scenario()
        {
            var sut = new Scenario();

            Assert.IsNotNull(sut);
        }

        [Test]
        public void Can_assign_a_scenario_to_a_card()
        {
            var sut = new Card();
            var scenario = new Scenario();

            sut.Scenarios.Add(scenario);

            Assert.AreEqual(1, sut.Scenarios.Count);
        }

        [Test]
        public void Can_assign_a_bug_to_a_scenario()
        {
            var sut = new Scenario();
            var bug = new Bug();

            sut.Bugs.Add(bug);

            Assert.AreEqual(1, sut.Bugs.Count);
        }

        [Test]
        public void Can_add_a_sprintGoal()
        {
            var sut = new SprintGoal();

            Assert.IsNotNull(sut);
        }

        [Test]
        public void Can_assign_a_sprintGoal_to_a_card()
        {
            var sut = new Card();
            var sprintGoal = new SprintGoal { Name = "Test Sprint Goal" };

            sut.SprintGoal = sprintGoal;

            Assert.AreEqual("Test Sprint Goal", sut.SprintGoal.Name);
        }

        [Test]
        public void Can_add_a_task()
        {
            var sut = new Fixie.Models.Task();

            Assert.IsNotNull(sut);
        }

        [Test]
        public void Can_assign_a_task_to_a_card()
        {
            var sut = new Card();
            var task = new Fixie.Models.Task();

            sut.Tasks.Add(task);

            Assert.AreEqual(1, sut.Tasks.Count);
        }
    }
}
