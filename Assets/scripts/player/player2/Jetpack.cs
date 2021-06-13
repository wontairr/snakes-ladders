using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jetpack : MonoBehaviour
{

    [SerializeField]
    private float fuel = 100f;

    [SerializeField]
    private Slider fuelslider;

    [SerializeField]
    private float fuelburnrate = 58.5f;

    [SerializeField]
    private float fuelrefuelrate = 35f;

    [SerializeField]
    private float refillCoolDown = 2;


    public AudioSource sfx1;

    public AudioSource sfx2;

    private float rocketforce;
    public Rigidbody2D rb;
    public float addedForce = 55f;
    private float currentfuel;
    public bool isFlying;
    private bool haveFuel;
    private float Timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rocketforce = 0f;
        currentfuel = fuel;
        isFlying = false;
        haveFuel = true;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            check();
            rocketforce = addedForce;
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            rocketforce = 0f;
            sfx2.Stop();
            sfx1.Play();
        }

        fuelslider.value = currentfuel / fuel;

        if (currentfuel < 0)
        {
            haveFuel = false;
            currentfuel = 0;
        }

        if (!haveFuel)
        {
            Timer += Time.deltaTime;
            if (Timer >= refillCoolDown)
            {
                haveFuel = true;
                Timer = 0;
            }
        }
    }

    public void SuperJetPackON()
    {
        addedForce = 1500f;
        fuelburnrate = 5f;
        fuel = 500f;
    }
    public void SuperJetPackOFF()
    {
        addedForce = 780f;
        fuelburnrate = 58.5f;
        fuel = 100f;

    }

    private void FixedUpdate()
    {
        if (rocketforce > 0.1f && haveFuel)
        {
            currentfuel -= fuelburnrate * Time.deltaTime;
            rb.GetComponent<Rigidbody2D>().AddForce(Vector2.up * rocketforce);
            isFlying = true;
        }
        else if (rocketforce < 0.1f && !haveFuel)
        {
            isFlying = false;
        }

        if (!isFlying)
        {
            RefillFuel();
        }

    }


    private void RefillFuel()
    {
        if(currentfuel < fuel && haveFuel)
        {
            currentfuel += fuelrefuelrate * Time.deltaTime;
        }
    }

    private void check()
    {
        if (haveFuel && currentfuel > fuel)
        {
            sfx2.Play();
        }
        else if (!haveFuel)
        {
            sfx2.Stop();
        }
    }
}
