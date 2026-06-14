using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpPower = 100f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.linearVelocity = new Vector3(
                    rb.linearVelocity.x,
                    jumpPower,
                    rb.linearVelocity.z
                );
            }
        }
    }
}