﻿using System;
using System.Collections.Generic;
using System.Text;
using wojilu.Data;
using wojilu.Common.AppBase.Interface;
using wojilu.Common.AppBase;

namespace wojilu.Apps.Download.Domain {

    public class Platform : CacheObject, ISort, IComparable {

        public int OrderId { get; set; }

        public void updateOrderId() {
            this.update();
        }

        public int CompareTo( object obj ) {
            Platform t = obj as Platform;
            if (this.OrderId > t.OrderId) return -1;
            if (this.OrderId < t.OrderId) return 1;
            if (this.Id > t.Id) return 1;
            if (this.Id < t.Id) return -1;
            return 0;
        }

        //---------------------------------------------------------------

        public static Platform GetById( int id ) {
            return cdb.findById<Platform>( id );
        }

        public static List<Platform> GetAll() {
            List<Platform> list = cdb.findAll<Platform>();
            list.Sort();
            return list;
        }
    }

}
