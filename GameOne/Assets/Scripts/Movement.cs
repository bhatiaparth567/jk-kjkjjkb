using UnityEngine;
public class Movement : MonoBehaviour
{
    public Rigidbody b;

    public float forwForce = 1000f; public float sideForce = 300f; public float jumpForce = 300f;

    // Update is called once per frame
    void Update()
    {
        b.AddForce(0, 0, forwForce * Time.deltaTime);

        if (Input.GetKey("w"))
            b.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        if (Input.GetKey("d"))
            b.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (Input.GetKey("a"))
            b.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
