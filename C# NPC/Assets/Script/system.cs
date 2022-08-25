using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Su
{
    /// <summary>
    /// ©ì¦²
    /// </summary>
    public class system : MonoBehaviour
    {
        Vector3 offset; 
        Vector3 offset2;
        bool isDragging;
        public BoxCollider A3;
        private void Update()
        {

            if (isDragging)
            {
                transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) - offset;
                print($"{A3.ClosestPoint(transform.position)}");
            }
            

        }
        private void OnMouseDown()
        {
            isDragging = true;
            offset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        }
        private void OnMouseUp()
        {
            isDragging = false;
        }
    }
}