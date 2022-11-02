using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startbutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "startbutton")
        {
            SceneManager.LoadScene("Scene");
        }
        if (other.gameObject.tag == "quitbutton")
        {
            Application.Quit();
            Debug.Log("quit");
        }
    }
}
