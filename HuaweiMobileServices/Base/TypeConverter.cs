﻿using System;
using UnityEngine;

namespace HuaweiMobileServices.Base
{

    internal static class TypeConverter
    {
        public static T AsWrapper<T>(this AndroidJavaObject javaObject) where T : JavaObjectWrapperByConstructor =>
            Activator.CreateInstance(typeof(T), javaObject) as T;
    }
}
