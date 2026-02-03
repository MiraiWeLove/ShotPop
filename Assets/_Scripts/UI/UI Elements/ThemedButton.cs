using UnityEngine;
using UnityEngine.UI;

public class ThemedButton : UIThemedElement
{
    private Button button;

    protected override void OnEnable()
    {
        button = GetComponent<Button>();
        base.OnEnable();
    }

    public override void ApplyTheme(UITheme theme)
    {
        ColorBlock cb = button.colors;

        cb.normalColor = theme.ActionNormal;
        cb.highlightedColor = theme.ActionHover;
        cb.pressedColor = theme.ActionPressed;
        cb.disabledColor = theme.ActionDisabled;
        cb.selectedColor = theme.ActionSelected;

        button.colors = cb;
    }
}
