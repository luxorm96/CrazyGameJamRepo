using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;

    //set the start point randomly from initial 4 starting points
    public Transform[] startPoints;

    public Transform[] path;
    
    private void Awake()
    {
        main = this;
    }

}
