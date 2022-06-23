using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public enum MyScenes
{
    Welcome,
    Main,
    End
}
// Hilfsstruktur

public class ManagerKid : MonoBehaviour
{
    public TMP_InputField ipfKidsName;

    public TMP_Text displayKidsName;
    public TMP_Text warning;

    private SoRuntimeData runtimeData;

    public GameObject alien1;
    public GameObject alien2;
    public GameObject alien3;

    private void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");

        /* if (SceneManager.GetActiveScene().buildIndex == MyScenes.Welcome)
        {
            displayKidsName.text = runtimeData.nameKid;
        } */

        if (SceneManager.GetActiveScene().buildIndex == (int)MyScenes.Main)
        {
            Debug.Log("In Scene Main" + runtimeData.nameKid);
            displayKidsName.text = runtimeData.nameKid;
        }
    }

    public void SwitchTheScene(int x)
    {
        Debug.Log("BTN pressed, get kidsname " + ipfKidsName.text);
        runtimeData.nameKid = ipfKidsName.text;

        SceneManager.LoadScene(x);



        if (alien1.activeSelf)
        {
            runtimeData.showPic = "alien1";
        }
        else if (alien3.activeSelf)
        {
            runtimeData.showPic = "alien3";
        }
        else if (alien2.activeSelf)
        {
            runtimeData.showPic = "alien2";
        }
        else
        {
            runtimeData.showPic = "";
        }
        if (runtimeData.showPic == "" && runtimeData.nameKid == "")
        {
            warning.text = "*WÄHLE EINEN AUSERIRDISCHEN AUS ODER VERRATE UNS, WIE DU HEISST.";
            warning.fontSize = 30;
            warning.color = Color.red;

        }
        else
        {
            SceneManager.LoadScene(x);
        }
    }
    // aus einem Skript wird eine Szene geladen


    public void SwitchTheScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    // ---


    public void SwitchToMain()
    {
        SceneManager.LoadScene((int)MyScenes.Main);
    }
        public void SwitchToEnd()
    {
        SceneManager.LoadScene((int)MyScenes.End);
    }
    // Jede Szene wird einzeln aufgerufen, muss dann auch für jede Scene eine Methode aufschreiben


    public void UseAlien1()
    {
        alien2.SetActive(false);
        alien3.SetActive(false);
        if (alien1.activeSelf)
        {
            alien1.SetActive(true);
        }
        else
        {
            alien1.SetActive(false);
        }
    }

    public void UseAlien2()
    {
        alien1.SetActive(false);
        alien3.SetActive(false);
        if (alien2.activeSelf)
        {
            alien2.SetActive(true);
        }
        else
        {
            alien2.SetActive(false);
        }
    }

    public void UseAlien3()
    {
        alien1.SetActive(false);
        alien2.SetActive(false);
        if (alien3.activeSelf)
        {
            alien3.SetActive(true);
        }
        else
        {
            alien3.SetActive(false);
        }
    }
}
