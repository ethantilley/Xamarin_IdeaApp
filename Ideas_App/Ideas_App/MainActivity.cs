using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Ideas_App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        TextView titleTxt, descTxt;
        //int number;
        ListView mIdeasView;

        public List<string> titles = new List<string>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            titleTxt = FindViewById<TextView>(Resource.Id.titleText);
            descTxt = FindViewById<TextView>(Resource.Id.descriptionText);

            titles.Add("Test Title" + " \n \n" + "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque risus dolor, commodo accumsan ex non, fermentum porta purus. " +
                "Aenean justo ex, dignissim id finibus non, luctus nec elit. ");

            FindViewById<Button>(Resource.Id.createIdeaButton).Click += (o, e) =>
               AddIdea(titleTxt.Text, descTxt.Text);
           

            mIdeasView = FindViewById<ListView>(Resource.Id.ideaList);

            mIdeasView.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, titles);


            //txtNumber = FindViewById<TextView>(Resource.Id.txtDisplay);

            //FindViewById<Button>(Resource.Id.bttnDecrement).Click += (o, e) =>
            //    txtNumber.Text = (--number).ToString();


        }

        public void AddIdea(string _title, string _description)
        {
            titles.Add(_title + " \n \n" +  _description);
            mIdeasView.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, titles);

            titleTxt.Text = null;
            descTxt.Text = null;

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
	}
}

