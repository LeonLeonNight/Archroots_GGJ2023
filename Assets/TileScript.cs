using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;

    private void Awake()
    {
        rigidbody2D.gravityScale = 0;
    }
    
}
