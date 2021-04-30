﻿using UnityEditor;
using UnityEngine;

namespace U.Motion
{

    public class TweenVector3 : TweenAnimator<float, float, float> { }

#if UNITY_EDITOR

    [CustomEditor(typeof(TweenVector3))]
    public class TweenVector3InspectorExtension : TweenAnimatorCoreInspectorExtension { }

#endif
}