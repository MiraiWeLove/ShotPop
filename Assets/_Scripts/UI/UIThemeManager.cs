using UnityEngine;
using System;

public class UIThemeManager : MonoBehaviour
{
    public static UIThemeManager Instance { get; private set; }

    [SerializeField] private UITheme defaultTheme;
    public UITheme Theme { get; private set; }

    public static event Action OnThemeChanged;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        ApplyTheme(defaultTheme);
    }

    public void ApplyTheme(UITheme theme)
    {
        Theme = theme;
        OnThemeChanged?.Invoke();
    }
}