using UnityEngine;
using TMPro;
using System.Collections;

public class TextFadeAnim : ITextAnim
{
    public void Play(TMP_Text text)
    {
        text.StartCoroutine(Animate(text));
    }

    private IEnumerator Animate(TMP_Text text)
    {
        Color c = text.color;
        c.a = 0;
        text.color = c;

        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime;
            c.a = t;
            text.color = c;
            yield return null;
        }
    }
}
