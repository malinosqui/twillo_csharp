using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace TwilloTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SendSMS();
            Console.ReadKey();
        }

        static void SendSMS()
        {
            try
            {
                const string accountSid = "AC912768b37ad413e8d3abd5711005b0e7";
                const string authToken = "auth_token";

                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.Create(
                    to: new PhoneNumber("+5514981169227"),
                    from: new PhoneNumber("+14845772310 "),
                    body: "Hello from C#");

                Console.WriteLine("Mensagem enviada");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao enviar mensagem: " + ex.Message);
            }
        }
    }
}
