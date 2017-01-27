using UnityEngine;
using System.Collections;

public class changeColor : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        // Turns object red
	    if(Input.GetKeyDown(KeyCode.R)) {
            GetComponent<Renderer>().material.color = Color.red;
            print("Changed color to red.");
        }
        // Turns object blue
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
            print("Changed color to blue.");
        }
        // Turns object green
        if (Input.GetKeyDown(KeyCode.G)) {
            GetComponent<Renderer>().material.color = Color.green;
            print("Changed color to green.");
        }
        // Turns object white
        if (Input.GetKeyDown(KeyCode.Delete)) {
            GetComponent<Renderer>().material.color = Color.white;
            print("Changed color to white.");
        }
        // Turns object black
        if (Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<Renderer>().material.color = Color.black;
            print("Changed color to black.");
        }
        // Turns object yellow
        if (Input.GetKeyDown(KeyCode.KeypadEnter)) {
            GetComponent<Renderer>().material.color = Color.yellow;
            print("Changed color to yellow.");
        }
    }
}
