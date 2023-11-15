using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managment : MonoBehaviour
{
    public Camera camera;
    public SelectObject Hovered;
    public List<SelectObject> ListOfSelected = new List<SelectObject>();
    void Update()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.red);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.GetComponent<SelectableCollider>())
            {
                SelectObject hitSelecteble = hit.collider.GetComponent<SelectableCollider>().selectObject;
                if (Hovered)
                {
                    if (Hovered != hitSelecteble)
                    {
                        Hovered.OnUnHover();
                        Hovered = hitSelecteble;
                        Hovered.OnHover();
                    }
                }
                else
                {
                    Hovered = hitSelecteble;
                    Hovered.OnHover();
                }
            }
            else
            {
                if (Hovered)
                {
                    Hovered.OnUnHover();
                    Hovered = null;
                }
            }
        }
        else
        {
            UnHoverCurrent();
            UnSelectAll();
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (Hovered)
            {
                
                if (!Input.GetKey(KeyCode.LeftControl))
                {
                    UnSelectAll();
                }
                Select(Hovered);
            }
            //if(hit.GetHashCode)
        }
    }
    void UnHoverCurrent()
    {
        if (Hovered)
        {
                Hovered.OnUnHover();
                Hovered = null;
        }
    }
    void UnSelectAll()
    {
        for (int i = 0; i < ListOfSelected.Count; i++)
        {
            ListOfSelected[i].UnSelect();
        }
    }
    private void Select(SelectObject selectObject)
    {

    }
}
