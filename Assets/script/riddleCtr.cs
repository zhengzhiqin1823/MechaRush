using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class riddleCtr : MonoBehaviour
{
    public Image energy;

    public float process;

    public GameObject exporsion;

    public GameObject energyGobj;

    public GameObject bulletchange2;

    public GameObject bulletchange3;

    public GameObject bulletchange4;
    // Start is called before the first frame update
    void Start()
    {
        process = 0;
    }

    // Update is called once per frame
    void Update()
    {
        process += Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.F))
        {
            float x = Random.Range(0, process);
            if(x<0.2+process*0.4)
            {
                var b=Instantiate(exporsion);
                b.transform.position = this.transform.position+transform.forward*2+transform.right;
            }
            else
            {
                if(x<0.5*process)
                {
                    var b=Instantiate(energyGobj);
                    b.transform.position = this.transform.position + transform.forward * 2 + transform.right;
                }
                if(x<0.7*process)
                {
                    var b=Instantiate(bulletchange2);
                    b.transform.position = this.transform.position + transform.forward * 2 + transform.right;
                }
                if(x<0.9*process)
                {
                    var b=Instantiate(bulletchange3);
                    b.transform.position = this.transform.position + transform.forward * 2 + transform.right;
                }
                else
                {
                    var b=Instantiate(bulletchange4);
                    b.transform.position = this.transform.position + transform.forward * 2 + transform.right;
                }
            }
            process = 0;
        }
        energyImgChange();
    }

    private void energyImgChange()
    {
        energy.fillAmount = process;
    }
}
