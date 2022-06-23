using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ManagerScore : MonoBehaviour
{
    public TMP_Text displayCorrectScore;
    public TMP_Text displayIncorrectScore;

    private ManagerScore ms;

    public void Start()
    {
        ms = Resources.Load<ManagerScore>("ScoreRuntimeData");
    }
}
