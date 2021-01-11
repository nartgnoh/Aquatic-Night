using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class InnerNight : MonoBehaviour
{
    public GameObject Day;
    public GameObject Night;

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Z))
        {
            Day.SetActive(false);
            Night.SetActive(true);

        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            Day.SetActive(true);
            Night.SetActive(false);

        }
    }
}
