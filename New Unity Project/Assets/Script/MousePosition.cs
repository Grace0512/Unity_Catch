using UnityEngine;
using UnityEngine.UI;

public class MousePosition : MonoBehaviour
{
    public GameObject girl;
  
    private void Update()
    {
        if(Input.GetMouseButtonDown(0)==true)
        {
            Vector2 m_position = Input.mousePosition;
            girl.transform.position = m_position;
        }
        
    }
    

   
}
