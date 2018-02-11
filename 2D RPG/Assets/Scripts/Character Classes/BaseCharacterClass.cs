using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass {
	private string characterclassname;
	private string characterclassdescription;
	//stats
	private int stamina;
	private int endurance;
	private int strength;
	private int intellect;

	public string ChacterClassName{
		get{return characterclassname;}
		set{characterclassname = value; }
	}

	public string CharacterClassDescription{
		get{return characterclassdescription;}
		set{characterclassdescription = value; }
	}

	public int Stamina{
		get{return stamina;}
		set{stamina = value; }
	}

	public int Endurance{
		get{return endurance;}
		set{endurance = value; }
	}

	public int Strength{
		get{return strength;}
		set{strength = value; }
	}

	public int Intellect{
		get{return intellect;}
		set{intellect = value; }
	}
}
