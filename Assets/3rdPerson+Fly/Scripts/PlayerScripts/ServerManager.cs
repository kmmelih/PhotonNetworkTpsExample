using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine.UI;
using Cursor = UnityEngine.Cursor;

public class ServerManager : MonoBehaviourPunCallbacks
{
    public TMP_Text bilgiText;
    public Button katilButton;
    public TMP_InputField nickInput;
    private bool cursorAcik = true;
    public GameObject girisPanel;
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        bilgiText.text = "";
        katilButton.interactable = true;
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        bilgiText.text = "Hata! " + message;
    }

    public override void OnJoinedRoom()
    {
        girisPanel.SetActive(false);
        cursorAcik = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        PhotonNetwork.Instantiate("Player", new Vector3(-15,0,-29), Quaternion.identity);
    }

    private void Update()
    {
        if (cursorAcik)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void odayaKatil()
    {
        PhotonNetwork.NickName = nickInput.text;
        PhotonNetwork.JoinOrCreateRoom("oda2", new RoomOptions {MaxPlayers = 10}, TypedLobby.Default);
    }
}
