using UnityEngine;
using TMPro;
using System.Collections;
using System;

public class CountDown : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private int startValue = 3;

    private UITextAnimator animator ;
    private Coroutine routine;
    private Action onFinished;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
        animator = GetComponent<UITextAnimator>();
    }


    public void StartCountdown(Action finishedCallBack)    
    {
        onFinished = finishedCallBack;

        if (routine != null)
            StopCoroutine(routine);

        routine = StartCoroutine(Countdown());
    }

    private IEnumerator Countdown()
    {
        int current = startValue;

        while (current >= 1)
        {
            text.text = current.ToString();
            animator.Play();
            yield return new WaitForSeconds(1f);
            current--;
        }

        text.text = "GO!";
        animator.Play();
        yield return new WaitForSeconds(0.5f);

        text.gameObject.SetActive(false);
        onFinished?.Invoke();
    }
}
