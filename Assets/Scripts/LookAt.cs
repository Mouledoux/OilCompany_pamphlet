using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] private GameObject m_target;
    
	void Update ()
    {
        transform.LookAt(m_target.transform);
        Cursor.lockState = CursorLockMode.Locked;
	}
}
