using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour
{
    public string inputLine;
    void Start()
    {
        
        InputDecoder.CharacterList.Add( new Character("d", "Dipper", Color.blue, "dipper_1.png"));

        inputLine = "d \"this is some text\"";
        InputDecoder.ParseInputLine(inputLine);
        

    }
}
