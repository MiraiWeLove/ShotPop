using UnityEngine;
using TMPro;
using System.Collections;

public class Timer : MonoBehaviour
{
    [SerializeField] private float duration;

    private TMP_Text text;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    public void StartTimer()
    {
        StartCoroutine(Count());
    }

    private IEnumerator Count()
    {
        float t = 0f;
        while (t < duration)
        {
            text.text = Mathf.Floor(t).ToString();
            t += Time.deltaTime;
            yield return null;
        }
    }

}
