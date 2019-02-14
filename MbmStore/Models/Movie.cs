using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie
    {
        // fields
        private string title; 
        private decimal price; 
        //private string imageUrl; I don't need the private field anymore because I used the auto-implemented method
        private string director;

        // properties
        public string Title
        {
           get { return title; } // read
          // set { title = value; } // write ----If set is commented I won't have the write and it will be read-only
        }

        public decimal Price 
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else {
                    price = value;
                }
            }
            get { return price; }
        }

        //Auto implemented property, in this case I won't need private string image url.
        public string ImageUrl 
        {
            get;
            set;
        }

        public string Director
        {
            get { return director; } // read
            set { director = value; } // write ----
        }

        // constructors are used within the MovieController
        public Movie(string title, decimal price)
        {
            this.title = title;
            this.price = price;
        }

        public Movie(string title, decimal price, string imageUrl, string director)
        {
            this.title = title;
            this.price = price;
            this.ImageUrl = imageUrl; //If I use auto-implemented property, I have to add the image with capital letter
            this.director = director;
        }
    }
}