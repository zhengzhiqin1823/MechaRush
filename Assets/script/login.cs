using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
public class login : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    public GameObject nameInput;
    public GameObject roomInput;
    public InputField playerName;
    public InputField roomName;
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame

    public void nameButtonClick()
    {
        PhotonNetwork.NickName = playerName.text;
        roomInput.SetActive(true);
    }
    public void roomButtonClick()
    {
        Debug.Log(roomName.text);
        if (roomName.text.Length < 2)
        {
            return;
        }
        PhotonNetwork.JoinOrCreateRoom(roomName.text, new Photon.Realtime.RoomOptions() { MaxPlayers = 4 }, default);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel(2);
    }

    public override void OnConnectedToMaster()
    {
        nameInput.SetActive(true);
    }
}
