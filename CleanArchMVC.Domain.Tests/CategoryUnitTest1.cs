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

        [Fact(DisplayName = " Create Category Negative Id Value Result Object Valid State")]
        public void CreateCategory_NegativeIdValue_ResultObjectValidState()
        {
            Action action = () => new Category(-1, "Category Name");
            action.Should().Throw<CleanArchMVC.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id value.");
        }

        [Fact(DisplayName = "Create Category Short Name Value Domain Exception Validation")]
        public void CreateCategory_ShortNameValue_DomainExceptionValidation()
        {
            Action action = () => new Category(1, "Ca");
            action.Should().Throw<CleanArchMVC.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, too short, minimum 3 characters.");
        }

        [Fact(DisplayName = "Create Category Long Name Value Domain Exception Validation")]
        public void CreateCategory_LongNameValue_DomainExceptionValidation()
        {
            Action action = () => new Category(1,
                "dsgsdljgjsdg klsdhksgd ajshabdasdgkBHAHSGkjfhsakfk ahskdhlakhflhhn lakhshflsnsf cjhdkshfkjhshdg" +
                "dsgsdljgjsdg klsdhksgd ajshabdasdgkBHAHSGkjfhsakfk ahskdhlakhflhhn lakhshflsnsf cjhdkshfkjhshdg" +
                "dsgsdljgjsdg klsdhksgd ajshabdasdgkBHAHSGkjfhsakfk ahskdhlakhflhhn lakhshflsnsf cjhdkshfkjhshdg" +
                "dsgsdljgjsdg klsdhksgd ajshabdasdgkBHAHSGkjfhsakfk ahskdhlakhflhhn lakhshflsnsf cjhdkshfkjhshdg");
            action.Should().Throw<CleanArchMVC.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, too long, maximum 40 characters.");
        }

        [Fact(DisplayName = "Create Category Missing Name Value Domain Exception Required Name")]
        public void CreateCategory_MissingNameValue_DomainExceptionRequiredName()
        {
            Action action = () => new Category(1, "");
            action.Should().Throw<CleanArchMVC.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name. Name is required.");
        }

        [Fact(DisplayName = "Create Category With Null Name Value Domain Exception Invalid Name")]
        public void CreateCategory_WithNullNameValue_DomainExceptionInvalidName()
        {
            Action action = () => new Category(1, null);
            action.Should().Throw<CleanArchMVC.Domain.Validation.DomainExceptionValidation>();
        }
    }
}