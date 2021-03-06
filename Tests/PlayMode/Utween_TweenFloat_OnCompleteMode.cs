using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using U.Motion;
using UnityEngine;
using UnityEngine.TestTools;

public class Tweens_TweenFloat_OnCompleteMode
{


    [UnityTest]
    public IEnumerator TweenFloat_CheckOnCompleteModeDisable()
    {

        // Host and client 
        float client = 0;

        // Create the animation
        var animation = UAnimation.TweenFloat.AddComponent(new GameObject("Host"), new UAnimation.TweenFloat.Properties
        {
            onCompleteMode = UAnimation.OnCompleteMode.Disable,
            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new UAnimation.TweenFloat.Keyframe[]
            {
                new UAnimation.TweenFloat.Keyframe {key = 0, value = client},
                new UAnimation.TweenFloat.Keyframe {key = 50, value = 3f},
                new UAnimation.TweenFloat.Keyframe {key = 100, value = 20f},
            },
        });

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(20f, client);


        // Check if is disabled
        Assert.IsFalse(animation.enabled);

    }


    [UnityTest]
    public IEnumerator TweenFloat_CheckOnCompleteModeDisableCompleteNow()
    {

        // Host and client 
        float client = 0;

        // Create the animation
        var animation = UAnimation.TweenFloat.AddComponent(new GameObject("Host"), new UAnimation.TweenFloat.Properties
        {

            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new UAnimation.TweenFloat.Keyframe[]
            {
                new UAnimation.TweenFloat.Keyframe {key = 0, value = client},
                new UAnimation.TweenFloat.Keyframe {key = 50, value = 3f},
                new UAnimation.TweenFloat.Keyframe {key = 100, value = 20f},
            },
        });

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        animation.CompleteNow();


        // Check if is disabled
        Assert.IsFalse(animation.enabled);

    }





    [UnityTest]
    public IEnumerator TweenFloat_CheckOnCompleteModeDestroy()
    {

        // Host and client 
        float client = 0;

        // Create the animation
        var animation = UAnimation.TweenFloat.AddComponent(new GameObject("Host"), new UAnimation.TweenFloat.Properties
        {

            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new UAnimation.TweenFloat.Keyframe[]
            {
                new UAnimation.TweenFloat.Keyframe {key = 0, value = client},
                new UAnimation.TweenFloat.Keyframe {key = 50, value = 3f},
                new UAnimation.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            onCompleteMode = UAnimation.OnCompleteMode.Destroy,
        });

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(20f, client);


        // Check if is disabled
        Assert.IsTrue(animation == null);

    }


    [UnityTest]
    public IEnumerator TweenFloat_CheckOnCompleteModeDestroyCompleteNow()
    {

        // Host and client 
        float client = 0;

        // Create the animation
        var animation = UAnimation.TweenFloat.AddComponent(new GameObject("Host"), new UAnimation.TweenFloat.Properties
        {

            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new UAnimation.TweenFloat.Keyframe[]
            {
                new UAnimation.TweenFloat.Keyframe {key = 0, value = client},
                new UAnimation.TweenFloat.Keyframe {key = 50, value = 3f},
                new UAnimation.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            onCompleteMode = UAnimation.OnCompleteMode.Destroy,
        });

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        animation.CompleteNow();
        yield return new WaitForSecondsRealtime(.1f);

        // Check if is disabled
        Assert.IsTrue(animation == null);

    }





    [UnityTest]
    public IEnumerator TweenFloat_CheckOnCompleteModeLoop()
    {

        // Host and client 
        float client = 0;

        // Create the animation
        var animation = UAnimation.TweenFloat.AddComponent(new GameObject("Host"), new UAnimation.TweenFloat.Properties
        {

            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new UAnimation.TweenFloat.Keyframe[]
            {
                new UAnimation.TweenFloat.Keyframe {key = 0, value = client},
                new UAnimation.TweenFloat.Keyframe {key = 50, value = 3f},
                new UAnimation.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            onCompleteMode = UAnimation.OnCompleteMode.Loop,
        });

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(11f);
        Assert.IsTrue(client > 0 && client < 20);

    }


    [UnityTest]
    public IEnumerator TweenFloat_CheckOnCompleteModeLoopCompleteNow()
    {

        // Host and client 
        float client = 0;

        // Create the animation
        var animation = UAnimation.TweenFloat.AddComponent(new GameObject("Host"), new UAnimation.TweenFloat.Properties
        {

            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new UAnimation.TweenFloat.Keyframe[]
            {
                new UAnimation.TweenFloat.Keyframe {key = 0, value = client},
                new UAnimation.TweenFloat.Keyframe {key = 50, value = 3f},
                new UAnimation.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            onCompleteMode = UAnimation.OnCompleteMode.Loop,
        });

        yield return new WaitForSecondsRealtime(1f);
        animation.CompleteNow();

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(10f);
        Assert.IsTrue(client > 0 && client < 20);


    }





    [UnityTest]
    public IEnumerator TweenFloat_CheckOnCompleteModeNone()
    {

        // Host and client 
        float client = 0;

        // Create the animation
        var animation = UAnimation.TweenFloat.AddComponent(new GameObject("Host"), new UAnimation.TweenFloat.Properties
        {

            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new UAnimation.TweenFloat.Keyframe[]
            {
                new UAnimation.TweenFloat.Keyframe {key = 0, value = client},
                new UAnimation.TweenFloat.Keyframe {key = 50, value = 3f},
                new UAnimation.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            onCompleteMode = UAnimation.OnCompleteMode.None,
        });

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(20f, client);


        // Check if is disabled
        Assert.IsTrue(animation.enabled);

    }


    [UnityTest]
    public IEnumerator TweenFloat_CheckOnCompleteModeNoneCompleteNow()
    {

        // Host and client 
        float client = 0;

        // Create the animation
        var animation = UAnimation.TweenFloat.AddComponent(new GameObject("Host"), new UAnimation.TweenFloat.Properties
        {

            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new UAnimation.TweenFloat.Keyframe[]
            {
                new UAnimation.TweenFloat.Keyframe {key = 0, value = client},
                new UAnimation.TweenFloat.Keyframe {key = 50, value = 3f},
                new UAnimation.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            onCompleteMode = UAnimation.OnCompleteMode.None,
        });

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        animation.CompleteNow();


        // Check if is disabled
        Assert.IsTrue(animation.enabled);

    }




}
