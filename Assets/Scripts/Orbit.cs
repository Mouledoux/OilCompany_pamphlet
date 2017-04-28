using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    private bool orbiting = false;

    public void setOrbit(bool a_orbit)
    {
        orbiting = a_orbit;
    }

    public void SetRotate(float a_speed)
    {
        if(!orbiting)
        {
            orbiting = true;
            StartCoroutine(RunOrbit(a_speed));
        }
            
    }

    IEnumerator RunOrbit(float a_speed)
    {
        while(orbiting)
        {
            transform.RotateAround(Vector3.zero, Vector3.up, a_speed * Time.deltaTime);
            yield return null;
        }
    }
}
