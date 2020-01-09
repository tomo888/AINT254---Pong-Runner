using System.Collections;
using UnityEngine;


public class BallBehaviour : MonoBehaviour
{
    /**this class pushes the ball at the start of the game,
     *and also prevents the ball from going at too quick a pace**/
    public Vector3 initialImpulse;
    public float maxSpeed;


    void Start()
    {
        StartCoroutine(DelayedBallImpulse());
    }

    IEnumerator DelayedBallImpulse()
    {
        yield return new WaitForSeconds(3);
        GetComponent<Rigidbody>().AddForce(initialImpulse, ForceMode.Impulse); //forces the ball to move in given direction. To change speed/direction, edit initialImpulse value.
    }
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed); //prevents ball going too fast
        }
        /**opted not to clamp the speed of the ball to a minimum value, as this was too buggy to be worth fixing a relatively rare issue**/
    }
}
