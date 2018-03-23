using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPoint : MonoBehaviour {
    public Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    public void redColorChange()
    {
        Color redTeam = new Color(0.698f, 0.243f, .160f, .627f);
        rend.material.SetColor("_Color", redTeam);
        
    }

    public void blueColorChange()
    {
        Color blueTeam = new Color(.196f, .368f, .698f, .627f);
        rend.material.SetColor("_Color", blueTeam);
    }

    public void resetColor()
    {
        Color noTeam = new Color(0.819f, 1f, .427f, .627f);
        rend.material.SetColor("_Color", noTeam);
    }
}
