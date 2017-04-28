using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialTeleportNode : MonoBehaviour
{
    [SerializeField]
    private GameObject m_camrig;
    [SerializeField] private Vector3 m_teleportPos;
    
    public void TeleportNode()
    {
        m_camrig.transform.position = m_teleportPos;
    }
}
