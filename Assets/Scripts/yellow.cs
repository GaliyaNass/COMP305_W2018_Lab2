using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellow : MonoBehaviour {
    public Sprite greenGaliya;
    public Sprite redGaliya;
    public Sprite yellowGaliya;
    public GameObject galiya;
    private SpriteRenderer sRend;

    // Use this for initialization
    void Start()
    {
        sRend = galiya.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (sRend.sprite == greenGaliya)
        {
            sRend.sprite = yellowGaliya;
        }
        else if (sRend.sprite == redGaliya)
        {
            sRend.sprite = yellowGaliya;
        }
        else if (sRend.sprite == yellowGaliya)
        {
            sRend.sprite = yellowGaliya;
        }
    }
}
