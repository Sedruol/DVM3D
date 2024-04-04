using UnityEngine;

public class EnumsExample : MonoBehaviour
{
    /*Tipos de Ataque
      Basico = 0
      Fuego = 1
      Hielo = 2
      Veneno = 3
     */
    [SerializeField] private int attackType = 0;
    //private enum AttackType
    //{
    //    Default,
    //    Fire,
    //    Ice,
    //    Poison
    //};
    //[SerializeField] private AttackType attackType;
    private void Start()
    {
        //attackType = AttackType.Poison;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack1();
            //Attack2();
        }
    }

    private void Attack1()
    {
        switch (attackType)
        {
            case 0:
                Debug.Log("ataque basico");
                break;
            case 1:
                Debug.Log("ataque de fuego");
                break;
            case 2:
                Debug.Log("ataque de hielo");
                break;
            case 3:
                Debug.Log("ataque venenoso");
                break;
        }
    }
    //private void Attack2()
    //{
    //    switch (attackType)
    //    {
    //        case AttackType.Default:
    //            Debug.Log("ataque basico");
    //            break;
    //        case AttackType.Fire:
    //            Debug.Log("ataque de fuego");
    //            break;
    //        case AttackType.Ice:
    //            Debug.Log("ataque de hielo");
    //            break;
    //        case AttackType.Poison:
    //            Debug.Log("ataque venenoso");
    //            break;
    //    }
    //}
}