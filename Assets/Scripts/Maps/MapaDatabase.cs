using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MapaDatabase : ScriptableObject
{
    public Mapa[] mapa;

    public int MapCount
    {
        get
        {
            return mapa.Length;
        }
    }

    public Mapa GetMapa(int index)
    {
        return mapa[index];
    }
}
