using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public Action<Vector2> onMove;
    public Action onJump;

    private void OnEnable()
    {
        onMove += PlayerMovement;
        onJump += PlayerJump;
    }

    public void PlayerMovement(Vector2 moveVec)
    {
        Debug.Log(moveVec);
    }

    public void PlayerJump()
    {
        Debug.Log("Jump!");
    }

    private void OnDisable()
    {
        onMove -= PlayerMovement;
        onJump -= PlayerJump;
    }
}
