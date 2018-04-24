using OSyM.Forms;
using OSyM.Objects;
using OSyM.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSyM.Controllers
{
    public class AccountController : Controller<AccountRequest>
    {
        public ControllerTypes ControllerType => throw new NotImplementedException();

        public void requestLoginForm()
        {
            LogInForm form = new LogInForm();
            form.createForm();
        }

        public Account verifyAccount(Account account)
        {
            var user = App.user[account.UserName];
            if (user.Password != account.Password)
                throw new UnauthorizedAccessException();
            return user;
        }

        public void requestAccount(Account account)
        {

        }

        public void displayAccounts()
        {

        }

        public void displayDetailedProfile(Account account)
        {

        }

        public void submitUpdatedProfile(Account account)
        {

        }

        public void deleteUserAccount(Account account)
        {

        }

        public void requestAddUserForm()
        {

        }


        public bool displayConfirmation(string message)
        {
            throw new NotImplementedException();
        }

        public void executeRequest(AccountRequest request)
        {
            throw new NotImplementedException();
        }
    }

    public class AccountRequest : Request { }
}
