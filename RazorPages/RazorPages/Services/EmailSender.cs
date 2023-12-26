using Microsoft.AspNetCore.Identity.UI.Services;
using System.Diagnostics;
namespace RazorPages.Services
{
    public class EmailSender : IEmailSender
    {
        public EmailSender() { }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            Debug.WriteLine("");
            Debug.WriteLine("Email Confirmation Message");
            Debug.WriteLine("--------------------------");
            Debug.WriteLine($"TO: {email}");
            Debug.WriteLine($"SUBJECT: {subject}");
            Debug.WriteLine($"CONTENTS: {htmlMessage}");
            Debug.WriteLine("");

            return Task.CompletedTask;
        }
    }
}
