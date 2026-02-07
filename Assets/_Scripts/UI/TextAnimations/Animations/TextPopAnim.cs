using UnityEngine;
using TMPro;
using System.Collections;

public class TextPopAnim : ITextAnim
{
    public void Play(TMP_Text text)
    {
        text.StartCoroutine(Animate(text));
    }

    private IEnumerator Animate(TMP_Text text)
    {
        RectTransform rt = text.rectTransform;

        Vector3 start = Vector3.one;
        Vector3 pop = Vector3.one * 3f;

        float t = 0;
        while (t < 0.2f)
        {
            t += Time.deltaTime;
            rt.localScale = Vector3.Lerp(start, pop, t);
            yield return null;
        }

        rt.localScale = start;
    }
}
