using UnityEngine;

public class RaycastGun : MonoBehaviour
{
    public Material test;
    public Camera mainCam;
    public LayerMask shootMask;
    public ParticleSystem shootParticles;
    public float pushForce;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit,Mathf.Infinity , shootMask))
        {
            shootParticles.Play();
            if(hit.transform.CompareTag("Rod"))
            {
                int score = PlayerPrefs.GetInt("Score", 0);
                score++;
                PlayerPrefs.SetInt("Score", score);
                hit.transform.GetComponent<TargetController>().PushBack(pushForce);
            }
        }
    }
}
