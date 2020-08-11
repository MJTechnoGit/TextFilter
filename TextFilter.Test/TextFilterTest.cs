using System;
using Xunit;
using TextFilter;
using TextFilter.Services;
using Moq;
using Moq.Internals;
using Shouldly;
using TextFilter.Interfaces;

namespace TextFilter.Test
{
    public class TextFilterTest
    {

        Mock<IFilterService> mockFilterService;
        Mock<IFileService> mockFileService;

        [Theory]
        [InlineData("Files//TextInput.txt")]
        public void File_ShouldReturnSomeText(string FileName)
        {
            //Setup
            mockFileService = new Mock<IFileService>();
            mockFilterService = new Mock<IFilterService>();

            mockFileService.Setup(s => s.ReadFile(FileName));
            
            // Arrange
            var output = mockFileService.Object.ReadFile(FileName);

            // Assert.
            output.ShouldNotBeEmpty();
        }


        [Theory]
        [InlineData("Files//TextInput.txt")]
        public void File_ShouldReturnSomeTextWithVowels(string FileName)
        {
            //Setup
            mockFileService = new Mock<IFileService>();
            mockFilterService = new Mock<IFilterService>();

            mockFileService.Setup(s => s.ReadFile(FileName));
            

            // Arrange
            var output = mockFileService.Object.ReadFile(FileName);

            // Assert.
            output.ShouldNotBeEmpty();
        }

    }
}
