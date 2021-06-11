using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grounded2 : MonoBehaviour
{

    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "ground")
        {
            Player.GetComponent<JumpScript2>().IsGrounded2 = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "ground")
        {
            Player.GetComponent<JumpScript2>().IsGrounded2 = false;
        }
    }
}
