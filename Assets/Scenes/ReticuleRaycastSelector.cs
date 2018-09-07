using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReticuleRaycastSelector : MonoBehaviour
{


    private Reticle reticle;
    private SpriteRenderer spriteRenderer;

    private SpriteRenderer spriteR;

    private SpriteRenderer[] sprites;
    private List<Sprite> x;
    GameObject previous;
    private float scale = 0.001f;

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
             current.GetComponent<SpriteRenderer>().transform.localScale = new Vector3(0.015F, 0.015F, 0.015F);
            // for(int i = 0; i < sprites.Length; i++){
            //     if(GameObject.ReferenceEquals(current.GetComponent<SpriteRenderer>(), sprites[i].GetComponent<SpriteRenderer>())){
            //         sprites[i].GetComponent<SpriteRenderer>().transform.localScale =  new Vector3(0.01F, 0.01F, 0.01F);
            //     }
                
            // }
            

            if (current != previous)
            {
                Debug.Log("diff");
                previous = current;

            }

            reticle.UpdateRadialProgress();
            // previous.GetComponent<Renderer>().material.color = Color.blue;
        }
        else
        {
            previous.GetComponent<SpriteRenderer>().transform.localScale = new Vector3(0.01F, 0.01F, 0.01F);
            reticle.ResetRadialProgress();
            // current.GetComponent<SpriteRenderer>().color = new Color(0.3F, 0.4F, 0.6F);
        }
    }







}
