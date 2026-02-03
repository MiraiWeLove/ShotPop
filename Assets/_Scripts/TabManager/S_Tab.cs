using UnityEngine;

[CreateAssetMenu(fileName = "S_Tab", menuName = "Scriptables/Tab")]

public class S_Tab : ScriptableObject
{
    [field: SerializeField] public string TabName { get; private set; }
    [field: Tooltip("Unique id, e.g. : theme; audio; keybinds")]
    [field: SerializeField] public string ID { get; private set; }


}
