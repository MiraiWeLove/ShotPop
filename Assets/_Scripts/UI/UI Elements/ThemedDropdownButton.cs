using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ThemedDropdownButton : UIThemedElement
{
    private TMP_Dropdown dropdown;
    [Space]
    [SerializeField] private Toggle itemToggle;
    [SerializeField] private TMP_Text itemText;
    [SerializeField] private Image templateImage;
    [SerializeField] private Image itemCheckmark;


    protected override void OnEnable()
    {
        dropdown = GetComponent<TMP_Dropdown>();
        base.OnEnable();
    }

    public override void ApplyTheme(UITheme theme)
    {
        if (dropdown != null
            && itemToggle != null
            && templateImage != null
            && itemText != null
            && itemCheckmark != null)
        {
            ColorBlock cb = dropdown.colors;

            cb.normalColor = theme.actionNormal;
            cb.highlightedColor = theme.actionHover;
            cb.pressedColor = theme.actionPressed;
            cb.disabledColor = theme.actionDisabled;
            cb.selectedColor = theme.actionSelected;

            dropdown.colors = cb;
            itemToggle.colors = cb;
            templateImage.color = theme.actionNormal;
            itemCheckmark.color = theme.actionSelected;

            dropdown.captionText.color = theme.textColor;
            itemText.color = theme.textColor;
        } else
        {
            Debug.LogWarning(this + " The theme will not be applied. One of the required fields in ThemedDropDownButton is not set.");
        }
    }
}
