﻿using Xamarin.Forms;
using XamarinCRM.Views.Base;
using XamarinCRM.Statics;
using XamarinCRM.Cells;

namespace XamarinCRM.Views.Sales
{
    public class LeadListView : BaseNonPersistentSelectedItemListView
    {
        public LeadListView()
        {
            HasUnevenRows = false; // Circumvents calculating heights for each cell individually. The rows of this list view will have a static height.
            RowHeight = (int)Sizes.LargeRowHeight; // set the row height for the list view items
            SeparatorVisibility = SeparatorVisibility.None; // make the row separators invisible, per the intended design of this app
            ItemTemplate = new DataTemplate(typeof(LeadListItemCell));
        }
    }
}
