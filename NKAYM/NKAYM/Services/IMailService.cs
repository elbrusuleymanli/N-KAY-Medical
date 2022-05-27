using NKAYM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Services
{
   public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
