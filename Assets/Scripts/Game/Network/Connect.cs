using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;

public class Connect : Photon.MonoBehaviour {

    private void Start()
    {
        ConnectToRoom();
    }

    public void ConnectToRoom()
    {
        PhotonNetwork.ConnectUsingSettings("Alpha 1.0");  //Verbinden...
    }

    void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();  //Verbunden! ; Verbinden mit Lobby...
    }

    void OnJoinedLobby()
    {
        PhotonNetwork.JoinRandomRoom(); //Join open Room
    }

    void OnPhotonRandomJoinFailed()
    {
        PhotonNetwork.CreateRoom(null); //Create Random Room
        Debug.Log("Raum erstellt!");
    }

    void OnJoinedRoom()
    {
        Debug.Log("mit raum verbunden!"); //Raum beigetreten
        GetComponent<IUhrenBehaviour>().Setup();
    }

}
