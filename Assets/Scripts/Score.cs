using UnityEngine;

[CreateAssetMenu(menuName = "ScoreRuntimeData")]

public class Score : ScriptableObject
{
    public string correct;
    public string incorrect;

    private void OnEnable()
    {
        correct = "";
        incorrect = "";
    }
}
