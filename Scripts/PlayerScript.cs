using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerScript : MonoBehaviour
{
   public static PlayerScript instance;
   public bool flag;
   public Animator PlayerAnimation;

    public void Awake()
    {
        instance = this;
    }

    public void OnMouseUp()
    {
        GameManager.Instance.FinalWinChecking(this.gameObject);
        this.gameObject.GetComponent<CapsuleCollider>().enabled = false;

        flag = true;
        if (flag == true)
        {
            PlayerAnimation.SetBool("walk", true);
            this.gameObject.transform.DOMove(new Vector3(GameManager.Instance.EmptyObject[GameManager.Instance.Count].transform.position.x, GameManager.Instance.EmptyObject[GameManager.Instance.Count].transform.position.y, GameManager.Instance.EmptyObject[GameManager.Instance.Count].transform.position.z),3);
            this.gameObject.transform.parent = GameManager.Instance.EmptyObject[GameManager.Instance.Count].transform;
            GameManager.Instance.Player.Add(this.gameObject);
            StartCoroutine(GoToHappy(2.5f));
            
        }
       
        GameManager.Instance.Count++;
        GameManager.Instance.Checker();
    }

    public IEnumerator GoToHappy(float Delay)
    {
        yield return new WaitForSeconds(Delay);
        PlayerAnimation.SetBool("walk", false);
        PlayerAnimation.SetBool("happy", true);
    }

   
}