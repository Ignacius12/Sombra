using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Jugador : MonoBehaviour
{
    public float horizontalMove;
    public float verticalMove;
    public CharacterController Player;
    public float playerSpeed;
    float currentSpeed;

    void Start()
    {
        Player = GetComponent<CharacterController>();
        currentSpeed = playerSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {

        Player.Move(new Vector3(horizontalMove, -9.8f, verticalMove) * currentSpeed * Time.deltaTime);
    }

    public float getOriginalSpeed()
    {
        return playerSpeed;
    }
    public float getCurrentSpeed()
    {
        return currentSpeed;
    }

    public void setCurrentSpeed(float newSpeed)
    {
        currentSpeed = newSpeed;
    }

}
