using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.ViewModels;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public ActionResult Index()
        {
            // genre list:
            var genres = new List<string> { "Rock", "Jazz", "Country", "Pop", "Disco" };

            // create view model:
            var viewModel = new StoreIndexViewModel
            {
                NumberOfGenre = genres.Count(),
                Genres = genres
            };

            ViewBag.Starred = new List<string> { "Rock", "Jazz" };
            return View(viewModel);

        }

        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre()
            {
                Name = genre
            };

            var albums = new List<Album>()
            {
                new Album() {Tittle = genre + " Album 1"},
                new Album() {Tittle = genre + " Album 2"}
            };

            var viewModel = new StoreBrowseViewModel()
            {
                Genre = genreModel,
                Albums = albums
            };
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var album = new Album { Tittle = "Sample Album" };
            return View(album);
        }

    }
}
