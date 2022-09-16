using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalinput;
    public float speed;
    public float verticalinput;
    public Rigidbody2D player;

    void Start()
    {
        
    }
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        verticalinput = Input.GetAxis("Vertical");
        player.AddForce(Vector2.up * speed * Time.deltaTime *verticalinput , ForceMode2D.Force);
        player.AddForce(Vector2.right * speed * Time.deltaTime * horizontalinput, ForceMode2D.Force);
    }
}
