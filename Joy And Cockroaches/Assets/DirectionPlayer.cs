using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionPlayer : MonoBehaviour
{

    private Transform M_transform;
    // Start is called before the first frame update
    void Start()
    {
        M_transform = this.transform;
    }

    // Update is called once per frame
    void LAMouse()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - M_transform.position;

        float angle = Mathf.Atan2(direction.y , direction.x) * Mathf.Rad2Deg;

        Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

        M_transform.rotation = rotation;
    }

    private void Update()
    {
           LAMouse();
    }
}
