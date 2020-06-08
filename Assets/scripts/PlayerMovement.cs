using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardforce= 2000f;
    public float sidewaysforce = 500f;
    void Start()
    {
        forwardforce = UnityEngine.RemoteSettings.GetFloat("forwardforce");
    }

   
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y<-1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
