﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.Cognizant.MovieCruiser.Model;
using Com.Cognizant.MovieCruiser.Dao;
using Com.Cognizant.MovieCruiser.Utility;


namespace MovieCruiser
{
    public partial class RemoveFavorites : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                int movieId = Convert.ToInt32(Request.QueryString["id"].ToString());
                FavoritesDaoCollection movieList = new FavoritesDaoCollection();
                movieList.RemoveMovie(94944, movieId);
                RemoveFavorite.DataSource = FavoritesDaoCollection.userCart[94944];
                RemoveFavorite.DataBind();
            }
        }
    }
}