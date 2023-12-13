using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pool : MonoBehaviour
{
    public TextMeshProUGUI text;

    public int ballRequired;

    public Enum type;

    private void Start()
    {
        text.SetText("{0}", ballRequired);
    }

    public void GetBall(int number)
    {
        ballRequired -= number;
        text.SetText("{0}", ballRequired);
        if (ballRequired == 0)
        {
            GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].gameObjects.Remove(gameObject);
            GameManager.Instance.CheckLevelUp();
        }
    }
}
