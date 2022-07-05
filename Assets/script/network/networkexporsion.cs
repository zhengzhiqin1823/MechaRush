using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class networkexporsion : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxtime;
    public int timer;
    public GameObject range;
    private bool ret = false;
    // Start is called before the first frame update
    void Start()
    {
        maxtime = 200;
        timer = 0;
        this.GetComponent<networkexporsionDamage>().enabled = false;
    }
    private void Awake()
    {
        ret = false;
    }
    // Update is called once per frame
    void Update()
    {
        timer++;
        if (timer > maxtime)
        {
            range.SetActive(true);
        }
        if (timer > 1.5 * maxtime)
        {
            if (!ret)
            {
                ret = true;
                this.GetComponent<networkexporsionDamage>().enabled = true;
            }
        }
        if (timer > 2 * maxtime)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
