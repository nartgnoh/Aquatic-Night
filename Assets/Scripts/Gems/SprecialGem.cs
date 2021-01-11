using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprecialGem : MonoBehaviour
{
    public AudioClip collectSound;
    void OnTriggerEnter(Collider col)
    {

        if (col.name == "FirstPersonPlayer")
        {

            for (int n = 0; n < 5; n++)
            {
                col.GetComponent<PointsScript>().points++;
            }
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            Destroy(gameObject);
        }
    }
}
