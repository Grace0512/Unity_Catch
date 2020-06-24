using UnityEngine;
using UnityEngine.UI;


public class Stick1 : MonoBehaviour
{
    public Text Get;

    public GameManager1 gm;


    void Update()
    {
       gameObject.transform.Translate(Vector3.down*20f);
        
    }

    public void MouseDown()
    {
        gm.Catch_num++;
        Get.GetComponent<Text>().text = ""+gm.Catch_num;
        Destroy(gameObject);
    }

    

}
