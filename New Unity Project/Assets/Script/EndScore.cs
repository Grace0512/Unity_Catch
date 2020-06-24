using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    public Text score;
    public Text scoreEnd;

    public AudioSource EndAudio;

    public float timer = 9;

    private void Update()
    {
        scoreEnd.GetComponent<Text>().text = score.GetComponent<Text>().text;
        if (gameObject.GetComponent<Canvas>().enabled == true)
        {
            if (Time.time - timer > 9f)
            {
                timer = Time.time;
                EndAudio.Play();
            }
        }
    }
}
