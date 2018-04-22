[System.Serializable]
// turns objects into string 
public class SavePosition  {

	public float x = 0;
	public float y = 0;
	public float z = 0;
	public float health = 100;
	public int numberOfEnemies = 0;
	public double healthBarFraction = 1.0;
	public bool isBattle = false;  

	public int turnNumber = 1;

	public string isWizardDead = "OK";

	public float enemyHealth = 0;
	public float enemyAttack = 0;
	public int enemyType = 0;
	// public int isDead = 0;
	// public bool isMain = false;
	

	public int spawn1 = 0;
	public int spawn2 = 0;
	public int spawn3 = 0;

	// can put as many as you want in this class

}
