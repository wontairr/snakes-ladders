using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript2 : MonoBehaviour
{
    public bool IsGrounded2 = false;

    public GameObject player;

    public float jumpheight = 800f;

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
        if (Input.GetKeyDown(KeyCode.W) && IsGrounded2 == true)
        {
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpheight), ForceMode2D.Impulse);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 0f), ForceMode2D.Impulse);
        }
    }
}
