using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
   

    private BoxCollider2D _boxCollider2D;
    // Start is called before the first frame update
    void Start()
    {
        _boxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Open()
    {
        _boxCollider2D.excludeLayers += (1 << LayerMask.NameToLayer("Player"));
    }
}
