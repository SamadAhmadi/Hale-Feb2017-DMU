using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class AppleCounter : MonoBehaviour {
    public Text text;
    
    int iCounter = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        text.text = iCounter.ToString();
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Apple")
        {
            iCounter++;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Apple")
        {
            iCounter--;
        }
    }
}
