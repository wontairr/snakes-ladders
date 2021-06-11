using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchScript : MonoBehaviour
{
    public bool IsGrounded = false;

    public GameObject player;

    public float crouchheight = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Jump();

    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, crouchheight), ForceMode2D.Impulse);
        }
    }
}
