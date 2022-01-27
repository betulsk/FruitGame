using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaControl : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    Vector3 movementPos;
    public bool isMove;


    private void Start()
    {
        
        movementPos = transform.position;
        isMove = false;
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Position();
        }
        if (isMove)
        {            
            BananaMove();
        }
    }
    void Position()
    {
        Plane plane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float distance;
        if (plane.Raycast(ray, out distance))
        {
            movementPos = ray.GetPoint(distance);
        }
        isMove = true;
    }

    void BananaMove()
    {
        transform.LookAt(movementPos);
        transform.position = Vector3.MoveTowards(transform.position, movementPos, moveSpeed * Time.deltaTime);
        if (transform.position==movementPos)
        {
            isMove = false;
        }
        Debug.DrawLine(transform.position, movementPos, Color.red);
    }


}
