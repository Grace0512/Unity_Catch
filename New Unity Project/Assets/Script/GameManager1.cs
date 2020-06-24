using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    public GameObject[] stick;

    public float lastTime;

    public int Catch_num = 0;

    public Canvas end;

     void Update()
    {
        stick = GameObject.FindGameObjectsWithTag("棍子");
        if(stick.Length == 0)
        {
            end.enabled=true;
           
        }
        else
        {
            if(Time.time-lastTime>3.5f)
            {
                   if (Input.GetKeyDown(KeyCode.Space))Random_Drop();
            }
                                
        }
    }

    private void Start()
    {
        lastTime = Time.time ;
        end.enabled = false;
    }

    void Random_Drop()
    {
        int ran = Random.Range(0, stick.Length);
        stick[ran].GetComponent<Stick1>().enabled = true;
        Destroy(stick[ran], 0.8f);
        

    }

   
}
