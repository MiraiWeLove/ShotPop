using System.Collections.Generic;
using UnityEngine;


public class TabManager : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] private TabBtn tabBtnPrefab;
    [SerializeField] private Transform headerPanel;

    [Header("Bindings")]
    [SerializeField] private List<TabView> panels;

    private Dictionary<S_Tab, GameObject> panelByTab = new();
    private List<TabBtn> tabs = new();

    private S_Tab current;

    private void Awake()
    {
        foreach (var p in panels)
        {
            if (panelByTab.ContainsKey(p.tab))
                Debug.LogError($"Duplicate tab binding for {p.tab.name}", this);
            else
                panelByTab.Add(p.tab, p.panel);
        }
    }

    private void Start()
    {
        CreateTabs(panels);
        OpenTab(panels[0].tab);
    }

    private void CreateTabs(List<TabView> tabs)
    {
        ClearTabs(headerPanel);

        foreach (var t in tabs)
        {
            TabBtn btn = Instantiate(tabBtnPrefab, headerPanel);
            btn.Initialize(this, t.tab);
            this.tabs.Add(btn);
        }
    }

    public void OpenTab(S_Tab tab)
    {
        if (current == tab)
            return;

        foreach (var p in panelByTab.Values)
            p.SetActive(false);

        if (!panelByTab.TryGetValue(tab, out var panel))
        {
            Debug.LogError($"No panel bound for tab {tab.name}", this);
            return;
        }

        panel.SetActive(true);
        panelByTab[tab].SetActive(true);
        current = tab;
    }

    private void ClearTabs(Transform header)
    {
        foreach (Transform c in header)
            Destroy(c.gameObject);

        tabs.Clear();
    }

    //Go through every tab and set it's state (selected or not) so it will refresh it's visual based on whether it's selected or not.
    public void Select(TabBtn tab)
    {
        foreach (var t in tabs)
        {
            ThemedTabBtn tabTheme = t.GetComponent<ThemedTabBtn>();
            tabTheme.SetSelected(t == tab);
        }
    }


#if UNITY_EDITOR
    private void OnValidate()
    {
        if (panels == null) return;

        var set = new HashSet<S_Tab>();
        foreach (var p in panels)
        {
            if (p.tab == null) continue;

            if (!set.Add(p.tab))
                Debug.LogError($"Duplicate tab binding for {p.tab.name}", this);
        }
    }
#endif
}

