
using UnityEngine;

namespace Su
{
    /// <summary>
    /// �즲
    /// </summary>
    public class system : MonoBehaviour
    {
        Vector3 offset; 
        
        bool isDragging;
        

        private void Update()
        {

            if (isDragging)
            {
                transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) - offset;
                
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