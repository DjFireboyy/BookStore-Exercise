using System;
using BookStore.Models.Requests;
using FluentValidation;

namespace BookStore.Validators
{
	public class TestRequestValidator : AbstractValidator<TestRequest>
	{

		public TestRequestValidator()
		{
			RuleFor(expression: TestRequest => x.Id)

				.NotNull()
				.GreaterThanOrEqualTo(1);

            RuleFor(expression: x => x.Name)
                .NotNull()
                .NotEmpty()
                .MaximumLength(2)
                .MaximumLength(50);


		}
	}
}

