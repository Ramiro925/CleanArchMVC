using CleanArchMVC.Domain.Entities;
using FluentAssertions;
namespace CleanArchMVC.Domain.Tests

{
    public class CategoryUnitTest1
    {
        [Fact(DisplayName = " Create Category With Parameters Result Object Valid State")]
        public void CreateCategory_WithParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should()
                .NotThrow<CleanArchMVC.Domain.Validation.DomainExceptionValidation>();
        }
    }
}