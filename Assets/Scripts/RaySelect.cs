///////////////////////////////////////////////////////////////////////////
// Author:  Zac King            ///////////////////////////////////////////
// Contact: ZacKingx@Gmail.com  ///////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////
// Usage:                                                                //
//          Add component to the object to act as raycast                //
//          (Ray cast is from the objects forward)                       //
// //////                                                                //
// Notes:                                                                //
//          Do not have Clickable objects colliders overlapping          //
//          When Component is added it will require <RadialLoad>         //
///////////////////////////////////////////////////////////////////////////

using UnityEngine;
using UnityEngine.Events;

//[RequireComponent(typeof(RadialLoad))]
public class RaySelect : MonoBehaviour
{
    #region Variables
    private RaycastHit rayCursor;   // Ray cast from camera
    private RadialLoad loader;      // Reference to the RadialLoad (On the same Game Object)
    public LayerMask mask;

    public UnityEvent onHit;
    public UnityEvent onExit;

    #endregion

    #region Functions
    //void Awake()    // MonoBehaviour
    //{
    //    loader = gameObject.GetComponent<RadialLoad>();     // Store Loader
    //}

    void Update()   // Called every Physics step
    {
        if (Physics.Raycast(transform.position, transform.forward, out rayCursor, 10000, mask))  // TeleportNode layer
        {
            if (rayCursor.collider.gameObject.GetComponent<RaySelectionVolume>() != null)
                rayCursor.collider.gameObject.GetComponent<RaySelectionVolume>().loadedAction.Invoke();
            else
                OnSelectionExit();
        }
        else
        {
            OnSelectionExit();  // RayCast is no longer on a Selection Volume
        }
    }

    // Functions ///////////////////////////////////////////////////////////////////////////////////////
    void OnSelectionHit()   // Start Load
    {
        onHit.Invoke();
        //loader.LoadTarget(rayCursor.collider.gameObject);  // Start loading image
    }

    void OnSelectionExit()  // Stop Load
    {
        onExit.Invoke();
        //loader.StopLoad();  // Stop loading image
    }
    #endregion
}
