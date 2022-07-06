using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveY : MonoBehaviour
{
    public float anglelimit = 20f;  
    void Update()
    {
        
        float MoveY = Input.GetAxis("Mouse Y");
      if (this.transform.rotation.eulerAngles.x < anglelimit || this.transform.rotation.eulerAngles.x > 360-anglelimit)
      {
          Vector3 v = new Vector3(MoveY, 0, 0);
          this.transform.Rotate(v, Space.Self);

          if (!(this.transform.rotation.eulerAngles.x < anglelimit || this.transform.rotation.eulerAngles.x > 360-anglelimit))
          {
              this.transform.Rotate(new Vector3(-MoveY, 0, 0), Space.Self);
          }
      }
       
    }
}
