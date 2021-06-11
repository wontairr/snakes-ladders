using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animcontroller2 : MonoBehaviour
{
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("walkingR", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("walkingR", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("walkingL", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("walkingL", false);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("crouching", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("crouching", false);
        }
    }
}
