﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHSMarchenko
{    
    public interface IPickable
    {
        Rigidbody Rigid {get;set;}

        void OnPickUp();
        void OnHold();
        void OnRelease();
    }
}
