using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class ListRooms : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private Transform Content;
    [SerializeField]
    private FillRoomInfo roomListing;

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
       
        foreach(RoomInfo info in roomList)
        {
            FillRoomInfo listing = (FillRoomInfo)Instantiate(roomListing, Content);
            if (listing != null)
            {
                listing.SetRoomInfo(info);
                Debug.Log("ROOM UPDATE");
            }
        }
    }

}
