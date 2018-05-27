using Prism.Navigation;
using Prism.Services;

namespace SmartShop.ViewModel
{
    /// <summary>
    /// QRC ode view model.
    /// </summary>
    public class QRCodeViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SmartShop.ViewModel.QRCodeViewModel"/> class.
        /// </summary>
        /// <param name="navigationService">Navigation service.</param>
        /// <param name="pageDialogService">Page dialog service.</param>
        public QRCodeViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            
        }
    }
}
