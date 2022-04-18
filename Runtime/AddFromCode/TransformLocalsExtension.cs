﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static U.Motion.UAnimation;

namespace U.Motion
{
    public static class TransformLocalsExtension
    {

        public static IAnimatorCore TweenLocalPositionX(this Transform t, TweenFloat.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenFloat.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenFloat.Keyframe
                        {
                            key = 0,
                            value = t.localPosition.x,
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            // Add the function to animate the position in x
            p.animate = (x) => t.localPosition = new Vector3(x, t.localPosition.y, t.localPosition.z);

            // Create the tween with added values
            return TweenFloat.AddComponent(t.gameObject, p);

        }


        public static IAnimatorCore TweenLocalPositionY(this Transform t, TweenFloat.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenFloat.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenFloat.Keyframe
                        {
                            key = 0,
                            value = t.localPosition.y,
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            // Add the function to animate the position in x
            p.animate = (y) => t.localPosition = new Vector3(t.localPosition.x, y, t.localPosition.z);

            // Create the tween with added values
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static IAnimatorCore TweenLocalPositionZ(this Transform t, TweenFloat.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenFloat.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenFloat.Keyframe
                        {
                            key = 0,
                            value = t.localPosition.z,
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            // Add the function to animate the position in x
            p.animate = (z) => t.localPosition = new Vector3(t.localPosition.x, t.localPosition.y, z);

            // Create the tween with added values
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static IAnimatorCore TweenLocalPositionXY(this Transform t, TweenVector2.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenVector2.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenVector2.Keyframe
                        {
                            key = 0,
                            value = new Vector2(t.localPosition.x, t.localPosition.y),
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            // Add the function to animate the position in x
            p.animate = (x, y) => t.localPosition = new Vector3(x, y, t.localPosition.z);

            // Create the tween with added values
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static IAnimatorCore TweenLocalPositionXZ(this Transform t, TweenVector2.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenVector2.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenVector2.Keyframe
                        {
                            key = 0,
                            value = new Vector2(t.localPosition.x, t.localPosition.z),
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            // Add the function to animate the position in x
            p.animate = (x, z) => t.localPosition = new Vector3(x, t.localPosition.y, z);

            // Create the tween with added values
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static IAnimatorCore TweenLocalPositionYZ(this Transform t, TweenVector2.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenVector2.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenVector2.Keyframe
                        {
                            key = 0,
                            value = new Vector2(t.localPosition.y, t.localPosition.z),
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            // Add the function to animate the position in x
            p.animate = (y, z) => t.localPosition = new Vector3(t.localPosition.x, y, z);

            // Create the tween with added values
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static IAnimatorCore TweenLocalPositionXYZ(this Transform t, TweenVector3.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenVector3.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenVector3.Keyframe
                        {
                            key = 0,
                            value = new Vector3(t.localPosition.x, t.localPosition.y, t.localPosition.z),
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            // Add the function to animate the position in x
            p.animate = (x, y, z) => t.localPosition = new Vector3(x, y, z);

            // Create the tween with added values
            return TweenVector3.AddComponent(t.gameObject, p);
        }





        public static IAnimatorCore TweenLocalRotationX(this Transform t, TweenFloat.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenFloat.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenFloat.Keyframe
                        {
                            key = 0,
                            value = t.localRotation.x,
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            // Add the function to animate the position in x
            p.animate = (x) => t.localRotation  = Quaternion.Euler(x, t.localRotation.eulerAngles.y, t.localRotation.eulerAngles.z);

            // Create the tween with added values
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static IAnimatorCore TweenLocalRotationY(this Transform t, TweenFloat.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenFloat.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenFloat.Keyframe
                        {
                            key = 0,
                            value = t.localRotation.y,
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            // Add the function to animate the position in x
            p.animate = (y) => t.localRotation  = Quaternion.Euler(t.localRotation.eulerAngles.x, y, t.localRotation.eulerAngles.z);

            // Create the tween with added values
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static IAnimatorCore TweenLocalRotationZ(this Transform t, TweenFloat.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenFloat.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenFloat.Keyframe
                        {
                            key = 0,
                            value = t.localRotation.z,
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            // Add the function to animate the position in x
            p.animate = (z) => t.localRotation  = Quaternion.Euler(t.localRotation.eulerAngles.x, t.localRotation.eulerAngles.y, z);

            // Create the tween with added values
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static IAnimatorCore TweenLocalRotationXY(this Transform t, TweenVector2.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenVector2.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenVector2.Keyframe
                        {
                            key = 0,
                            value = new Vector2(t.localRotation.x, t.localRotation.y),
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            // Add the function to animate the position in x
            p.animate = (x, y) => t.localRotation  = Quaternion.Euler(x, y, t.localRotation.eulerAngles.z);

            // Create the tween with added values
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static IAnimatorCore TweenLocalRotationXZ(this Transform t, TweenVector2.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenVector2.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenVector2.Keyframe
                        {
                            key = 0,
                            value = new Vector2(t.localRotation.x, t.localRotation.z),
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            // Add the function to animate the position in x
            p.animate = (x, z) => t.localRotation  = Quaternion.Euler(x, t.localRotation.eulerAngles.y, z);

            // Create the tween with added values
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static IAnimatorCore TweenLocalRotationYZ(this Transform t, TweenVector2.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenVector2.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenVector2.Keyframe
                        {
                            key = 0,
                            value = new Vector2(t.localRotation.y, t.localRotation.z),
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            // Add the function to animate the position in x
            p.animate = (y, z) => t.localRotation  = Quaternion.Euler(t.localRotation.eulerAngles.x, y, z);

            // Create the tween with added values
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static IAnimatorCore TweenLocalRotationXYZ(this Transform t, TweenVector3.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenVector3.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenVector3.Keyframe
                        {
                            key = 0,
                            value = new Vector3(t.localRotation.x, t.localRotation.y, t.localRotation.z),
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            // Add the function to animate the position in x
            p.animate = (x, y, z) => t.localRotation  = Quaternion.Euler(x, y, z);

            // Create the tween with added values
            return TweenVector3.AddComponent(t.gameObject, p);
        }


    }
}
