using System.Text.RegularExpressions;
using WebApplication1.Models;

namespace IlukhinDanilKt_31_22.Tests
{
    public class CafedreTests
    {
        [Fact]
        public void IsValidCafedreName_IVT_True()
        {
            // arrange
            var testCafedre = new CafedreTest
            {
                CafedreName = "IVT"
            };

            // act
            var result = testCafedre.IsValidCafedreName();

            // assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidCafedreCreationDate_19900102_True()
        {
            // arrange
            var testCafedre = new CafedreTest
            {
                CafedreCreationDate = DateTime.Parse("1990-01-02T00:00:00.000Z")
            };

            // act
            var result = testCafedre.IsValidCafedreCreationDate();

            // assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidCafedreMainProfessor_Titov_True()
        {
            // arrange
            var testCafedre = new CafedreTest
            {
                CafedreMainProfessor = "Ivan Ivanovich titov"
            };

            // act
            var result = testCafedre.IsValidCafedreMainProfessor();

            // assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidCafedreProfessorsAmount_5_True()
        {
            // arrange
            var testCafedre = new CafedreTest
            {
                CafedreProfessorsAmount = 5
            };

            // act
            var result = testCafedre.IsValidCafedreProfessorAmount();

            // assert
            Assert.True(result);
        }
    }

    public class CafedreTest : Cafedre
    {
        public bool IsValidCafedreName()
        {
            return Regex.Match(CafedreName, @"^[a-zA-Zа-яА-Я\s]+$").Success;
        }

        public bool IsValidCafedreCreationDate()
        {
            return CafedreCreationDate > new DateTime(1980, 1, 1) && CafedreCreationDate < DateTime.Today;
        }

        public bool IsValidCafedreMainProfessor()
        {
            return Regex.Match(CafedreMainProfessor, @"^[a-zA-Zа-яА-Я\s]+$").Success;
        }

        public bool IsValidCafedreProfessorAmount()
        {
            return CafedreProfessorsAmount < 10000;
        }
    }
}
