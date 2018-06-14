using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace MobileView
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class LocalFileListActivity : Activity
    {
        private List<string> _countries = new List<string>() { "country 1", "country 1" , "country 1" , "country 1" , "country 1" };

        RecyclerView mRecyclerView;
        RecyclerView.LayoutManager mLyoutManager;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.list_local_files);


            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.NavigationItemSelected += (s, e) =>
            {
                switch (e.Item.ItemId)
                {
                    case Resource.Id.music_player_dashboard:
                        //start LocalFilesActivity
                        Intent player = new Intent(this, typeof(MainActivity));
                        StartActivity(player);
                        break;
                    case Resource.Id.local_files_dashboard:
                        //
                        Toast.MakeText(this, Resource.String.local_dashboard,ToastLength.Short).Show();
                        break;
                }
            };

        }

    }
}