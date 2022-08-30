using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CartelDatabase : ScriptableObject
{
    public Cartel[] cartel;

    public int CharacterCount
    {
        get
        {
            return cartel.Length;
        }
    }

    public Cartel GetCartel(int index)
    {
        return cartel[index];
    }
}