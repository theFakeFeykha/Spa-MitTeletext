﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaßMitTeletext
{
    class Teletext
    {
        public enum NR {111, 222, 333, 444, 555 };

        private string Name;
        private string desc;
        private NR nr;
        private DateTime date;

        public Teletext(string name, string desc, int nr, DateTime date)
        {
            this.Name1=name;
            this.Desc = desc;
            this.Nr = nr;
            this.Date = date;
        }

        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public string Desc
        {
            get
            {
                return desc;
            }

            set
            {
                desc = value;
            }
        }

        public NR Nr
        {
            get
            {
                return nr;
            }

            set
            {
                nr = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }


    }
}
