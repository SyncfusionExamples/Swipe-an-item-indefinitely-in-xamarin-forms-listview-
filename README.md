# Swipe the item indefinitely

Swiped item can be reset by defining the [SfListView.SwipeOffSet](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SwipeEndedEventArgs~SwipeOffset.html) argument of [SfListView.SwipeEnded](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~SwipeEnded_EV.html) event to 0 when the swiping action is completed.

## Sample

```xaml
<sync:SfListView x:Name="listView"
                  ItemTemplate="{StaticResource ItemTemplate}"
                  AllowSwiping="True"
                  SwipeThreshold="30">
    
    <sync:SfListView.RightSwipeTemplate>
        <DataTemplate x:Name="RightSwipeTemplate">
            <code>
            . . .
            . . .
            <code>
        </DataTemplate>
    </sync:SfListView.RightSwipeTemplate>

    <sync:SfListView.LeftSwipeTemplate>
        <DataTemplate x:Name="LeftSwipeTemplate">
            <code>
            . . .
            . . .
            <code>
        </DataTemplate>
    </sync:SfListView.LeftSwipeTemplate>
</sync:SfListView>
```

```
private void ListView_SwipeEnded(object sender, SwipeEndedEventArgs e)
{
  if (e.SwipeOffset > 70)
      e.SwipeOffset = 0;
}
```
To know more about swiping in ListView , please refer our documentation [here](https://help.syncfusion.com/xamarin/sflistview/swiping).