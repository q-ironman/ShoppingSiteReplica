using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSiteReplica.Domain
{
    public class Category
    {
        Guid _id;
        string _name;
        Guid? _parentid;

        public Guid ID { get {return this._id; } set {this._id = value;} }

        public string Name { get { return this._name; } set { this._name = value; } }

        public Guid? ParentID { get { return this._parentid; } set {this._parentid = value; } }






    }
}
