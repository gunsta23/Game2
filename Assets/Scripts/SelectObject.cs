using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObject : MonoBehaviour
{
    public GameObject SelectionIndicator;
    private void Start()
    {
        //SelectionIndicator
    }
    public virtual void OnHover()
     {
        transform.localScale = Vector3.one * 1.1f;
     }
public virtual void OnUnHover()
     {
       transform.localScale = Vector3.one;
     }
public virtual void OnSelect()
    {
        SelectionIndicator.SetActive(true);
    }
public virtual void UnSelect()
    {
        SelectionIndicator.SetActive(false);
    }
    public virtual void WhenClickOnGround(Vector3 point)
    {
        
    }
}
