using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
public class networkRIddle : MonoBehaviourPun
{
    // Start is called before the first frame update
    public Image energy;

    public float process;

    // Start is called before the first frame update
    void Start()
    {
        process = 0;
    }

    // Update is called once per frame
    void Update()
    {
        process += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.F))
        {
            float x = Random.Range(0, process);
            if (x < 0.2 + process * 0.4)
            {
                var b = PhotonNetwork.Instantiate("exporsion", this.transform.position + transform.forward * 2 + transform.right, Quaternion.identity, 0);
            }
            else
            {
                if (x < 0.5 * process)
                {
                    var b = PhotonNetwork.Instantiate("energy", this.transform.position + transform.forward * 2 + transform.right, Quaternion.identity, 0);
                }
                if (x < 0.7 * process)
                {
                    var b = PhotonNetwork.Instantiate("bulChange2", this.transform.position + transform.forward * 2 + transform.right, Quaternion.identity, 0);
                }
                if (x < 0.9 * process)
                {
                    var b = PhotonNetwork.Instantiate("bulChange3", this.transform.position + transform.forward * 2 + transform.right, Quaternion.identity, 0);
                }
                else
                {
                    var b = PhotonNetwork.Instantiate("bulChange4", this.transform.position + transform.forward * 2 + transform.right, Quaternion.identity, 0);
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
