using CleanArchMVC.Domain.Entities;
using FluentAssertions;
using Xunit;
namespace CleanArchMVC.Domain.Tests
 
{
    public class CategoryUnitTest1
    {
        [Fact]
        public void CreateCategory_WithParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should()
                .NotThrow<CleanArchMVC.Domain.Validation.DomainExceptionValidation>();
        }
    }
}