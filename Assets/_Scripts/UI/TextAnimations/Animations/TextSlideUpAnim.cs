using UnityEngine;
using TMPro;
using System.Collections;

public class TextSlideUpAnim : ITextAnim
{
    public void Play(TMP_Text text)
    {
        text.StartCoroutine(Animate(text));
    }

    private IEnumerator Animate(TMP_Text text)
    {
        RectTransform rt = text.rectTransform;
        Vector2 start = rt.anchoredPosition;
        Vector2 end = start + Vector2.up * 30f;

        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime * 4f;
            rt.anchoredPosition = Vector2.Lerp(start, end, t);
            yield return null;
        }
    }
}
