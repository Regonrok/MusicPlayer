using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Support.V7.App;
using Android.Support.Design.Widget;
using Android.Content;

namespace MobileView
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private TextView _textMessage;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            _textMessage = FindViewById<TextView>(Resource.Id.message);

            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.NavigationItemSelected += (s, e) =>
            {
                switch (e.Item.ItemId)
                {
                    case Resource.Id.music_player_dashboard:
                        // Create message for user
                        Toast.MakeText(this, Resource.String.player_dashboard, ToastLength.Short).Show();
                        break;
                    case Resource.Id.local_files_dashboard:
                        //start LocalFilesActivity
                        Intent localFiles = new Intent(this, typeof(LocalFileListActivity));
                        StartActivity(localFiles);
                        break;
                }
            };
        }
    }
}

