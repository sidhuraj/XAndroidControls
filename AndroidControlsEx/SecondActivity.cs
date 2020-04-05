using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidControlsEx
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.secondlayout);


            Button btnOne = FindViewById<Button>(Resource.Id.btnOne);
            btnOne.Click += BtnOne_Click;

        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
          
        }
    }
}