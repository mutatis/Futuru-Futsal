using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour
{
    bool click;

    float mousex;
    float mousey;

    void Update()
    {
        mousex = Input.mousePosition.x;

        mousey = Input.mousePosition.y;

        if (click)
        {
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(mousex, mousey, 10));
        }
    }

    public void OnMouseDown()
    {
        click = true;
    }

    public void OnMouseUp()
    {
        click = false;
    }
}
