using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public enum Pos

{

    X,

    Y,

    Z

}



public enum Scale

{

    X,

    Y,

    Z

}



public class AnimatorManager : MonoBehaviour
{



    public void AnimateLight(GameObject obj, float start, float end, bool isInversed)

    {

        Animation anim = obj.GetComponent<Animation>();

        AnimationClip clip = (anim.GetClip("") == null) ? (new AnimationClip()) : (anim.GetClip(""));

        clip.legacy = true;



        AnimationCurve curve = (isInversed) ? (AnimationCurve.Linear(0.0F, start, 1.0F, end)) : (AnimationCurve.Linear(0.0F, end, 1.0F, start));



        clip.SetCurve("", typeof(Light), "m_Intensity", curve);



        anim.AddClip(clip, clip.name);

        anim.Play(clip.name);

    }



    public void AnimatePos(GameObject obj, Pos p, float start, float end, bool isInversed)

    {

        Animation anim = obj.GetComponent<Animation>();

        AnimationClip clip = (anim.GetClip("") == null) ? (new AnimationClip()) : (anim.GetClip(""));

        clip.legacy = true;



        AnimationCurve curveX;

        if (p == Pos.X)

        {

            curveX = (isInversed) ? (AnimationCurve.Linear(0.0F, start, 1.0F, end)) : (AnimationCurve.Linear(0.0F, end, 1.0F, start));

        }

        else

        {

            curveX = AnimationCurve.Linear(0.0F, obj.transform.position.x, 1.0F, obj.transform.position.x);

        }



        AnimationCurve curveY;

        if (p == Pos.Y)

        {

            curveY = (isInversed) ? (AnimationCurve.Linear(0.0F, start, 1.0F, end)) : (AnimationCurve.Linear(0.0F, end, 1.0F, start));

        }

        else

        {

            curveY = AnimationCurve.Linear(0.0F, obj.transform.position.y, 1.0F, obj.transform.position.y);

        }



        AnimationCurve curveZ;

        if (p == Pos.Z)

        {

            curveZ = (isInversed) ? (AnimationCurve.Linear(0.0F, start, 1.0F, end)) : (AnimationCurve.Linear(0.0F, end, 1.0F, start));

        }

        else

        {

            curveZ = AnimationCurve.Linear(0.0F, obj.transform.position.z, 1.0F, obj.transform.position.z);

        }



        clip.SetCurve("", typeof(Transform), "m_LocalPosition.x", curveX);

        clip.SetCurve("", typeof(Transform), "m_LocalPosition.y", curveY);

        clip.SetCurve("", typeof(Transform), "m_LocalPosition.z", curveZ);



        anim.AddClip(clip, clip.name);

        anim.Play(clip.name);

    }



    public void AnimateScale(GameObject obj, Scale s, float start, float end, bool isInversed)

    {

        Animation anim = obj.GetComponent<Animation>();

        AnimationClip clip = (anim.GetClip("") == null) ? (new AnimationClip()) : (anim.GetClip(""));

        clip.legacy = true;



        AnimationCurve curveX;

        if (s == Scale.X)

        {

            curveX = (isInversed) ? (AnimationCurve.Linear(0.0F, start, 1.0F, end)) : (AnimationCurve.Linear(0.0F, end, 1.0F, start));

        }

        else

        {

            curveX = AnimationCurve.Linear(0.0F, obj.transform.localScale.x, 1.0F, obj.transform.localScale.x);

        }



        AnimationCurve curveY;

        if (s == Scale.Y)

        {

            curveY = (isInversed) ? (AnimationCurve.Linear(0.0F, start, 1.0F, end)) : (AnimationCurve.Linear(0.0F, end, 1.0F, start));

        }

        else

        {

            curveY = AnimationCurve.Linear(0.0F, obj.transform.localScale.y, 1.0F, obj.transform.localScale.y);

        }



        AnimationCurve curveZ;

        if (s == Scale.Z)

        {

            curveZ = (isInversed) ? (AnimationCurve.Linear(0.0F, start, 1.0F, end)) : (AnimationCurve.Linear(0.0F, end, 1.0F, start));

        }

        else

        {

            curveZ = AnimationCurve.Linear(0.0F, obj.transform.localScale.z, 1.0F, obj.transform.localScale.z);

        }



        clip.SetCurve("", typeof(Transform), "m_LocalScale.x", curveX);

        clip.SetCurve("", typeof(Transform), "m_LocalScale.y", curveY);

        clip.SetCurve("", typeof(Transform), "m_LocalScale.z", curveZ);



        anim.AddClip(clip, clip.name);

        anim.Play(clip.name);

    }

}