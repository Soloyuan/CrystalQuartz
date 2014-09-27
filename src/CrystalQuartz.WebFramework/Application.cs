﻿namespace CrystalQuartz.WebFramework
{
    using System.Reflection;
    using System.Web.Script.Serialization;
    using CrystalQuartz.WebFramework.Config;

    public abstract class Application : EmptyHandlerConfig
    {
        protected Application(Assembly resourcesAssembly, string defaultResourcesProfix) : base(new AppContext(new JavaScriptSerializer(), resourcesAssembly, defaultResourcesProfix))
        {
        }

        public abstract IHandlerConfig Config { get; }
    }
}