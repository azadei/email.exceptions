using System;

public class EmailValidator
{
    public bool Validate(string email)
    {
        if (email.Length < 10)
        {
            throw new Exception("Email address is too short.");
        }

        if (!email.EndsWith("@mail.com"))
        {
            throw new Exception("Not a valid email address.");
        }

        return true;
    }

}   public class Program
{

    static void Main(string[] args)
    {
        var emailValidator = new EmailValidator();

        try
        {
            bool isValid = emailValidator.Validate("azad@mail.com");
            Console.WriteLine(isValid);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
}
