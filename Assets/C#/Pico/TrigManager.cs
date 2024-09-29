using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pvr_UnitySDKAPI;
public class TrigManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)|| Controller.UPvr_GetKeyDown(1,Pvr_KeyCode.TRIGGER))
        {
            if (Pvr_ControllerDemo.instance.currentHit != null)
            {
                if (Pvr_ControllerDemo.instance.currentHit.GetComponent<CubeTest>() != null)
                    Pvr_ControllerDemo.instance.currentHit.GetComponent<CubeTest>().Run();
            }
        }
    }
}
