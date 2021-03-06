﻿/*
--------------------------------------------------
| Copyright © 2008 Mr-Alan. All rights reserved. |
| Website: www.0x69h.com                         |
| Mail: mr.alan.china@gmail.com                  |
| QQ: 835988221                                  |
--------------------------------------------------
*/

using UnityEngine;


namespace BlackFire.Unity
{
    /// <summary>
    /// 管家抽象基类。
    /// </summary>
    [GameObjectIcon("Manager")]
    public abstract class ManagerBase : MonoBehaviour, IManager
    {
        //是否在工作状态。
        public virtual bool IsWorking
        {
            get
            {
                return enabled && gameObject.activeSelf;
            }
        }

        void IManager.StartManager()
        {
            //注册进BlackFire管家管理模块。
            App.RegisterManager(this);
            OnStart();
        }
        private void Update()
        {
            OnUpdate();
        }
        void IManager.ShutdownManager()
        {
            //注销BlackFire管家管理模块。
            App.UnRegisterManager(this);
            OnShutdown();
            DestroyImmediate(gameObject);
        }


        protected T GetModule<T>() where T : IModule
        {
            return App.ModuleManager.GetModule<T>();
        }

        protected void RegisterModule<T>() where T : IModule
        {
            App.ModuleManager.Register<T>();
        }

        protected void UnRegisterModule<T>() where T : IModule
        {
            App.ModuleManager.UnRegister<T>();
        }

        /// <summary>
        /// 模块被启动事件。
        /// </summary>
        protected virtual void OnStart()
        {

        }
        
        /// <summary>
        /// 模块被轮询事件。
        /// </summary>
        protected virtual void OnUpdate()
        {

        }
        
        /// <summary>
        /// 模块被关闭事件。
        /// </summary>
        protected virtual void OnShutdown()
        {

        }

    }
}
