using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject platform, rods, mainCam;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Rod"))
        {
            Destroy(platform);
            rods.GetComponent<RodsController>().Stop();
            mainCam.GetComponent<GameOverController>().GameOver(5);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
