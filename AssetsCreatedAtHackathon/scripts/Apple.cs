using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Interactable))]
public class Apple : MonoBehaviour {
    public bool bStartsOnTree = true;

    private bool bHasBeenPicked = false;

    private float attachTime;

    private Rigidbody m_rigidbody;
    // Use this for initialization
    void Start () {
        m_rigidbody = GetComponent<Rigidbody>();

        if (bStartsOnTree)
        {
            RigidbodyConstraints constraints = RigidbodyConstraints.FreezeAll;
            m_rigidbody.constraints = constraints;
        }
        else
        {
            PickApple();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    bool HasBeenPicked()
    {
        return bHasBeenPicked;
    }

    //-------------------------------------------------
    void Awake()
    {

    }

    private void PickApple()
    {
        if (!bHasBeenPicked)
        {
            bHasBeenPicked = true;

            RigidbodyConstraints constraints = RigidbodyConstraints.None;

            m_rigidbody.constraints = constraints;
            
        }
    }

    public void PickedUp()
    {
        PickApple();
    }

    public void Dropped()
    {

    }
}
