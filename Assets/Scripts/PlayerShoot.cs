using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootForce;
    bool shooting;
    public Camera mainCamera;
    public Transform shootPoint;
    private void Update()
    {
        MyInput();
    }
    private void MyInput()
    {
        shooting = Input.GetKeyDown(KeyCode.Mouse0);
        if(shooting)
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        Ray ray = mainCamera.ViewportPointToRay(new Vector3(.5f, .5f, 0f));
        RaycastHit hit;
        Vector3 targetPoint;
        if(Physics.Raycast(ray, out hit)) targetPoint = hit.point;
        else targetPoint = ray.GetPoint(75);
        Vector3 direction = targetPoint - shootPoint.position;
        GameObject currentBullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
        currentBullet.transform.forward = direction.normalized;
        currentBullet.GetComponent<Rigidbody>().AddForce(direction.normalized * shootForce, ForceMode.Impulse);
    }
}
