using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class networkBulletDamage : MonoBehaviourPun
{ // Start is called before the first frame update
    public int damage=10;
    public bool explosion = false;


    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(explosion);
        GameObject obj = other.gameObject;
        if (obj.transform.tag.Equals("Player"))
        {
            networkCharaCtr cc = obj.GetComponent<networkCharaCtr>();
            cc.healthChange(-1 * damage);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;
        if (obj.transform.tag.Equals("Player"))
        {
            networkCharaCtr cc = obj.GetComponent<networkCharaCtr>();
            cc.healthChange(-10);
        }
    }
}
