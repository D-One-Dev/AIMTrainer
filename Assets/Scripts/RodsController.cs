using UnityEngine;

public class RodsController : MonoBehaviour
{
    public GameObject[] leftRods, rightRods, frontRods, backRods;
    public float speed;
    public int[] leftDelays, rightDelays, frontDelays, backDelays;
    public int secondsTillSpeedUp;
    private float currentTime;
    private bool stopped = false;
    private int minDelay, maxDelay;
    void Start()
    {
        speed = PlayerPrefs.GetFloat("RodsStartSpeed", .1f);
        minDelay = Mathf.RoundToInt(PlayerPrefs.GetFloat("MinimumStartDelay", 1f));
        maxDelay = Mathf.RoundToInt(PlayerPrefs.GetFloat("MaximumStartDelay", 10f));
        for(int i = 0; i < leftDelays.Length; i++)
        {
            leftDelays[i] = Random.Range(minDelay,maxDelay);
        }
        for(int i = 0; i < rightDelays.Length; i++)
        {
            rightDelays[i] = Random.Range(minDelay,maxDelay);
        }
        for(int i = 0; i < frontDelays.Length; i++)
        {
            frontDelays[i] = Random.Range(minDelay,maxDelay);
        }
        for(int i = 0; i < backDelays.Length; i++)
        {
            backDelays[i] = Random.Range(minDelay,maxDelay);
        }
    }
    void FixedUpdate()
    {
        for(int x = 0; x < leftRods.Length; x++)
        {
            if(leftDelays[x] < Time.time)
            {
                leftRods[x].GetComponent<Rigidbody>().velocity = Vector3.right * speed;
            }
        }
        for(int x = 0; x < rightRods.Length; x++)
        {
            if(rightDelays[x] < Time.time)
            {
                rightRods[x].GetComponent<Rigidbody>().velocity = Vector3.left * speed;
            }
        }
        for(int x = 0; x < frontRods.Length; x++)
        {
            if(frontDelays[x] < Time.time)
            {
                frontRods[x].GetComponent<Rigidbody>().velocity = Vector3.back * speed;
            }
        }
        for(int x = 0; x < backRods.Length; x++)
        {
            if(backDelays[x] < Time.time)
            {
                backRods[x].GetComponent<Rigidbody>().velocity = Vector3.forward * speed;
            }
        }
        if(stopped == false) currentTime += Time.fixedDeltaTime;
        if(currentTime > secondsTillSpeedUp)
        {
            speed += .1f;
            currentTime = 0;
        }
    }
    public void Stop()
    {
        speed = 0;
        stopped = true;
    }
}
