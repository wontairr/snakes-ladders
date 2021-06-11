using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingscript2 : MonoBehaviour
{

    private float walkingforce;
    public Rigidbody2D rb;
    public float addedForceR = 10f;
    public float addedForceL = -10f;

    // Start is called before the first frame update
    void Start()
    {
        walkingforce = 0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            walkingforce = addedForceR;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            walkingforce = 0f;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            walkingforce = addedForceL;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            walkingforce = 0f;
        }
    }


    private void FixedUpdate()
    {
        rb.GetComponent<Rigidbody2D>().AddForce(new Vector2(walkingforce, 0f), ForceMode2D.Impulse);
    }
}
