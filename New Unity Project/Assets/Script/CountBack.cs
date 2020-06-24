using UnityEngine;
using UnityEngine.UI;

public class CountBack : MonoBehaviour
{
    public Image begin;
    public int count = 3;
    public AudioSource BackSource;
   

    void Start()
    {
        InvokeRepeating("count_back",0.5f,1f);
    }

    void count_back()
    {
        if(count!=0)
        {
            gameObject.GetComponent<Text>().text = count.ToString();
            BackSource.Play();
            count--;

        }
        else
        {
            gameObject.GetComponent<Text>().text = "";
            begin.enabled = false;
                        
        }
        
    }

    
}
