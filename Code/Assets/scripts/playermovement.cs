using UnityEngine;

public class playermovement : MonoBehaviour {
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
	
	// we marked this as fixed update coz unity likes it
    //are using it to mess up with physics
	void FixedUpdate ()
    {
        //add force using a variable
        rb.AddForce(0, 0, forwardForce  * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<gamemanage>().EndGame();

        }
        if(Input.GetKey("w"))
        {
            forwardForce = 1000f;
        }
        if(Input.GetKey("s"))
        {
            forwardForce = 100f;
        }

    }
}
