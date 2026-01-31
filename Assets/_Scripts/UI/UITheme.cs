using UnityEngine;

[CreateAssetMenu (fileName = "UITheme", menuName = "Scriptables/UI Theme")]
public class UITheme : ScriptableObject
{
    [Header ("Text")]
    [field: SerializeField] public Color textColor { get; private set; }
    [field: SerializeField] public Color textNormal { get; private set; }
    [field: SerializeField] public Color textHover { get; private set; }
    [field: SerializeField] public Color textSelected { get; private set; }
    [field: SerializeField] public Color textPressed { get; private set; }



    [Header("Action Elements")]
    [field: SerializeField] public Color actionNormal { get; private set; }
    [field: SerializeField] public Color actionHover { get; private set; }
    [field: SerializeField] public Color actionPressed { get; private set; }
    [field: SerializeField] public Color actionDisabled { get; private set; }
    [field: SerializeField] public Color actionSelected { get; private set; }




}
