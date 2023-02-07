using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCursor : MonoBehaviour
{
    Texture2D DragHand;
    Texture2D Finger;
    Texture2D bellHand;
    Texture2D ovenHand;

    // Start is called before the first frame update
    void Start()
    {
        DragHand = Resources.Load<Texture2D>("DragHand");
        Finger = Resources.Load<Texture2D>("Finger");
        bellHand = Resources.Load<Texture2D>("bellHand");
        ovenHand = Resources.Load<Texture2D>("ovenHand"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDrag()
    {
        Cursor.SetCursor(DragHand, new Vector2(0, 0), CursorMode.Auto);
    }

    public void SetOrigin()
    {
        Cursor.SetCursor(Finger, new Vector2(0, 0), CursorMode.Auto);
    }

    public void onBell()
    {
        Cursor.SetCursor(bellHand, new Vector2(0, 0), CursorMode.Auto);
    }
    public void OnOven()
    {
        Cursor.SetCursor(ovenHand, new Vector2(0, 0), CursorMode.Auto);

    }
}
