using UnityEngine;

public abstract class UIThemedElement : MonoBehaviour
{
    protected virtual void OnEnable()
    {
        UIThemeManager.OnThemeChanged += Refresh;
        Refresh();
    }
    protected virtual void OnDisable()
    {
        UIThemeManager.OnThemeChanged -= Refresh;   
    }

    private void Refresh()
    {
        if (UIThemeManager.Instance == null) return;
        ApplyTheme(UIThemeManager.Instance.Theme);
    }

    public abstract void ApplyTheme(ScriptableUITheme theme);
}
