using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Realtime;

public class FillRoomInfo : MonoBehaviour
{
    //Button UI Elements
    [SerializeField]
    TextMeshProUGUI NameText;
    [SerializeField]
    TextMeshProUGUI ScenarioText;
    [SerializeField]
    TextMeshProUGUI CompanyText;
    [SerializeField]
    TextMeshProUGUI LocationText;

    //Class containing room info
    //[SerializeField]
    //public class RoomInfo
    //{
    //    public string Name;
    //    public string Scenario;
    //    public string Company;
    //    public string Location;
    //}

    //public RoomInfo ButtonInfo;
    
    public void SetRoomInfo(RoomInfo roomInfo)
    {
        
        NameText.text = roomInfo.CustomProperties.Count.ToString();
        //NameText.text = roomInfo.Name;  
    }



}
