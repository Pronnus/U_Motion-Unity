﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static U.Motion.Uanimation;

namespace U.Motion
{
    public static class GameObjectExension
    {
        public static IanimatorCore TweenDelay(this GameObject go, TweenEmpty.Properties p)
        { 


            // Create the tween with added values
            return Uanimation.TweenEmpty.AddComponent(go, p);

        }

    }
}
