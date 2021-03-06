﻿/*
--------------------------------------------------
| Copyright © 2008 Mr-Alan. All rights reserved. |
| Website: www.0x69h.com                         |
| Mail: mr.alan.china@gmail.com                  |
| QQ: 835988221                                  |
--------------------------------------------------
*/

using System.Collections.Generic;
using UnityEngine;
using BlackFire.Unity.Network;

namespace BlackFire.Unity
{
    public sealed partial class NetworkManager
    {
        private readonly Dictionary<string, TransportBase> m_DicTransport = new Dictionary<string, TransportBase>();
        private readonly static object s_TransportCollectionLock = new object();

        private void AddTransport(string transportAlias, TransportBase transportBase)
        {
            lock (s_TransportCollectionLock)
            {
                if (!m_DicTransport.ContainsKey(transportAlias))
                {
                    m_DicTransport.Add(transportAlias, transportBase);
                }
            }
        }

        private void RemoveTransport(string transportAlias)
        {
            lock (s_TransportCollectionLock)
            {
                if (m_DicTransport.ContainsKey(transportAlias))
                {
                    m_DicTransport.Remove(transportAlias);
                }
            }
        }

        public bool HasTransport(string transportAlias)
        {
            return m_DicTransport.ContainsKey(transportAlias);
        }


        public TransportBase GetTransport(string transportAlias)
        {
            if (m_DicTransport.ContainsKey(transportAlias))
            {
                return m_DicTransport[transportAlias];
            }
            return null;
        }

        private void CheckTransportExistsOrThrow(string transportAlias)
        {
            if (HasTransport(transportAlias)) throw new System.Exception("The transport already exists!");
        }
    }
}
