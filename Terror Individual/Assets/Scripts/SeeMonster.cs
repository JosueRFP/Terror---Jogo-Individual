using UnityEngine;

public class SeeMonster : MonoBehaviour, ISeeYou
{
    [SerializeField] Transform monsterPosition;
    public void HitMonster()
    {
        print("Bateu no Monstro");
        monsterPosition.position = Vector3.zero;
    }

    
}
