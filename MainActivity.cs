using System.Threading.Tasks;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using RestSharp;

namespace RandomContact
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView listView;
        View loading;

        UserService userService;

        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            listView = FindViewById<ListView>(Resource.Id.listViewUser);
            loading = FindViewById<View>(Resource.Id.layoutLoading);

            listView.Visibility = ViewStates.Gone;
            loading.Visibility = ViewStates.Visible;

            await LoadUserProfiles();

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private async Task<bool> LoadUserProfiles()
        {
            userService = new UserService();
            var users = await userService.GetUserProfiles();

            listView.Adapter = new UserProfileListAdapter(this, users);
            

            listView.Visibility = ViewStates.Visible;
            loading.Visibility = ViewStates.Gone;

            return true;
        }
        
    }
}