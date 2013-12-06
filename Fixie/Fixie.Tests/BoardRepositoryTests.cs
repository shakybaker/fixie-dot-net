using Fixie.Infrastructure;
using Fixie.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixie.Tests
{
    [TestFixture]
    public class BoardRepositoryTests
    {
        [Test]
        public void Save_should_return_id_of_saved_board()
        {
            var mock = new Mock<IBoardRepository>();
            mock.Setup(x => x.Save(It.IsAny<Board>())).Returns(1);

            var actual = mock.Object.Save(new Board());
            Assert.AreEqual(1, actual);
        }

        [Test]
        public void Find_all_should_return_results()
        {
            var mock = new Mock<IBoardRepository>();
            var boards = new List<Board> { new Board { Id = 1, Name = "Test" } };
            mock.Setup(x => x.FindAll()).Returns(boards);

            var actual = mock.Object.FindAll();
            Assert.AreEqual(1, actual.FirstOrDefault().Id);
        }

        [Test]
        public void Find_should_return_a_result()
        {
            var mock = new Mock<IBoardRepository>();
            var boards = new List<Board> { new Board { Id = 1, Name = "Test" } };
            mock.Setup(x => x.Find(It.IsAny<string>())).Returns(boards);

            var actual = mock.Object.Find("Test");
            Assert.AreEqual(1, actual.FirstOrDefault().Id);
        }
    }
}
