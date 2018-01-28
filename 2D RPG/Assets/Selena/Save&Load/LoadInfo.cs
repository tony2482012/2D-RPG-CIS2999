using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInfo : MonoBehaviour {

    public static void LoadAllInfo () {

        GameMaster.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        GameMaster.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
        GameMaster.Stamina = PlayerPrefs.GetInt("STAMINA");
        GameMaster.Endurance = PlayerPrefs.GetInt("ENDURANCE");
        GameMaster.Intellect = PlayerPrefs.GetInt("INTELLECT");
        GameMaster.Strength = PlayerPrefs.GetInt("STRENGTH");

    }

}
