using Unity.VisualScripting;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public GameObject cross;
    public GameObject hand;
    public GameObject lamp1,lamp2, Windshield_wiper,water;
    void Start()
    {
        cross.SetActive(true);
        hand.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            // 检测是否是带InteractableGeneral的"btn"物体
            if (hit.collider.CompareTag("btn"))
            {
                cross.SetActive(false);
                hand.SetActive(true);

                // 使用旧版Input类检测鼠标左键点击（在Both模式下可用）
                if (Input.GetMouseButtonDown(0))
                {
                    if (hit.collider.name== "Windshield wiper")
                    {
                        Windshield_wiper.GetComponent<Animator>().enabled = true;
                        water.SetActive(false);
                    }
                    else if (hit.collider.name=="lamp")
                    {
                        lamp1.SetActive(true);
                        lamp2.SetActive(true);
                        
                    }
                }
                return;
            }
        }

        // 未检测到目标时恢复默认准星
        cross.SetActive(true);
        hand.SetActive(false);
    }
}
