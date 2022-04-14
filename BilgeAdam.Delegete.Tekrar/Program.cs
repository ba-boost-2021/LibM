namespace BilgeAdam.Delegate.Tekrar
{
    class Program
    {
        public static void Main(string[] arg)
        {
            var newUser = new User();
            newUser.onCreateUser += SendNotification;
            newUser.onCreateUser += SendMail;
            newUser.onCreateUser += SendSms;
            newUser.CreateNewUser("Sergen", "sergen@mail.com", "123456");

        }
        private static void SendSms(User payload)
        {
            //sms gönderdik
        }

        private static void SendMail(User payload)
        {
            //mail gönderdik
        }

        private static void SendNotification(User payload)
        {
            //notification gönderdik
        }
    }
}
