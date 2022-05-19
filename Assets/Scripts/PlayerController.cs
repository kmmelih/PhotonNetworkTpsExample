using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Pun.Demo.PunBasics;
using Photon.Realtime;

public class PlayerController : MonoBehaviour
{
    private PhotonView _pv;
    private Rigidbody _rb;
    [SerializeField] private float speed;
    private void Start()
    {
        CameraWork _cameraWork = GetComponent<CameraWork>();
        _pv = GetComponent<PhotonView>();
        _rb = GetComponent<Rigidbody>();
        /*
        if (_cameraWork != null)
        {
            if (_pv.IsMine)
            {
                _cameraWork.OnStartFollowing();
            }
        }
        */
    }

    private void Update()
    {
        /*
        if (_pv.IsMine)
        {
            _rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, _rb.velocity.y, Input.GetAxis("Vertical") * speed);
        }
        */
    }
}
