
using UnityEngine;

public class objectfollow : MonoBehaviour
{
    //Object to follow
    public Transform target;
    //Rigidbody to move
    public Rigidbody2D rb2d;
    public float speed = 7.0f;
    //Distance to start moving
    public float minDistance = 0.09f;

    void FixedUpdate()
    {
        //Find direction
        Vector3 dir = (target.transform.position - rb2d.transform.position).normalized;
        //Check if we need to follow object then do so 
        if (Vector3.Distance(target.transform.position, rb2d.transform.position) > minDistance)
        {
            rb2d.MovePosition(rb2d.transform.position + dir * speed * Time.fixedDeltaTime);
        }
    }
}