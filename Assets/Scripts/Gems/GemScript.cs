using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScript : MonoBehaviour
{
    public AudioClip collectSound;

    void OnTriggerEnter(Collider col)
    {
        if(col.name == "FirstPersonPlayer" && col.GetComponent<PointsScript>().points < 7)
        {
            col.GetComponent<PointsScript>().points++;
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            Destroy(gameObject);
        }
    }
}
