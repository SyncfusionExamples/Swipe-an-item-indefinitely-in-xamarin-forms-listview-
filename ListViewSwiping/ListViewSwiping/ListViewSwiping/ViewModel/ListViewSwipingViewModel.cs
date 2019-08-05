using ListViewSwiping;
using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Swiping
{
    public class ListViewSwipingViewModel
    {
        #region Fields

        private ObservableCollection<ListViewInboxInfo> inboxInfo;
        private Command favoritesImageCommand;
        private Command deleteImageCommand;
        internal SfListView sfListView;

        #endregion

        #region Constructor

        public ListViewSwipingViewModel()
        {
            GenerateSource();

        }

        #endregion

        #region Properties

        public ObservableCollection<ListViewInboxInfo> InboxInfo
        {
            get { return inboxInfo; }
            set { this.inboxInfo = value; }
        }

        internal int ItemIndex
        {
            get;
            set;
        }

        public Command FavoritesImageCommand
        {
            get { return favoritesImageCommand; }
            protected set { favoritesImageCommand = value; }
        }

        public Command DeleteImageCommand
        {
            get { return deleteImageCommand; }
            protected set { deleteImageCommand = value; }
        }

        #endregion

        #region Generate Source

        private void GenerateSource()
        {
            ListViewInboxInfoRepository inboxinfo = new ListViewInboxInfoRepository();
            inboxInfo = inboxinfo.GetInboxInfo();
            deleteImageCommand = new Command(Delete);
            favoritesImageCommand = new Command(SetFavorites);
        }

        private void Delete()
        {
            App.Current.MainPage.DisplayAlert("Deleted!", "Item successfully deleted", "OK");
            if (ItemIndex >= 0)
                InboxInfo.RemoveAt(ItemIndex);
            sfListView.ResetSwipe();
        }

        private void SetFavorites()
        {
            if (ItemIndex >= 0)
            {
                var item = InboxInfo[ItemIndex];
                item.IsFavorite = !item.IsFavorite;
            }
            sfListView.ResetSwipe();
        }
        
        #endregion
    }
}
