using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Tests
{
    public class StudentServiceTests
    {
        [Fact]
        public void TestPrepareStudentForTest_WriteInDb()
        {
            // Arrange 
            var student = new Student("Dragan");
            var mockRepo = new Mock<IStudentRepository>();
            mockRepo.Setup(x => x.GetStudentById(1)).Returns(student);
            var service = new StudentService(mockRepo.Object);

            // Act
            var result = service.PrepareStudentForTest(1, 8);

            // Assert
            Assert.True(result);
            mockRepo.Verify(x => x.Save(It.IsAny<Student>()), Times.Once);

        }
        [Fact]
        public void TestPrepareStudentForTest_DontWriteInDb()
        {
            // Arrange 
            var student = new Student("Bogdan");
            var mockRepo = new Mock<IStudentRepository>();
            mockRepo.Setup(x => x.GetStudentById(2)).Returns(student);
            var service = new StudentService(mockRepo.Object);

            // Act
            var result = service.PrepareStudentForTest(2, 3);

            // Assert
            Assert.False(result);
            mockRepo.Verify(x => x.Save(It.IsAny<Student>()), Times.Never);

        }
    }
}
