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

namespace Ideas_App
{
    [System.Serializable]
    public class IdeaClass
    {

        public IdeaClass(string _title, string _desciption)
        {
            title = _title;
            desciption = _desciption;
        }

        public string title = "Empty Title", desciption = "Empty idea description about a blank idea that holds no desciption";
                
        public int starRating = 5;

    }
}