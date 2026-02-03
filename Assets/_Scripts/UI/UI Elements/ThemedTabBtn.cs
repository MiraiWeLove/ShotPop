using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ThemedTabBtn : UIThemedElement,
    ISelectHandler,
    IDeselectHandler
{
    [SerializeField] private Button button;
    [SerializeField] private TMP_Text text;

    public override void ApplyTheme(UITheme theme)
    {
        ColorBlock cb = button.colors;

        cb.normalColor = theme.TabNormal;
        cb.highlightedColor = theme.TabHover;
        cb.pressedColor = theme.TabPressed;
        cb.selectedColor = theme.PanelPrimary;
        button.colors = cb;

        text.color = theme.TextPassive;
    }
    public void OnSelect(BaseEventData eventData)
    {
        text.color = UIThemeManager.Instance.Theme.TextSelected;
    }

    public void OnDeselect(BaseEventData eventData)
    {
        text.color = UIThemeManager.Instance.Theme.TextPassive;
    }
}
