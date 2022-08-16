using UnityEngine;


[CreateAssetMenu(menuName = "Incremental Data", fileName = "New Incremental Data")]
public class IncremantalData : ScriptableObject
{
    public Stamina[] staminaLevels;
    public Speed[] speedLevels;
    public Income[] incomeLevels;
}



[System.Serializable]
public class LevelData
{
    public int level;
    public int price;
}



[System.Serializable]
public class Stamina : LevelData
{
    public float stamina;
}




[System.Serializable]
public class Speed : LevelData
{
    public float speed;
}



[System.Serializable]
public class Income : LevelData
{
    public float amout;
}
