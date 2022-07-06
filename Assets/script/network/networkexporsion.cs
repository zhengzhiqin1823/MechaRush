using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class networkexporsion : MonoBehaviourPun
{
    // Start is called before the first frame update
    public float maxtime;
    public float timer;
    public GameObject range;
    private bool ret = false;
    // Start is called before the first frame update
    void Start()
    {
        maxtime = 0.5f;
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
        timer+=Time.deltaTime;
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
            PhotonNetwork.Destroy(this.gameObject);
        }
    }
}
