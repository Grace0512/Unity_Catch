using UnityEngine;
using UnityEngine.UI;


public class Stick : MonoBehaviour
{
    public Text Get;

    public GameManager gm;

    public AudioSource GetAudio;



    void Update()
    {
      
       gameObject.transform.Translate(Vector3.down*18f);
        
    }

    public void MouseDown()
    {
        gm.Catch_num++;
        Get.GetComponent<Text>().text = "" + gm.Catch_num;
        GetAudio.Play();
        Destroy(gameObject);
    }

    

}
