using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraControll : MonoBehaviour
{
    public ServerStatus ServerStatusMenu;

    Transform oldHit;
    bool lastIsServer;

    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxis("Mouse X") / 1000, Input.GetAxis("Mouse Y") / 1000, 0));

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100f))
        {
            //Select stage    
            if (hit.transform.tag == "server")
            {
                hit.transform.GetComponent<Outline>().OutlineWidth = 2;

                if (oldHit != null)
                {
                    if (oldHit.name != hit.transform.name)
                    {
                        oldHit.GetComponent<Outline>().OutlineWidth = 0;
                    }
                }
                
                lastIsServer = true;
                oldHit = hit.transform;

                if (Input.GetMouseButtonDown(0))
                {
                    ServerStatusMenu.gameObject.SetActive(true);
                    ServerStatusMenu.server = hit.transform.gameObject.GetComponent<Server>();
                }
            }
            else
            {
                if (Input.GetMouseButtonDown(0))
                {
                    ServerStatusMenu.gameObject.SetActive(false);
                }

                if (lastIsServer)
                {
                    oldHit.transform.GetComponent<Outline>().OutlineWidth = 0;
                    lastIsServer = false;
                }
            }
        }
        else
        {
            ServerStatusMenu.gameObject.SetActive(false);
        }
    }
}
