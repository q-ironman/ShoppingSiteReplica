﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ShoppinSiteReplica.Services
{
    public class ServiceActivator 
    {
        public static T Get<T>()
        {
            Assembly asm = Assembly.GetAssembly(typeof(T));
            var type = asm.GetType();
            foreach(var ty in asm.GetTypes())
            {
                if(ty.IsInterface == false && ty.GetInterfaces().Contains(typeof(T)))
                {
                    type = ty;
                    break;
                }
            }
            return (T)asm.CreateInstance(type.FullName);
        }
    }
}
