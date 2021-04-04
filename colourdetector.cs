using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourdetector : MonoBehaviour { 

    public string currentColor;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Purple");

        Debug.Log(col.tag);
    }
}
 