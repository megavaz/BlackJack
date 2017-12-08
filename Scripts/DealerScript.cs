using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DealerScript : MonoBehaviour {

    public GameObject Ace1, Ace2, Ace3, Ace4, Ace5, Ace6, Ace7, Ace8, Ace9, Ace10, Ace11, Ace12, Ace13, Ace14, Ace15, Ace16, Ace17, Ace18, Ace19, Ace20;
    public GameObject King1, King2, King3, King4, King5, King6, King7, King8, King9, King10, King11, King12, King13, King14, King15, King16, King17, King18, King19, King20;
    public GameObject Queen1, Queen2, Queen3, Queen4, Queen5, Queen6, Queen7, Queen8, Queen9, Queen10, Queen11, Queen12, Queen13, Queen14, Queen15, Queen16, Queen17, Queen18, Queen19, Queen20;
    public GameObject Jack1, Jack2, Jack3, Jack4, Jack5, Jack6, Jack7, Jack8, Jack9, Jack10, Jack11, Jack12, Jack13, Jack14, Jack15, Jack16, Jack17, Jack18, Jack19, Jack20;
    public GameObject Ten1, Ten2, Ten3, Ten4, Ten5, Ten6, Ten7, Ten8, Ten9, Ten10, Ten11, Ten12, Ten13, Ten14, Ten15, Ten16, Ten17, Ten18, Ten19, Ten20;
    public GameObject Nine1, Nine2, Nine3, Nine4, Nine5, Nine6, Nine7, Nine8, Nine9, Nine10, Nine11, Nine12, Nine13, Nine14, Nine15, Nine16, Nine17, Nine18, Nine19, Nine20;
    public GameObject Eight1, Eight2, Eight3, Eight4, Eight5, Eight6, Eight7, Eight8, Eight9, Eight10, Eight11, Eight12, Eight13, Eight14, Eight15, Eight16, Eight17, Eight18, Eight19, Eight20;
    public GameObject Seven1, Seven2, Seven3, Seven4, Seven5, Seven6, Seven7, Seven8, Seven9, Seven10, Seven11, Seven12, Seven13, Seven14, Seven15, Seven16, Seven17, Seven18, Seven19, Seven20;
    public GameObject Six1, Six2, Six3, Six4, Six5, Six6, Six7, Six8, Six9, Six10, Six11, Six12, Six13, Six14, Six15, Six16, Six17, Six18, Six19, Six20;
    public GameObject Five1, Five2, Five3, Five4, Five5, Five6, Five7, Five8, Five9, Five10, Five11, Five12, Five13, Five14, Five15, Five16, Five17, Five18, Five19, Five20;
    public GameObject Four1, Four2, Four3, Four4, Four5, Four6, Four7, Four8, Four9, Four10, Four11, Four12, Four13, Four14, Four15, Four16, Four17, Four18, Four19, Four20;
    public GameObject Three1, Three2, Three3, Three4, Three5, Three6, Three7, Three8, Three9, Three10, Three11, Three12, Three13, Three14, Three15, Three16, Three17, Three18, Three19, Three20;
    public GameObject Two1, Two2, Two3, Two4, Two5, Two6, Two7, Two8, Two9, Two10, Two11, Two12, Two13, Two14, Two15, Two16, Two17, Two18, Two19, Two20;
    public Text DealerScoretxt, PlayerScoretxt, Finaltxt;
    public static int /*buf,*/ DealerScore, PlayerScore;    
    public static int NumberOfDecks = 5;
    private GameObject[] Deck = new GameObject[261];
    Vector2 PlayerPosition1 = new Vector2(-65, -35), PlayerPosition2 = new Vector2(-48, -35), PlayerPosition3 = new Vector2(-31, -35), PlayerPosition4 = new Vector2(-14, -35), PlayerPosition5 = new Vector2(3, -35), PlayerPosition6 = new Vector2(20, -35), PlayerPosition7 = new Vector2(37, -35), PlayerPosition8 = new Vector2(54, -35), PlayerPosition9 = new Vector2(71, -35);
    private Vector2[] CurrentPosition = new Vector2[9];
    private Vector2[] DealerPosition = new Vector2[9];
    int[] CardOrder = new int[261];
    public GameObject HITbutton, STAYbutton, NEWHANDbutton;



    unsafe public int* Shuffle (int* CardOrder, int n)
    {
        int k = 0;
        int* CO = CardOrder;
        {
            for (int i = 1; i < (52 * n + 1); i++)
            {
                k = CO[i];
                int d = (int)(Random.value * n * 52 + 0.999999);
                CO[i] = CO[d];
                CO[d] = k;
            }
            return CO;
        }
    }
    unsafe void Start () {

        PlayerScore = DealerScore = 0;

        for (int i = 0; i < 261; i++)
        {
            Deck[i] = new GameObject();
        }

        Deck[1]= Ace1; Deck[2]=Ace2; Deck[3] = Ace3; Deck[4] = Ace4;
        Deck[5] = King1; Deck[6] = King2; Deck[7] = King3; Deck[8] = King4;
        Deck[9] = Queen1; Deck[10] = Queen2; Deck[11] = Queen3; Deck[12] = Queen4;
        Deck[13] = Jack1; Deck[14] = Jack2; Deck[15] = Jack3; Deck[16] = Jack4;
        Deck[17] = Ten1; Deck[18] = Ten2; Deck[19] = Ten3; Deck[20] = Ten4;
        Deck[21] = Nine1; Deck[22] = Nine2; Deck[23] = Nine3; Deck[24] = Nine4;
        Deck[25] = Eight1; Deck[26] = Eight2; Deck[27] = Eight3; Deck[28] = Eight4;
        Deck[29] = Seven1; Deck[30] = Seven2; Deck[31] = Seven3; Deck[32] = Seven4;
        Deck[33] = Six1; Deck[34] = Six2; Deck[35] = Six3; Deck[36] = Six4;
        Deck[37] = Five1; Deck[38] = Five2; Deck[39] = Five3; Deck[40] = Five4;
        Deck[41] = Four1; Deck[42] = Four2; Deck[43] = Four3; Deck[44] = Four4;
        Deck[45] = Three1; Deck[46] = Three2; Deck[47] = Three3; Deck[48] = Three4;
        Deck[49] = Two1; Deck[50] = Two2; Deck[51] = Two3; Deck[52] = Two4;
        Deck[53] = Ace5; Deck[54] = Ace6; Deck[55] = Ace7; Deck[56] = Ace8;
        Deck[57] = King5; Deck[58] = King6; Deck[59] = King7; Deck[60] = King8;
        Deck[61] = Queen5; Deck[62] = Queen6; Deck[63] = Queen7; Deck[64] = Queen8;
        Deck[65] = Jack5; Deck[66] = Jack6; Deck[67] = Jack7; Deck[68] = Jack8;
        Deck[69] = Ten5; Deck[70] = Ten6; Deck[71] = Ten7; Deck[72] = Ten8;
        Deck[73] = Nine5; Deck[74] = Nine6; Deck[75] = Nine7; Deck[76] = Nine8;
        Deck[77] = Eight5; Deck[78] = Eight6; Deck[79] = Eight7; Deck[80] = Eight8;
        Deck[81] = Seven5; Deck[82] = Seven6; Deck[83] = Seven7; Deck[84] = Seven8;
        Deck[85] = Six5; Deck[86] = Six6; Deck[87] = Six7; Deck[88] = Six8;
        Deck[89] = Five5; Deck[90] = Five6; Deck[91] = Five7; Deck[92] = Five8;
        Deck[93] = Four5; Deck[94] = Four6; Deck[95] = Four7; Deck[96] = Four8;
        Deck[97] = Three5; Deck[98] = Three6; Deck[99] = Three7; Deck[100] = Three8;
        Deck[101] = Two5; Deck[102] = Two6; Deck[103] = Two7; Deck[104] = Two8;
        Deck[105] = Ace9; Deck[106] = Ace10; Deck[107] = Ace11; Deck[108] = Ace12;
        Deck[109] = King9; Deck[110] = King10; Deck[111] = King11; Deck[112] = King12;
        Deck[113] = Queen9; Deck[114] = Queen10; Deck[115] = Queen11; Deck[116] = Queen12;
        Deck[117] = Jack9; Deck[118] = Jack10; Deck[119] = Jack11; Deck[120] = Jack12;
        Deck[121] = Ten9; Deck[122] = Ten10; Deck[123] = Ten11; Deck[124] = Ten12;
        Deck[125] = Nine9; Deck[126] = Nine10; Deck[127] = Nine11; Deck[128] = Nine12;
        Deck[129] = Eight9; Deck[130] = Eight10; Deck[131] = Eight11; Deck[132] = Eight12;
        Deck[133] = Seven9; Deck[134] = Seven10; Deck[135] = Seven11; Deck[136] = Seven12;
        Deck[137] = Six9; Deck[138] = Six10; Deck[139] = Six11; Deck[140] = Six12;
        Deck[141] = Five9; Deck[142] = Five10; Deck[143] = Five11; Deck[144] = Five12;
        Deck[145] = Four9; Deck[146] = Four10; Deck[147] = Four11; Deck[148] = Four12;
        Deck[149] = Three9; Deck[150] = Three10; Deck[151] = Three11; Deck[152] = Three12;
        Deck[153] = Two9; Deck[154] = Two10; Deck[155] = Two11; Deck[156] = Two12;
        Deck[157] = Ace13; Deck[158] = Ace14; Deck[159] = Ace15; Deck[160] = Ace16;
        Deck[161] = King13; Deck[162] = King14; Deck[163] = King15; Deck[164] = King16;
        Deck[165] = Queen13; Deck[166] = Queen14; Deck[167] = Queen15; Deck[168] = Queen16;
        Deck[169] = Jack13; Deck[170] = Jack14; Deck[171] = Jack15; Deck[172] = Jack16;
        Deck[173] = Ten13; Deck[174] = Ten14; Deck[175] = Ten15; Deck[176] = Ten16;
        Deck[177] = Nine13; Deck[178] = Nine14; Deck[179] = Nine15; Deck[180] = Nine16;
        Deck[181] = Eight13; Deck[182] = Eight14; Deck[183] = Eight15; Deck[184] = Eight16;
        Deck[185] = Seven13; Deck[186] = Seven14; Deck[187] = Seven15; Deck[188] = Seven16;
        Deck[189] = Six13; Deck[190] = Six14; Deck[191] = Six15; Deck[192] = Six16;
        Deck[193] = Five13; Deck[194] = Five14; Deck[195] = Five15; Deck[196] = Five16;
        Deck[197] = Four13; Deck[198] = Four14; Deck[199] = Four15; Deck[200] = Four16;
        Deck[201] = Three13; Deck[202] = Three14; Deck[203] = Three15; Deck[204] = Three16;
        Deck[205] = Two13; Deck[206] = Two14; Deck[207] = Two15; Deck[208] = Two16;
        Deck[209] = Ace17; Deck[210] = Ace18; Deck[211] = Ace19; Deck[212] = Ace20;
        Deck[213] = King17; Deck[214] = King18; Deck[215] = King19; Deck[216] = King20;
        Deck[217] = Queen17; Deck[218] = Queen18; Deck[219] = Queen19; Deck[220] = Queen20;
        Deck[221] = Jack17; Deck[222] = Jack18; Deck[223] = Jack19; Deck[224] = Jack20;
        Deck[225] = Ten17; Deck[226] = Ten18; Deck[227] = Ten19; Deck[228] = Ten20;
        Deck[229] = Nine17; Deck[230] = Nine18; Deck[231] = Nine19; Deck[232] = Nine20;
        Deck[233] = Eight17; Deck[234] = Eight18; Deck[235] = Eight19; Deck[236] = Eight20;
        Deck[237] = Seven17; Deck[238] = Seven18; Deck[239] = Seven19; Deck[240] = Seven20;
        Deck[241] = Six17; Deck[242] = Six18; Deck[243] = Six19; Deck[244] = Six20;
        Deck[245] = Five17; Deck[246] = Five18; Deck[247] = Five19; Deck[248] = Five20;
        Deck[249] = Four17; Deck[250] = Four18; Deck[251] = Four19; Deck[252] = Four20;
        Deck[253] = Three17; Deck[254] = Three18; Deck[255] = Three19; Deck[256] = Three20;
        Deck[257] = Two17; Deck[258] = Two18; Deck[259] = Two19; Deck[260] = Two20;


        CurrentPosition[0] = PlayerPosition1;
        CurrentPosition[1] = PlayerPosition2;
        CurrentPosition[2] = PlayerPosition3;
        CurrentPosition[3] = PlayerPosition4;
        CurrentPosition[4] = PlayerPosition5;
        CurrentPosition[5] = PlayerPosition6;
        CurrentPosition[6] = PlayerPosition7;
        CurrentPosition[7] = PlayerPosition8;
        CurrentPosition[8] = PlayerPosition9;

        DealerPosition[0] = new Vector2(-38, 25);
        DealerPosition[1] = new Vector2(-20, 25);
        DealerPosition[2] = new Vector2(-3, 25);
        DealerPosition[3] = new Vector2(14, 25);
        DealerPosition[4] = new Vector2(31, 25);
        DealerPosition[5] = new Vector2(48, 25);
        DealerPosition[6] = new Vector2(65, 25);
        DealerPosition[7] = new Vector2(82, 25);
        DealerPosition[8] = new Vector2(99, 25);

        for (int i = 0; i <= 260; i++)
        {
            CardOrder[i] = i;
        }

        for (int i = 1; i < 261; i++)
        {
            Deck[i].SetActive(false);
        }

        fixed (int* m = CardOrder)
        for (int i = 0; i<3; i++)
        Shuffle(m, NumberOfDecks);
        firstgame = 1;
        NewHand();
        firstgame = 0;
    }

    int CurPos = 0, CardOrd = 1, DealPos = 0;
    
    public void HITenabled ()
    {
        Debug.Log("clicked");
        Deck[CardOrder[CardOrd]].SetActive(true);
        Deck[CardOrder[CardOrd]].transform.localPosition = CurrentPosition[CurPos];
        CurPos++; CardOrd++;        
    }

    public void STAYenabled ()
    {
        whotogive = 2;        
        HITbutton.SetActive(false);
        STAYbutton.SetActive(false);
        onemorecheck = 9;
    }
    public static int whotogive = 0; //defines who will get the next card 0-nobody 1-player 2-computer

    public void Final ()
    {
        whotogive = 0;
        HITbutton.SetActive(false);
        STAYbutton.SetActive(false);
        NEWHANDbutton.SetActive(true);
        if (PlayerScore > 21)
        {
            Finaltxt.text = "You lost";
        }

        if (DealerScore > 21)
        {
            Finaltxt.text = "You win";
        }
         if (DealerScore < 22 && PlayerScore < 22)
        {
            if (DealerScore>PlayerScore)
            {
                Finaltxt.text = "You lost";
            }

            if (DealerScore < PlayerScore)
            {
                Finaltxt.text = "You win";
            }

            if (DealerScore == PlayerScore)
            {
                Finaltxt.text = "Draw";
            }
        }
    }
    //int Plbuf, Dealbuf;
    int firstgame;


    public void NewHand ()
    {
        NEWHANDbutton.SetActive(false);
        PlayerScore = DealerScore = 0;
        Finaltxt.text = "";        
        if (firstgame == 0)
        {
            
            DealPos--;
            CurPos--;
            CardOrd--;
            for (int i = CardOrd; i >= CardOrd - (DealPos + CurPos + 1); i--)
            {
                Deck[CardOrder[i]].SetActive(false);
            }
            CardOrd++;
        }
        DealPos = CurPos = 0;
        whotogive = 2;
        for (int i = 0; i < 2; i++)
        {
            Deck[CardOrder[CardOrd]].SetActive(true);
            Deck[CardOrder[CardOrd]].transform.localPosition = DealerPosition[DealPos];
            DealPos++; CardOrd++;            
        }
        whotogive = 1;
        for (int i = 0; i < 2; i++)
        {
            Deck[CardOrder[CardOrd]].SetActive(true);
            Deck[CardOrder[CardOrd]].transform.localPosition = CurrentPosition[CurPos];
            CurPos++; CardOrd++;            
        }        
        HITbutton.SetActive(true);
        STAYbutton.SetActive(true);        
        onemorecheck = 9;
    }

    int onemorecheck;

    void Update () {

        PlayerScoretxt.text = "Your Score: " + PlayerScore.ToString();
        DealerScoretxt.text = "Dealer Score: " + DealerScore.ToString();

        if (whotogive == 1)
        {
            HITbutton.SetActive(true);
            STAYbutton.SetActive(true);            

            if (PlayerScore > 21 && onemorecheck == 0)
            {
                Final();
            }

            if (PlayerScore > 21 && onemorecheck > 0)
            {
                onemorecheck--;
            }
        }
        
        if (whotogive == 2)        {
            
            if (DealerScore < 17)
            {
                Deck[CardOrder[CardOrd]].SetActive(true);
                Deck[CardOrder[CardOrd]].transform.localPosition = DealerPosition[DealPos];
                DealPos++; CardOrd++;
            }

            if (DealerScore > 21 && onemorecheck == 0)
                Final();
            if (DealerScore > 21 && onemorecheck > 0)
                onemorecheck--;
            if (DealerScore >= 17 && DealerScore < 22)
                Final();
         
        }
    }
}
