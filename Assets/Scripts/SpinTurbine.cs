using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinTurbine : MonoBehaviour
{
    [SerializeField] private float m_speed = 5;
    [SerializeField] private bool m_rotateY;    // False to rotate around z

    void Update ()
    {
        float t = m_speed * Time.deltaTime;
        if(m_rotateY)
            transform.Rotate(new Vector3(transform.localRotation.x, t, transform.localRotation.z));
        else
        transform.Rotate(new Vector3(transform.localRotation.x, transform.localRotation.y, t));
	}
}
