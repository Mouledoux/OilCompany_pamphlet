using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandle : MonoBehaviour
{
    Animator m_anim;

    void Start ()
    {
        m_anim = GetComponent<Animator>();    	
	}
	
    void HitTrigger(string a_triggerName)
    {
        m_anim.SetTrigger(a_triggerName);
    }

    void SetBool(string a_boolName, bool a_value)
    {
        m_anim.SetBool(a_boolName, a_value);
    }

    void SetInt(string a_intName, int a_value)
    {
        m_anim.SetInteger(a_intName, a_value);
    }
}
