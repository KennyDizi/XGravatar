using System.Windows.Input;
using XGravatar.SourceCode.Utilities.Email;
using XGravatar.SourceCode.Utilities.Gravatar;
using XGravatar.SourceCode.Utilities.Mvvm;

namespace XGravatar.SourceCode.Views
{
    public class TestPageViewModel : BindableBase
    {
        //Avatar
        private string _avatar;

        public string Avatar
        {
            get { return _avatar; }
            set { Set(() => Avatar, ref _avatar, value); }
        }
        //Email
        private string _email;

        public string Email
        {
            get { return _email; }
            set { Set(() => Email, ref _email, value); }
        }
        //ErrorText
        private string _errorText;

        public string ErrorText
        {
            get { return _errorText; }
            set { Set(() => ErrorText, ref _errorText, value); }
        }
        //GetAvatarCommand
        private DelegateCommand _getAvatarCommand;

        public ICommand GetAvatarCommand
            => _getAvatarCommand ?? (_getAvatarCommand = new DelegateCommand(GetAvatarCommandAction));

        private void GetAvatarCommandAction()
        {
            ErrorText = string.Empty;
            if (!ValidEmailUtils.IsValidEmail(Email))
            {
                ErrorText = "Please enter true email address!";
                return;
            }
            Avatar = GravatarUtils.GetGravatar(Email);
        }
    }
}
