using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomMessgae : MonoBehaviour
{
    public TextMeshPro motivationalText;

    public void BtnAction()
    {
        PickRandomFromList();
    }

    private void PickRandomFromList()
    {
        string[] message = new string[] {"Gut gemacht!", "Tolle Leistung!", "Groﬂartig!", "Du hast es geschafft!"};
        string randomName = message[Random.Range(0, message.Length)];
        //motivationalText.text = randomName;
        print(randomName);
    }
}
