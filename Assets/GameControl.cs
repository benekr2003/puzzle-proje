using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private Transform[] pictures;

    [SerializeField]
    private GameObject winText;

    public static bool youwin;


    // Use this for initialization void Start () {

    void Start()
    {
        winText.SetActive(false);
        youwin = false;
    }

    void Update()
    {
        if (pictures[0].rotation.z == 0 &&
             pictures[1].rotation.z == 0 &&
             pictures[2].rotation.z == 0 &&
             pictures[3].rotation.z == 0 &&
             pictures[4].rotation.z == 0 &&
             pictures[5].rotation.z == 0 &&
             pictures[6].rotation.z == 0 &&
             pictures[7].rotation.z == 0 &&
             pictures[8].rotation.z == 0 &&
             pictures[9].rotation.z == 0 &&
             pictures[10].rotation.z == 0 &&
             pictures[11].rotation.z == 0)
        {


            youwin = true;
            winText.SetActive(true);


        }
    }
}
