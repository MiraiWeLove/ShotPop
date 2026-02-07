using UnityEngine;
using TMPro;

public class UITextAnimator : MonoBehaviour
{
    private TMP_Text text;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    public void Play()
    {
        TextAnimFactory.Play(TextAnim.Pop, text);
    }
}
