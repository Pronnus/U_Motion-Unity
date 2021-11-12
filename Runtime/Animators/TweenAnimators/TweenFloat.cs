using System;
using System.Linq;
using UnityEditor;
using UnityEngine.Events;
using UnityEngine;

namespace U.Motion
{
    public partial class Uanimation
    {
        public class TweenFloat : TweenAnimatorCore<float>
        {

            #region Factory

            [Serializable]
            public class Properties
            {
                public string animationName = "";
                public bool playOnAwake = true;
                public float delay = 0;
                public float duration = 2;
                public int iterations = 1;
                public Direction direction = Direction.Normal;
                public FillMode fillMode = FillMode.Both;
                public TimeCurve.TimeCurveMode timeCurveMode = TimeCurve.TimeCurveMode.easeInOut;
                public TimeMode timeMode = TimeMode.DeltaTime;
                public OnCompleteMode onCompleteMode = OnCompleteMode.Destroy;
                public KeysCurveMode keysCurveMode = KeysCurveMode.Slope;
                public bool allowUnexpectedEnd = true; // If true no error will be throw if animation is deleted

                [Space(8)]

                public Keyframe[] keyframes;
                public Action<float> animate;  // Dont show in editor

                [Space(8)]
                public Action onCompleteAction = () => { };
                public UnityEvent onComplete = new UnityEvent();

            }


            [Serializable]
            public class Keyframe
            {
                public int key;
                public float value;
            }



            public static TweenFloat AddComponent(GameObject gameObject, Properties p)
            {
                if (p == null)
                    throw new ArgumentNullException("Tween properties cant be null");

                if (gameObject == null)
                    throw new ArgumentNullException("GameObject cant be null");

                if (p.duration <= 0)
                    throw new ArgumentException("Duration must be grater thar 0");

                if (p.delay < 0)
                    throw new ArgumentException("Delay must be 0 or grater");

                if (p.iterations <= 0)
                    throw new ArgumentException("Iterations must be grater thar 0");



                // Create the Keys Curves
                var keysCurveX = new FloatKeyFramesCurve(p.keyframes.ToDictionary(k => k.key, v => v.value), p.keysCurveMode);

                var c = gameObject.AddComponent<TweenFloat>();

                c.animationName = p.animationName;
                c.playOnAwake = p.playOnAwake;
                c.delay = p.delay;
                c.duration = p.duration;
                c.iterations = p.iterations;
                c.direction = p.direction;
                c.fillMode = p.fillMode;
                c.timeCurve = TimeCurve.SelectTimeCurve(p.timeCurveMode);
                c.timeMode = p.timeMode;
                c.onCompleteMode = p.onCompleteMode;
                c.allowUnexpectedEnd = p.allowUnexpectedEnd;

                c.keysCurveX = keysCurveX;
                c.animate = p.animate;

                c.onComplete = p.onComplete;
                c.onComplete.AddListener(() =>
                {
                    p.onCompleteAction?.Invoke();
                });

                return c;
            }

            #endregion

        }

    }
}


