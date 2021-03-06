/*
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
    /// RawImage模板。
    /// </summary>
    public class RawImageTemplate : UITemplate,IRawImageTemplate
    {
        public UnityEngine.UI.RawImage RawImage;

        /// <summary>
        /// 贴图。
        /// </summary>
        public Texture Texture
        {
            get { return RawImage.texture;}
            set { RawImage.texture = value; }
        }

        /// <summary>
        /// 是否可交互。
        /// </summary>
        public bool Interactable
        {
            get
            {
                return RawImage.raycastTarget; 
            }
            set
            {
                RawImage.raycastTarget = value;
            }
        }

        /// <summary>
        /// 图片的颜色。
        /// </summary>
        public Color Color
        {
            get { return RawImage.color;}
            set { RawImage.color = value; }
        }
    }
}