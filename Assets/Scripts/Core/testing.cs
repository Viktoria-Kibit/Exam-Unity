using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour
{
    public string inputLine;
    void Start()
    {
        
        InputDecoder.CharacterList.Add( new Character("d", "Dipper", Color.blue, "dipper_1.png"));

        inputLine = "Character(d, Dipper, color=red, image=Dipper)";
        InputDecoder.ParseInputLine(inputLine);

        inputLine = "d \"this is some text\"";
        InputDecoder.ParseInputLine(inputLine);

        inputLine = "show bg_1";
        InputDecoder.ParseInputLine(inputLine);

    }

    void Update()
    {

    if (Input.GetMouseButtonDown(0))
        {
            if(InputDecoder.InterfaceElements.activeInHierarchy)
            {
                InputDecoder.InterfaceElements.SetActive(false);
            }
            else{
                InputDecoder.InterfaceElements.SetActive(true);
            }
        }

    }
}
