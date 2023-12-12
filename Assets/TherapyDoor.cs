using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TherapyDoor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //This is the code that does the scene change
        if (other.gameObject.tag == "Door")
            SceneManager.LoadScene("Subway");
    }

    // Update is called once per frame
    void Update()
    {

    }
}