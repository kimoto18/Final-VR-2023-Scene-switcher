using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //< ----Will need to manually input this

public class Change_to_summer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //This is the code that does the scene change
        if (other.gameObject.tag == "Door")
            SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}