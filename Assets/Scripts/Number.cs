using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour
{
    private Image image;
    private Text text;

    public void Awake()
    {
        image = GetComponent<Image>();
        text = transform.Find("Text").GetComponent<Text>();
    }

    public void SetText(string s)
    {
        text.text = s;
    }
}