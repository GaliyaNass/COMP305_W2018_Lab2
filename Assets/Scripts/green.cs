using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class green : MonoBehaviour {
    public Sprite greenGaliya;
    public Sprite redGaliya;
    public Sprite yellowGaliya;
    public GameObject galiya;
    private SpriteRenderer sRend;

	// Use this for initialization
	void Start () {
        sRend = galiya.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if (sRend.sprite == greenGaliya)
        {
            sRend.sprite = greenGaliya;
        }
        else if (sRend.sprite == redGaliya)
        {
            sRend.sprite = greenGaliya;
        }
        else if (sRend.sprite == yellowGaliya)
        {
            sRend.sprite = greenGaliya;
        }
    }
}
