using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class MediaModel
    {
        public Guid Id { get; set; }
        public MediaItemsModel[] mediaItems { get; set; }
    }
}