using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public List<GameObject> EmptyObject;
    public List<GameObject> Player;
    public int Count = 0;
    public bool flag1 ;
    public GameObject HomePanel;
    public List<GameObject> AlreadyExist;
    public List<GameObject> MyAllBlock;
    public int NoOfLine;
    //public Animator PlayerAnimation;

    public void Awake()
    {
        Instance = this;
        flag1 = true;
    }
    public void NextScene()
    {
        SceneManager.LoadScene("AllLevelScene");
    }
    public void level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Checker()
    {

        if (EmptyObject[0].transform.childCount == 1)
        {
            if (EmptyObject[1].transform.childCount == 1)
            {
                if (EmptyObject[2].transform.childCount == 1)
                {
                    if (EmptyObject[0].transform.GetChild(0).tag == EmptyObject[1].transform.GetChild(0).tag)
                    {
                        if (EmptyObject[1].transform.GetChild(0).tag == EmptyObject[2].transform.GetChild(0).tag)
                        {
                            
                            foreach (Transform child in EmptyObject[0].transform)
                            {
                                StartCoroutine(PlayerScript.instance.GoToHappy(2.5f));
                                Destroy(child.gameObject);
                                //child.gameObject.SetActive(false);
                            }
                            foreach (Transform child in EmptyObject[1].transform)
                            {
                                StartCoroutine(PlayerScript.instance.GoToHappy(2.5f));
                                Destroy(child.gameObject);
                                //child.gameObject.SetActive(false);
                            }
                            foreach (Transform child in EmptyObject[2].transform)
                            {
                                StartCoroutine(PlayerScript.instance.GoToHappy(2.5f));

                                Destroy(child.gameObject);
                                //child.gameObject.SetActive(false);
                            }
                            if (flag1)
                            {
                                Count = 0;
                                
                                flag1 = false;
                            }
                            else
                            {
                                Count++;
                            }
                            flag1 = true;

                        }
                    }
                }
            }
        }
        else if (EmptyObject[1].transform.childCount == 1)
        {
            StartCoroutine(PlayerScript.instance.GoToHappy(2.5f));

            if (EmptyObject[2].transform.childCount == 1)
            {
                if (EmptyObject[3].transform.childCount == 1)
                {
                    if (EmptyObject[1].transform.GetChild(0).tag == EmptyObject[2].transform.GetChild(0).tag)
                    {
                        if (EmptyObject[2].transform.GetChild(0).tag == EmptyObject[3].transform.GetChild(0).tag)
                        {
                            foreach (Transform child in EmptyObject[1].transform)
                            {
                                Destroy(child.gameObject);
                                //child.gameObject.SetActive(false);
                            }
                            foreach (Transform child in EmptyObject[2].transform)
                            {
                                Destroy(child.gameObject);
                                //child.gameObject.SetActive(false);
                            }
                            foreach (Transform child in EmptyObject[3].transform)
                            {
                                Destroy(child.gameObject);
                                //child.gameObject.SetActive(false);
                            }
       
                                if (flag1)
                                {
                                    Count = 1;
                                    
                                    flag1 = false;
                                }
                                else
                                {

                                    Count++;
                                }
                            flag1 = true;

                        }
                    }
                }
            }
            
        }
        else if (EmptyObject[2].transform.childCount == 1)
        {
            StartCoroutine(PlayerScript.instance.GoToHappy(2.5f));

            if (EmptyObject[3].transform.childCount == 1)
            {
                if (EmptyObject[4].transform.childCount == 1)
                {
                    if (EmptyObject[2].transform.GetChild(0).tag == EmptyObject[3].transform.GetChild(0).tag)
                    {
                        if (EmptyObject[3].transform.GetChild(0).tag == EmptyObject[4].transform.GetChild(0).tag)
                        {
                            foreach (Transform child in EmptyObject[2].transform)
                            {
                                Destroy(child.gameObject);
                                //child.gameObject.SetActive(false);
                            }
                            foreach (Transform child in EmptyObject[3].transform)
                            {
                                Destroy(child.gameObject);
                                //child.gameObject.SetActive(false);
                            }
                            foreach (Transform child in EmptyObject[4].transform)
                            {
                                Destroy(child.gameObject);
                                //child.gameObject.SetActive(false);
                            }

                            if (flag1)
                            {
                                Count = 2;
                                
                                flag1 = false;
                            }
                            else
                            {

                                Count++;
                            }
                            flag1 = true;
                        }
                    }
                }
            }
        }
        else if (EmptyObject[3].transform.childCount == 1)
        {
            StartCoroutine(PlayerScript.instance.GoToHappy(2.5f));

            if (EmptyObject[4].transform.childCount == 1)
            {
                if (EmptyObject[5].transform.childCount == 1)
                {
                    if (EmptyObject[6].transform.GetChild(0).tag == EmptyObject[4].transform.GetChild(0).tag)
                    {
                        if (EmptyObject[4].transform.GetChild(0).tag == EmptyObject[5].transform.GetChild(0).tag)
                        {
                            foreach (Transform child in EmptyObject[3].transform)
                            {
                                Destroy(child.gameObject);
                                //child.gameObject.SetActive(false);
                            }
                            foreach (Transform child in EmptyObject[4].transform)
                            {
                                Destroy(child.gameObject);
                                //child.gameObject.SetActive(false);
                            }
                            foreach (Transform child in EmptyObject[5].transform)
                            {
                                Destroy(child.gameObject);
                                //child.gameObject.SetActive(false);
                            }

                            if (flag1)
                            {
                                Count = 3;
                                
                                flag1 = false;
                            }
                            else
                            {
                                Count++;
                            }
                            flag1 = true;
                        }
                    }
                }
            }
        }
        else if (EmptyObject[4].transform.childCount == 1)
        {
            StartCoroutine(PlayerScript.instance.GoToHappy(2.5f));

            if (EmptyObject[5].transform.childCount == 1)
            {
                if (EmptyObject[6].transform.childCount == 1)
                {
                    if (EmptyObject[4].transform.GetChild(0).tag == EmptyObject[5].transform.GetChild(0).tag)
                    {
                        if (EmptyObject[5].transform.GetChild(0).tag == EmptyObject[6].transform.GetChild(0).tag)
                        {
                            foreach (Transform child in EmptyObject[4].transform)
                            {
                                Destroy(child.gameObject);
                                //child.gameObject.SetActive(false);
                            }
                            foreach (Transform child in EmptyObject[5].transform)
                            {
                                Destroy(child.gameObject);
                                //child.gameObject.SetActive(false);
                            }
                            foreach (Transform child in EmptyObject[6].transform)
                            {
                                Destroy(child.gameObject);
                                //child.gameObject.SetActive(false);
                            }
;
                            if (flag1)
                            {
                                Count = 4;
                                
                                flag1 = false;
                            }
                            else
                            {
                                Count++;
                            }
                            flag1 = true;
                        }
                    }
                }
            }
        }
        else if (EmptyObject[5].transform.childCount == 1)
        {
            StartCoroutine(PlayerScript.instance.GoToHappy(2.5f));

            if (EmptyObject[6].transform.childCount == 1)
            {
                if (EmptyObject[7].transform.childCount == 1)
                {
                    if (EmptyObject[5].transform.GetChild(0).tag == EmptyObject[6].transform.GetChild(0).tag)
                    {
                        if (EmptyObject[6].transform.GetChild(0).tag == EmptyObject[7].transform.GetChild(0).tag)
                        {

                            foreach (Transform child in EmptyObject[5].transform)
                            {
                                Destroy(child.gameObject);
                                //child.gameObject.SetActive(false);
                            }
                            foreach (Transform child in EmptyObject[6].transform)
                            {
                                Destroy(child.gameObject);
                                //child.gameObject.SetActive(false);
                            }
                            foreach (Transform child in EmptyObject[7].transform)
                            {
                                Destroy(child.gameObject);

    
                                //child.gameObject.SetActive(false);
                            }


                            if (flag1)
                            {
                                Count = 5;
                                   
                                flag1 = false;
                            }
                            else

                            {
                                Count++;
                            }
                            flag1 = true;
                        }
                    }
                }
            }
        }
      
        if(AlreadyExist.Count == 0)
        {
            Debug.Log("WINNNNNN");
            HomePanel.SetActive(true);
        }

    }
    public void FinalWinChecking(GameObject ClickedObject)
    {
        if (AlreadyExist.Contains(ClickedObject))
        {
            AlreadyExist.Remove(ClickedObject);
        }
    }
}