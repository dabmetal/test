﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHSMarchenko
{    
    public interface IHoverable
    {
        string Tooltip { get; set;}
        Transform TooltipTransform { get; }

        void OnHoverStart(Material _hoverMat);
        void OnHoverEnd();
    }
}
