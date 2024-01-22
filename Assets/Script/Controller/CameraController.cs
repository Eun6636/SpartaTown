using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject Player;

    private Transform PlayerPos;

    void Start()
    {
        PlayerPos = Player.transform;
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(PlayerPos.position.x, PlayerPos.position.y,-10);
    }

}
