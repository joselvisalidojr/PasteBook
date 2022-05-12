using Microsoft.AspNetCore.Mvc;
using PasteBook.Data.Models;
using PasteBook.WebApi.Services;
using System.Collections.Generic;
using WorkSchedule.Data;

namespace PasteBook.WebApi.Controllers
{
    [Route("UserAccount")]
    [ApiController]
    public class UserAccountController
    {

        private readonly IUserAccountService userAccountService;
        private readonly IUnitOfWork unitOfWork;

        public UserAccountController(IUserAccountService userAccountService, IUnitOfWork unitOfWork)
        {
            this.userAccountService = userAccountService;
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IEnumerable<UserAccount> UserAccounts()
        {
            //return userAccountService.GetAllUser();
            return unitOfWork.UserAccountRepository.Context.UserAccounts;
        }
    }
}
