using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public UnityEngine.UI.Text text;
    string stringString = "Time";



    // Use this for initialization
    void Start()
    {
        text = GetComponent<UnityEngine.UI.Text>();
    }

    // Update is called once per frame

    void OnGUI()
    {
        text.text = "Goat Game";
    }
}
