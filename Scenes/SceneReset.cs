using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RESETENTIRITY : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
            Application.LoadLevel(0); //or whatever number your scene is
    }
}
