using FluentValidation;


namespace Application.Users.Commands.CreateUser
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(createUserCommand =>
                createUserCommand.User_Name).NotEmpty().MaximumLength(30).MinimumLength(3);
        }
    }
}