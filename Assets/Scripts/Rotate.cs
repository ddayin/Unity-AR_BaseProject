using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    private Transform m_Transform;
    public float m_Speed = 10f;

    // Use this for initialization
    void Start()
    {
        m_Transform = transform;
	}
	
	// Update is called once per frame
	void Update()
    {
        m_Transform.Rotate(0f, Time.deltaTime * m_Speed, 0f, Space.Self);
	}
}
