﻿//----------------------------------------------------
//Copyright © 2008-2018 Mr-Alan. All rights reserved.
//Mail: Mr.Alan.China@[outlook|gmail].com
//Website: www.0x69h.com
//----------------------------------------------------

using BlackFire.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlackFire.Unity
{
	public sealed partial class GameManager
    {
#if UNITY_EDITOR

        [SerializeField] private bool m_ProcessScrowFoldOut;

        private void Reset()
        {
            m_AvailableProcesses = null;
        }

#endif
    }
}