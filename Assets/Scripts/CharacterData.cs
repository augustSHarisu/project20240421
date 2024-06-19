using UnityEngine;

[CreateAssetMenu(fileName = "New CharacterData", menuName = "Character Data")]// Entrance
public class CharacterData : ScriptableObject// Data
{
    public float health;
    public float attackDamage;
}