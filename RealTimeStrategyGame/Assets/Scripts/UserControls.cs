using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControls : MonoBehaviour {

    public float m_moveSpeed = 10;

    private bool m_moveFlag = false;

    private int m_hitLayer;

	// Use this for initialization
	void Start () {
        m_hitLayer = 1 << LayerMask.NameToLayer("Terrain");
    }

    private void Update()
    {
        if(m_moveFlag)
        {
            RaycastHit hit;

            if(Physics.Raycast(transform.position + new Vector3(0, 100, 0), Vector3.down, out hit, 200, m_hitLayer))
            {
                transform.position = hit.point;
            }
        }
    }

    void OnEnable()
    {
        InputManager.OnUPAxisPress += MoveFWD;
        InputManager.OnDownAxisPress += MoveBKWD;
        InputManager.OnLeftAxisPress += MoveLT;
        InputManager.OnRightAxisPress += MoveRT;
    }


    void OnDisable()
    {
        InputManager.OnUPAxisPress -= MoveFWD;
        InputManager.OnDownAxisPress -= MoveBKWD;
        InputManager.OnLeftAxisPress -= MoveLT;
        InputManager.OnRightAxisPress -= MoveRT;
    }


    void MoveFWD()
    {
        transform.position += transform.forward * Time.deltaTime * m_moveSpeed;

        m_moveFlag = true;
    }
    void MoveBKWD()
    {
        transform.position += -transform.forward * Time.deltaTime * m_moveSpeed;

        m_moveFlag = true;
    }
    void MoveRT()
    {
        transform.position += transform.right * Time.deltaTime * m_moveSpeed;

        m_moveFlag = true;
    }
    void MoveLT()
    {
        transform.position += -transform.right * Time.deltaTime * m_moveSpeed;

        m_moveFlag = true;
    }
}
