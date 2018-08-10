using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    public delegate void UPAxisPress();
    public static event UPAxisPress OnUPAxisPress;

    public delegate void DownAxisPress();
    public static event DownAxisPress OnDownAxisPress;

    public delegate void LeftAxisPress();
    public static event LeftAxisPress OnLeftAxisPress;

    public delegate void RightAxisPress();
    public static event RightAxisPress OnRightAxisPress;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            if (OnUPAxisPress != null)
                OnUPAxisPress();
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (OnDownAxisPress != null)
                OnDownAxisPress();
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (OnLeftAxisPress != null)
                OnLeftAxisPress();
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (OnRightAxisPress != null)
                OnRightAxisPress();
        }
    }
}
