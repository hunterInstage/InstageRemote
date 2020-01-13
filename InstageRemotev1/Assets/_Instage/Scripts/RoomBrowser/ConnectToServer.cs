﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;


public class ConnectToServer : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        ConnectToPhoton();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ConnectToPhoton()
    {
        //connectionStatus.text = "Connecting..";
        Debug.Log("connecting to pun");
        PhotonNetwork.GameVersion = "1";
        PhotonNetwork.ConnectUsingSettings();

        
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("I AM ON THE MASTER");
        PhotonNetwork.JoinLobby();
        Debug.Log(PhotonNetwork.CloudRegion);
    }

    public override void OnConnected()
    {
        base.OnConnected();
    }
}
