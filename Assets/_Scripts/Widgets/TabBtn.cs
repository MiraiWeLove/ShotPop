using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TabBtn : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private TMP_Text text;

    private TabManager manager;
    private S_Tab tab;
    public void Initialize(TabManager manager, S_Tab tab)
    {
        this.manager = manager;
        this.tab = tab;

        text.text = tab.TabName;
        button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        if (manager != null)
        {
            manager.OpenTab(tab);
        }
    }

}