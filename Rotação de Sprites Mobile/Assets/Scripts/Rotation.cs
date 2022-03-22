using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public void girarSprite(){
        transform.Rotate(0, 0, 90); //Girando os sprites em 45º graus
    }
}
