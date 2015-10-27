﻿//-----------------------------------------------------------------------
// <copyright file="NFIPlugin.cs">
//     Copyright (C) 2015-2015 lvsheng.huang <https://github.com/ketoo/NFrame>
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFrame
{
    public class NFIPlugin : NFBehaviour
    {
        public NFIPlugin()
        {

        }
        public virtual void Install(){}
        public virtual void UnInstall(){}

        public override void Init()
        {
            foreach(var v in mxPluginModule)
            {
                v.Value.Init();
            }
        }

        public override void AfterInit()
        {
            foreach (var v in mxPluginModule)
            {
                v.Value.Init();
            }
        }

        public override void BeforeShut()
        {
            foreach (var v in mxPluginModule)
            {
                v.Value.BeforeShut();
            }
        }

        public override void Shut()
        {
            foreach (var v in mxPluginModule)
            {
                v.Value.Shut();
            }
        }

        public override void Execute() 
        {
            foreach (var v in mxPluginModule)
            {
                v.Value.Execute();
            }
        }


        private Dictionary<string, NFBehaviour> mxPluginModule;
    }
}
