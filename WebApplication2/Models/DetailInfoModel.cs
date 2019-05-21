using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class DetailInfoModel
    {
        public bool HasPromotionLabel { get; set; }
        public int PromotionLabelType { get; set; }
        public int RibbonColor { get; set; }
        public string RibbonText { get; set; }
        public string Tagline { get; set; }
    }
}