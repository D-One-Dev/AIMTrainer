using UnityEngine;

public class FloorCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0f;
        }
    }
}
