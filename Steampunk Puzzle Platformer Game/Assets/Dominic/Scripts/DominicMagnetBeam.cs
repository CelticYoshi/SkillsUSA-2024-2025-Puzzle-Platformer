using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominicMagnetBeam : MonoBehaviour
{
    bool isBeamActive = false;
    
    void OnTriggerEnter2D(Collider2D other)
    {
       if (other.CompareTag("Player"))
       {
       isBeamActive = true;
       other.GetComponentInChildren<Animator>().SetBool("IsMagnetActive", isBeamActive);
       }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isBeamActive = false;
            other.GetComponentInChildren<Animator>().SetBool("IsMagnetActive", isBeamActive);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            //isBeamActive = false;
            other.GetComponentInChildren<Animator>().SetTrigger("InBeam");
        }
    }

    public bool IsBeamActive()
    {
        return isBeamActive;
    }

    IEnumerator PlayerIsInBeam()
    {
        if (isBeamActive)
        {
            yield return new WaitForSeconds(1.5f);
            //other.GetComponentInChildren<Animator>().SetTrigger("InBeam");

        }
    }
}
