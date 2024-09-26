using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    public Color MainColour = Color.blue; //3D version
    public Color MouseColour = Color.red; //3D version


    public Renderer renderer; //3D version

    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void DoStuff()
    {
        renderer = GetComponent<Renderer>(); //3D version
        MainColour = renderer.material.color; //3D version
    }
    
    public virtual void AttackPlayer()
    {
        print("Enemy is attacking player");
    }

    public void OnMouseOver()
    {

        //transform.GetComponent<SpriteRenderer>().color = Color.red; //2D version
        renderer.material.color = MouseColour; //3D version
        AttackPlayer();
        
    }

    public void OnMouseExit()
    {
        //transform.GetComponent<SpriteRenderer>().color = Color.white; //2D version

        renderer.material.color = MainColour; //3D version
    }





    /*
            3D colour change with mouse:    http://coffeebreakcodes.com/change-color-hover-mouseover-unity3d-c/

    */
}
