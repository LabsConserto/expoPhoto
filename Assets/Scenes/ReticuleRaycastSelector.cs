using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReticuleRaycastSelector : MonoBehaviour
{


    private Reticle reticle;
    private SpriteRenderer spriteRenderer;

    private SpriteRenderer spriteR;

    public SpriteRenderer[] sprites;
    private GameObject previous= null;
    private float scale = 0.001f;
    public Sprite[] z;

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
             GameObject current = hit.collider.gameObject;
            if (scale < 0.015f)
            {
                current.GetComponent<SpriteRenderer>().transform.localScale = new Vector3(scale, scale, scale);
                scale += 0.001f;
            }

            previous = current;

            reticle.UpdateRadialProgress();
            // previous.GetComponent<Renderer>().material.color = Color.blue;
        }
        else
        {
            if(previous != null)
            {
                previous.GetComponent<SpriteRenderer>().transform.localScale = new Vector3(0.01F, 0.01F, 0.01F);
            }
            scale = 0.01f;
        }
    }







}
