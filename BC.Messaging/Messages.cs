namespace BC.Messaging
{
    public record UserUpdated(Guid Id, string FirstName, string SecondName, string Email);
    public record UserDeleted(Guid Id, string FirstName, string SecondName, string Email);
}