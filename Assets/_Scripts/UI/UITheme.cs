using UnityEngine;

[CreateAssetMenu (fileName = "UITheme", menuName = "Scriptables/UI Theme")]
public class UITheme : ScriptableObject
{
    [field: Header ("General")]
    [field: Space(4)]

    [field: SerializeField] public Color PanelPrimary { get; private set; }
    [field: SerializeField] public Color PanelSecondary { get; private set; }


    [field: Header ("Tab")]
    [field: Space(4)]

    [field: SerializeField] public Color TabNormal { get; private set; }
    [field: SerializeField] public Color TabHover { get; private set; }
    [field: SerializeField] public Color TabPressed { get; private set; }



    [field: Header ("Text")]
    [field: Space(4)]

    [field: SerializeField] public Color TextColor { get; private set; }
    [field: SerializeField] public Color TextNormal { get; private set; }
    [field: SerializeField] public Color TextHover { get; private set; }
    [field: SerializeField] public Color TextSelected { get; private set; }
    [field: SerializeField] public Color TextPressed { get; private set; }
    [field: SerializeField] public Color TextPassive { get; private set; }



    [field: Header("Action Elements")]
    [field: Space(4)]

    [field: SerializeField] public Color ActionNormal { get; private set; }
    [field: SerializeField] public Color ActionHover { get; private set; }
    [field: SerializeField] public Color ActionPressed { get; private set; }
    [field: SerializeField] public Color ActionDisabled { get; private set; }
    [field: SerializeField] public Color ActionSelected { get; private set; }
}
