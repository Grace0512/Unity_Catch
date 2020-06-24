using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    public Text score;
    public Text scoreEnd;

    private void Update()
    {
        scoreEnd.GetComponent<Text>().text = score.GetComponent<Text>().text;
    }
}
