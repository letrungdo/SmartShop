using System;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;

namespace SmartShop.ViewModel
{
    /// <summary>
    /// View model base.
    /// </summary>
    public class ViewModelBase : BindableBase, INavigationAware, IDestructible
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SmartShop.ViewModel.ViewModelBase"/> class.
        /// </summary>
        /// <param name="navigationService">Navigation service.</param>
        /// <param name="pageDialogService">Page dialog service.</param>
        public ViewModelBase(INavigationService navigationService, IPageDialogService pageDialogService)
        {

        }

        /// <summary>
        /// Destroy this instance.
        /// </summary>
        public void Destroy()
        {
            
        }

        /// <summary>
        /// Ons the navigated from.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        /// <summary>
        /// Ons the navigated to.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        public void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }

        /// <summary>
        /// Ons the navigating to.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        public void OnNavigatingTo(NavigationParameters parameters)
        {
            
        }
    }
}
