/*============================================================================== 
Copyright (c) 2015-2017 PTC Inc. All Rights Reserved.

Copyright (c) 2015 Qualcomm Connected Experiences, Inc. All Rights Reserved. 

Vuforia is a trademark of PTC Inc., registered in the United States and other 
countries.   
==============================================================================*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Vuforia;

public class Reticle : MonoBehaviour
{

    #region PUBLIC_VARIABLES
    public Transform radialProgress;
    //Don't use the Set function please, but I can't do a readonly var...
    public float RadialPercent { get; set; }
    #endregion

    #region PRIVATE_METHODS
    private const float mScale = 0.012f; // relative to viewport width
    #endregion


    #region MONOBEHAVIOUR_METHODS
    void Update()
    {

    }
    #endregion // MONOBEHAVIOUR_METHODS

    #region PUBLIC_METHODS
    //fill the radial around the reticle
    public void UpdateRadialProgress()
    {

        RadialPercent += 0.01f;

        if (RadialPercent <= 1)
            radialProgress.GetComponent<UnityEngine.UI.Image>().fillAmount = RadialPercent;
    }

    //reset the radial % filling to 0
    public void ResetRadialProgress()
    {
        RadialPercent = 0;
        radialProgress.GetComponent<UnityEngine.UI.Image>().fillAmount = 0;
    }
    #endregion //PUBLIC_METHODS

}
