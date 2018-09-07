using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReticuleRaycastSelector : MonoBehaviour
{


    private Reticle reticle;

    // Use this for initialization
    void Start()
    {
        reticle = this.GetComponent<Reticle>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(this.transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (hit.collider != null)
            {
                if (reticle.RadialPercent >= 1f)
                {
                    Debug.Log("blabalbabal  raycast !!! ==> ", hit.collider.gameObject);
                    //SceneManager.LoadScene(hit.collider.gameObject.name);
                    //reticle.ResetRadialProgress();
                }
                else
                {
                    reticle.UpdateRadialProgress();
                }

            }

        }
        else
        {
            reticle.ResetRadialProgress();
        }
    }
}
