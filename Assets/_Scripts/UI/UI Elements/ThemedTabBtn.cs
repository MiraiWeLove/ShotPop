using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ThemedTabBtn : UIThemedElement
{
    [SerializeField] private Button button;
    [SerializeField] private TMP_Text text;
    [SerializeField] private Image image;

    private bool selected = false;
    public override void ApplyTheme(ScriptableUITheme theme)
    {
        RefreshVisual();
    }

    public void RefreshVisual()
    {
        ScriptableUITheme theme = UIThemeManager.Instance.Theme;

        if (selected)
        {
            image.color = theme.PanelPrimary;
        }
        else {
            image.color = theme.TabNormal;
        }

    }
    public void SetSelected(bool value)
    {
        selected = value;
        RefreshVisual();
    }
}
