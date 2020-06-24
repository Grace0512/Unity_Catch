using UnityEngine;
using UnityEngine.UI;

public class Stick : MonoBehaviour
{
    public Text Get;

    public GameManager gm;


    void Update()
    {
       gameObject.transform.Translate(Vector3.down*10f);
    }

    public void MouseDown()
    {
        gm.Catch_num++;
        Get.GetComponent<Text>().text = "Get:"+ gm.Catch_num;
        Destroy(gameObject);
    }

}
