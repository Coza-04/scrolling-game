using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDS_Rotate : MonoBehaviour
{
    
    void Update()
    {
                CamLook();

    }
    void CamLook()
    {
        Vector3 LookDir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(LookDir.x, LookDir.z) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward); // everytime the player moves whilst shooting th bullets will roatate at the same time 
    }
}
