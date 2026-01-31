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

        cb.normalColor = theme.actionNormal;
        cb.highlightedColor = theme.actionHover;
        cb.pressedColor = theme.actionPressed;
        cb.disabledColor = theme.actionDisabled;
        cb.selectedColor = theme.actionSelected;

        button.colors = cb;
    }
}
