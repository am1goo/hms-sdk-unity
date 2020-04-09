﻿namespace HuaweiMobileServices.Id
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.support.api.entity.auth.PermissionInfo
    public class PermissionInfo : JavaObjectWrapper
    {

        private static readonly string CLASS_NAME = "com.huawei.hms.support.api.entity.auth.PermissionInfo";

        public PermissionInfo() : base(CLASS_NAME) { }

        public PermissionInfo(string appID, string packageName, string permission) 
            : base(CLASS_NAME, appID.AsJavaString(), packageName.AsJavaString(), permission.AsJavaString()) { }

        public virtual string AppID
        {
            get => CallAsString("getAppID");
        }


        public virtual string PackageName
        {
            get => CallAsString("getPackageName");
        }


        public virtual string Permission
        {
            get => CallAsString("getPermission");
        }


        public virtual PermissionInfo SetPermissionUri(string uri)
        {
            JavaObject = Call<AndroidJavaObject>("setPermissionUri", uri.AsJavaString());
            return this;
        }
    }

}