using UnityEngine;
using UnityEngine.SceneManagement;
public class ScenCtrl : MonoBehaviour
{
    public void Scen_Reset()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
    public void Scen_Change(string name)
    {
        SceneManager.LoadScene(name);
    }
}
