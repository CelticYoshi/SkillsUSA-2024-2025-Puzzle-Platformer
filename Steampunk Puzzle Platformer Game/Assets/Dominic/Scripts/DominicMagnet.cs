using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominicMagnet : MonoBehaviour
{
    public gameObject magnetBeam;

    // Start is called before the first frame update
    void Start()
    {
        magnetBeam.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            magnetBeam.gameObject.SetActive(true);
        }
    }
}
