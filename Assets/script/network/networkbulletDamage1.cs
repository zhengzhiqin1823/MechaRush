using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class networkbulletDamage1 : MonoBehaviour
{
    // Start is called before the first frame update
    public int damage;
    public bool explosion = false;
    public GameObject exp;


    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(explosion);
        GameObject obj = other.gameObject;
        if (obj.transform.tag.Equals("Player"))
        {
            networkCharaCtr cc = obj.GetComponent<networkCharaCtr>();
            cc.healthChange(-1 * damage);
        }
        if (explosion && !other.transform.tag.Equals("Respawn"))
        {
            Instantiate(exp);
            exp.transform.position = this.transform.position;
            Debug.Log("exp:" + exp.transform.position.ToString());
        }
    }
}