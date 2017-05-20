using Client.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;

namespace Client.iOS.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() 
            : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var bindingSet = this.CreateBindingSet<FirstView, FirstViewModel>();
            bindingSet.Bind(Percentage).To(vm => vm.Percentage);
            bindingSet.Bind(Mute).To(vm => vm.MuteCommand);
            bindingSet.Apply();
        }
    }
}

