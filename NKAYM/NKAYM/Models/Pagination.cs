using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Models
{
    public class Pagination
    {
        public Pagination(List<PhotoGallery>photos,int page,int size)
        {
            this.PhotoGalleries = photos.Skip(size * (page - 1)).Take(size).ToList();
            this.TotalPages = (int)Math.Ceiling(photos.Count / (double)size);
            this.CurrentPage = page;
            this.HasBefore = page > 1;
            this.HasAfter = page < TotalPages;
        }
        public List<PhotoGallery> PhotoGalleries { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public bool HasBefore { get; set; }
        public bool HasAfter { get; set; }
    }
}
