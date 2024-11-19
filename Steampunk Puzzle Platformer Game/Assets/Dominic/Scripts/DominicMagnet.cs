using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominicMagnet : MonoBehaviour
{
    //public GameObject magnetBeam;
    public SpriteRenderer magnetSpriteRenderer;
    //public Vector3 _myLocation;

    // Start is called before the first frame update
    void Start()
    {
        //magnetBeam.gameObject.SetActive(false);
        magnetSpriteRenderer.enabled = false;
        //_myLocation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            //magnetBeam.gameObject.SetActive(true);
            magnetSpriteRenderer.enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            //magnetBeam.gameObject.SetActive(false);
            magnetSpriteRenderer.enabled = false;
        }
    }
}
