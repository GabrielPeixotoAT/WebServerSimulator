using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraControll : MonoBehaviour
{
    public GameObject menu;

    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxis("Mouse X") / 1000, Input.GetAxis("Mouse Y") / 1000, 0));

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Select stage    
                if (hit.transform.tag == "server")
                {
                    menu.SetActive(true);
                }
                else
                {
                    menu.SetActive(false);
                }
            }
            else
            {
                menu.SetActive(false);
            }
        }
    }
}
