// See https://aka.ms/new-console-template for more information

using MailJetEmailService;

Console.WriteLine("Sending Mail....");

EmailService emailService = new ();
await emailService.SendEmailAsync();
Console.WriteLine("Mail Sent Successfully");
