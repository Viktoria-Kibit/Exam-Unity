using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class InputDecoder
{
    public static List<Character> CharacterList = new List<Character>();

    public static void ParseInputLine(string StringToParse)
    {
        string withOutTabs = StringToParse.Replace("\t", "");
        StringToParse = withOutTabs;

        if(StringToParse.StartsWith("\""))
        {
            Say(StringToParse);
        }

        string[] SepartingString = { " ", "'", "\"", "(", ")" };
        string[] args = StringToParse.Split(SepartingString, StringSplitOptions.RemoveEmptyEntries);
        foreach(Character character in CharacterList)
        {
            if(args[0] == character.shortName)
            {
                SplitToSay(StringToParse, character);
            }
            
        }
    }

    public static void SplitToSay(string StringToParse, Character character)
    {
        int toQuote = StringToParse.IndexOf("\"") + 1;
        int endQuote = StringToParse.Length - 1;
        string StringToOutput = StringToParse.Substring(toQuote, endQuote - toQuote);
        Say(character.fullName, StringToOutput);
        
    }

    public static void Say(string what)
    {
        Debug.Log(what);
    }

    public static void Say(string who, string what)
    {
        Debug.Log(who + ": " + what);
    }
}
