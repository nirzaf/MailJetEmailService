using Mailjet.Client;
using Mailjet.Client.TransactionalEmails;

namespace MailJetEmailService
{
    public class EmailService
    {
        private readonly IMailjetClient client = new MailjetClient("", "");

        public async Task SendEmailAsync()
        {
            try
            {
                var email = new TransactionalEmailBuilder()
                    .WithFrom(new SendContact("quadrate.lk@gmail.com"))
                    .WithSubject("This is a sample email ")
                    .WithHtmlPart("<h1>Hello World! <style color='Red'> This is a sample email </style></h1>")
                    .WithTo(new SendContact("fazrinphcc@gmail.com"))
                    .Build();

                await client.SendTransactionalEmailAsync(email);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
