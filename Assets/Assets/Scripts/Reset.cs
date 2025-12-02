using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject over;
    public void trigger()
    {
        over.SetActive(true);
        this.transform.GetChild(0).gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
    }

}
