using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class onjoin : MonoBehaviourPunCallbacks
{
    public GameObject svs;

    private Vector3 v1= new Vector3(-5.52228546f, -22.3608856f, 4.25180149f);
    private Vector3 v2=new Vector3(-5.80692482f, -22.3700066f, 56.8658142f);
    private Vector3 v3=new Vector3(40.0270386f, -22.3608818f, 53.8128395f);
    private Vector3 v4= new Vector3(41.2266884f, -22.3699989f, 3.89101887f);
    // Start is called before the first frame update
    void Start()
    {
       
    }
    public override void OnJoinedRoom()
    {
        
    }
    // Update is called once per frame
    public void joinRomm()
    {
        int x = Random.Range(0,4);
        switch (x)
        { 
            case 0:
                {
                    PhotonNetwork.Instantiate("HPCharacter", v1, Quaternion.identity, 0);
                    break;
                }
                case 1:
                {
                    PhotonNetwork.Instantiate("HPCharacter", v2, Quaternion.identity, 0);
                    break;
                }
            case 2:
                {
                    PhotonNetwork.Instantiate("HPCharacter", v3, Quaternion.identity, 0);
                    break ;
                }
            default:
                {
                    PhotonNetwork.Instantiate("HPCharacter",v4, Quaternion.identity, 0);
                    break;
                }
               
        }
        svs.SetActive(false);
    }
}
