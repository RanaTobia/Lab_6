using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9
{
    class StudentInfo
    {
        public string Name;
        public string HomeTown;
        public string FavoritFood;


        // defoult constructor
        public StudentInfo() { }

        // Overloaded constructor
        public StudentInfo(string name)
        {
            Name = name;
        }

        public StudentInfo(string name, string hometown) {
            Name = name;
            HomeTown = hometown;
                   
        }

        public StudentInfo(string name, string hometown, string favoritfood)
        {
            Name = name;
            HomeTown = hometown;
            FavoritFood = favoritfood;

        }


    }
}


///*************************************************************
///
//public string Name;
//public string HomeTown;
//public string FavoriteFood;
//​
//        //default constructor
//        public StudentInfo() { }
//​
//        //overloaded constructor
//        public StudentInfo(string name)
//{
//    Name = name;
//}
//​
//        public StudentInfo(string name, string homeTown)
//{
//    Name = name;
//    HomeTown = homeTown;
//}
//​
//        public StudentInfo(string name, string homeTown, string favoriteFood)
//{
//    Name = name;
//    HomeTown = homeTown;
//    FavoriteFood = favoriteFood;
//}
//    }





