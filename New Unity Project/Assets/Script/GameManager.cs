using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] stick;

    [Header("掉落速度")]
    public int speed=20;

    public float ran_time;

    public float lastTime;

    public int Catch_num = 0;

     void Update()
    {
        stick = GameObject.FindGameObjectsWithTag("棍子");
        if (ran_time < Time.time - lastTime)
        {
            Random_Drop();
        }
    }

    private void Start()
    {
        lastTime = 4;
        ran_time = Random.Range(0.1f, 1.2f);
    }

    void Random_Drop()
    {
        int ran = Random.Range(0, stick.Length);
        stick[ran].GetComponent<Stick>().enabled = true;
        lastTime = Time.time;
        ran_time = Random.Range(0.8f, 2f);
        Destroy(stick[ran], 10f);
        

    }

   
}
