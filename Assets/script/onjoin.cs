using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class onjoin : MonoBehaviourPunCallbacks
{
    public GameObject svs;
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
        PhotonNetwork.Instantiate("HPCharacter", new Vector3(19.13753f, -22.36089f, 42.21174f), Quaternion.identity, 0);
        svs.SetActive(false);
    }
}
