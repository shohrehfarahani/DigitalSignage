﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigitalSignageUI.Models.Entity
{
    public class AdsInfo
    {

        public long id { get; set; }

        public string title { get; set; }

        public string adItemTitle { get; set; }

        public string adItemDesc { get; set; }

        public string adItemFeedTitle { get; set; }

        public string adItemImageFileName { get; set; }

        public string adItemVedioFileName { get; set; }

        public string adItemFeedUrl { get; set; }

        public int status { get; set; }

        public int type { get; set; }

        public int max_minutes { get; set; }

        public int passed_minutes { get; set; }


        public List<AdsIemInfo> itemList { get; set; }


        public int shuffle { get; set; }

        public int interval { get; set; }

        public long content_ad_id { get; set; }
        public int position { get; set; }
    }
}