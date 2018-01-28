using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInfo : MonoBehaviour {

    public static void SaveAllInfo () {

        PlayerPrefs.SetInt("PLAYERLEVEL", GameMaster.PlayerLevel);
        PlayerPrefs.SetString("PLAYERNAME", GameMaster.PlayerName);
        PlayerPrefs.SetInt("STAMINA", GameMaster.Stamina);
        PlayerPrefs.SetInt("ENDURANCE", GameMaster.Endurance);
        PlayerPrefs.SetInt("INTELLECT", GameMaster.Intellect);
        PlayerPrefs.SetInt("STRENGTH", GameMaster.Strength);


    }

}
