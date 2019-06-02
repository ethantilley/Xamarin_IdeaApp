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

    public class IdeaCardManager
    {
        public static List<IdeaClass> ideaCards = new List<IdeaClass>(1);
        public static void AddCard(string _title, string _description)
        {
            ideaCards.Add(new IdeaClass(_title, _description));
          //  titles.Add(_title);

        }
        
    }
}