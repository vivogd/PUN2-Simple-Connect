using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject PlayerPrefab;
    void Start()
    {
       
        
       PhotonNetwork.ConnectUsingSettings();

    }



    #region Photon Callbacks

    public override void OnConnected()
    {
        Debug.Log("Connected to internet");
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master");
        PhotonNetwork.JoinRandomOrCreateRoom();
    }


    public override void OnCreatedRoom()
    {
        Debug.Log("On Create Room");
    }


    public override void OnJoinedRoom()
    {
        Debug.Log("Joined room" + PhotonNetwork.CurrentRoom.Name);

         PhotonNetwork.Instantiate(PlayerPrefab.name, new Vector3(Random.Range(-10f,10f),0,Random.Range(-10f,10f)), Quaternion.identity);
    }
    #endregion

}
