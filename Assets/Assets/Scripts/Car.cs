using TMPro;
using UnityEngine;

public class Car : MonoBehaviour
{
    public TextMeshPro speedText; // 显示速度的文本框
    public GameObject over;
    public TMP_Text overText;
    public GameObject tishi;
    private void Update()
    {
        // 检测文本框数值并输出 a
        CheckSpeedAndOutputA();
    }

    /// <summary>
    /// 检测速度文本框数值，大于20则输出 "a"
    /// </summary>
    private void CheckSpeedAndOutputA()
    {
        // 1. 判空：避免文本框未赋值导致空引用错误
        if (speedText == null)
        {
            Debug.LogWarning("Speed TextMeshPro 未赋值！");
            return;
        }

        // 2. 获取文本内容并去除空格（防止文本框有多余空格导致转换失败）
        string speedStr = speedText.text.Trim();

        // 3. 将文本转换为数值（因为是速度，用 float 更灵活，也可改用 int）
        if (float.TryParse(speedStr, out float currentSpeed))
        {
            // 4. 判断数值是否大于20，满足则输出 "a"
            if (currentSpeed > 50)
            {
                tishi.SetActive(true);
            }
            else if (currentSpeed <= 50)
            {
                tishi.SetActive(false);
            }
        }
    }
    public void gameOver()
    {
        Cursor.lockState = CursorLockMode.None;
        over.SetActive(true);
        this.transform.GetChild(0).gameObject.SetActive(false);
        overText.text = "Drive carefully to avoid collisions.";
    }
}