using UnityEngine;

public class TargetController : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }    public void PushBack(float pushForce)
    {
        rb.AddForce(rb.velocity * -pushForce);
    }
}
