using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public Material Light;
    public GameObject Object;
    public GameObject Player;
    public GameObject endMenu;
    public GameObject pauseMenu;
    public AudioClip collectSound;
    private void Update()
    {
        if(Player.GetComponent<PointsScript>().points >= 6)
        {
            Object.GetComponent<MeshRenderer>().material = Light;
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.name == "FirstPersonPlayer" && col.GetComponent<PointsScript>().points >= 6)
        {
            col.GetComponent<PointsScript>().points++;
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            Destroy(gameObject);
            Time.timeScale = 0.1f;
            endMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Destroy(pauseMenu);
        }
    }
}
