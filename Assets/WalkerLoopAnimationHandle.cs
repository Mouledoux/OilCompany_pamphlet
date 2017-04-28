using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkerLoopAnimationHandle : MonoBehaviour
{
    [SerializeField] Animator m_anim;
    [SerializeField] string m_walkingTriggerName;
    [SerializeField] string m_screwdriverTriggerName;
    [SerializeField] string m_idleTriggerName;
    [SerializeField] string m_drillTriggerName;

    void TriggerWalk()
    {
        m_anim.SetTrigger(m_walkingTriggerName);
    }

    void TriggerScrewDriver()
    {
        m_anim.SetTrigger(m_screwdriverTriggerName);
    }

    void TriggerIdle()
    {
        m_anim.SetTrigger(m_idleTriggerName);
    }

    void TriggerDrill()
    {
        m_anim.SetTrigger(m_drillTriggerName);
    }

}
