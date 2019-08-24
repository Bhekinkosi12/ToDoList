using System;
using System.Windows.Input;
using ToDoList.Models;
using ToDoList.Views;
using Xamarin.Forms;

namespace ToDoList.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ICommand DeleteCommand { get; private set; }

        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;

            MessagingCenter.Subscribe<ItemDetailPage, Item>(this, "SaveItem", async (obj, aItem) =>
            {
                var newItem = aItem as Item;
                await DataStore.UpdateItemAsync(newItem); //AddItemAsync(newItem);
            });

            MessagingCenter.Subscribe<ItemDetailPage, Item>(this, "DelItem", async (obj, aItem) =>
            {
                var newItem = aItem as Item;
                await DataStore.DeleteItemAsync(newItem); //AddItemAsync(newItem);
            });

        }
    }
}
