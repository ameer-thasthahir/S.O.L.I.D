using System;

namespace SingleResposibility.Demostration.Correct
{
    class RegisterService
    {
        private readonly IUserRepository userRepository;
        private readonly IMailService mailService;

        public RegisterService(IUserRepository userRepository, IMailService mailService)
        {
            this.userRepository = userRepository;
            this.mailService = mailService;
        }
        public void RegisterUser(string username)
        {
            if (username == "admin")
                throw new InvalidOperationException();

            userRepository.Insert();

            mailService.SendMail();
        }
    }
}
