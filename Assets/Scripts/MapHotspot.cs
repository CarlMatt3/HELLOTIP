using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class MapHotspot : MonoBehaviour
{
    public GameObject youAreHereImage;
    public Dictionary<GameObject, Vector2> sitePositions = new Dictionary<GameObject, Vector2>();
    private TourManager tourManager;
    private RectTransform rectTransform;

    void Start()
    {
        tourManager = FindObjectOfType<TourManager>();
        rectTransform = youAreHereImage.GetComponent<RectTransform>();
        
        // Populate the dictionary with site positions
        //batch1
        sitePositions.Add(tourManager.objSites[0], new Vector2(-3354f,357f));
        sitePositions.Add(tourManager.objSites[1], new Vector2(-3354f,357f));
        sitePositions.Add(tourManager.objSites[2], new Vector2(-3354f,357f));
        sitePositions.Add(tourManager.objSites[3], new Vector2(-3354f,357f));
        sitePositions.Add(tourManager.objSites[4], new Vector2(-3354f,357f));
        sitePositions.Add(tourManager.objSites[5], new Vector2(-2181f,165.9499f));
        sitePositions.Add(tourManager.objSites[6], new Vector2(-1229f, 347f));
        sitePositions.Add(tourManager.objSites[7], new Vector2(-1229f, 347f));
        sitePositions.Add(tourManager.objSites[8], new Vector2(-1229f, 347f));

        //batch2
        sitePositions.Add(tourManager.objSites[9], new Vector2(-1229f, 595.9501f));
        sitePositions.Add(tourManager.objSites[10], new Vector2(-875f, 595.95f));
        sitePositions.Add(tourManager.objSites[11], new Vector2(-875f, 595.95f));
        sitePositions.Add(tourManager.objSites[12], new Vector2(-834f, 1223.1f));
        sitePositions.Add(tourManager.objSites[13], new Vector2(-824f, 1972.1f));
        sitePositions.Add(tourManager.objSites[14], new Vector2(-824f, 1972.1f));
        sitePositions.Add(tourManager.objSites[15], new Vector2(541f, 2007.9f));
        sitePositions.Add(tourManager.objSites[16], new Vector2(541f, 2007.9f));
        sitePositions.Add(tourManager.objSites[17], new Vector2(541f, 2007.9f));
        sitePositions.Add(tourManager.objSites[18], new Vector2(541f, 2007.9f));
        sitePositions.Add(tourManager.objSites[19], new Vector2(627f, 1634f));
        sitePositions.Add(tourManager.objSites[20], new Vector2(645f, 963f));
        sitePositions.Add(tourManager.objSites[21], new Vector2(511.0002f, 501.95f));
        sitePositions.Add(tourManager.objSites[22], new Vector2(511.0002f, 501.95f));
        sitePositions.Add(tourManager.objSites[23], new Vector2(-236.0001f, 496.05f));

        //batch3
        sitePositions.Add(tourManager.objSites[24], new Vector2(119f, 736f));
        sitePositions.Add(tourManager.objSites[25], new Vector2(119f, 898f));
        sitePositions.Add(tourManager.objSites[26], new Vector2(120f, 1146.1f));
        sitePositions.Add(tourManager.objSites[27], new Vector2(289f, 1309.9f));
        sitePositions.Add(tourManager.objSites[28], new Vector2(289f, 1443f));
        sitePositions.Add(tourManager.objSites[29], new Vector2(278f, 1146.1f));
        sitePositions.Add(tourManager.objSites[30], new Vector2(119f, 1445.9f));
        sitePositions.Add(tourManager.objSites[31], new Vector2(123f, 1739f));
        sitePositions.Add(tourManager.objSites[32], new Vector2(257f, 1632f));
        sitePositions.Add(tourManager.objSites[33], new Vector2(230f, 926f));
        sitePositions.Add(tourManager.objSites[34], new Vector2(0f, 902f));
        sitePositions.Add(tourManager.objSites[35], new Vector2(0f, 714f));
        sitePositions.Add(tourManager.objSites[36], new Vector2(0f, 1324.9f));
        sitePositions.Add(tourManager.objSites[37], new Vector2(0f, 1740f));
        sitePositions.Add(tourManager.objSites[38], new Vector2(-258f, 1766f));
        sitePositions.Add(tourManager.objSites[39], new Vector2(-535f, 1729f));
        sitePositions.Add(tourManager.objSites[40], new Vector2(-537f, 1253.1f));
        sitePositions.Add(tourManager.objSites[41], new Vector2(-535f, 725f));

        //batch4
        sitePositions.Add(tourManager.objSites[42], new Vector2(-896f, 2170f));
        sitePositions.Add(tourManager.objSites[43], new Vector2(-896f, 2331f));
        sitePositions.Add(tourManager.objSites[44], new Vector2(-896f, 2170f));
        sitePositions.Add(tourManager.objSites[45], new Vector2(-896f, 2170f));
        sitePositions.Add(tourManager.objSites[46], new Vector2(-1376f, 2301f));
        sitePositions.Add(tourManager.objSites[47], new Vector2(-1191f, 2314f));
        sitePositions.Add(tourManager.objSites[48], new Vector2(-706f, 2270.9f));
        sitePositions.Add(tourManager.objSites[49], new Vector2(-329f, 2238f));
        sitePositions.Add(tourManager.objSites[50], new Vector2(-329f, 2238f));
        sitePositions.Add(tourManager.objSites[51], new Vector2(-172f, 2235.1f));

        //batch5
        sitePositions.Add(tourManager.objSites[52], new Vector2(98f, 2315f));
        sitePositions.Add(tourManager.objSites[53], new Vector2(98f, 2315f));
        sitePositions.Add(tourManager.objSites[54], new Vector2(375f, 2205.1f));
        sitePositions.Add(tourManager.objSites[55], new Vector2(693f, 2205.1f));
        sitePositions.Add(tourManager.objSites[56], new Vector2(937f, 2205.1f));

        //batch6
        sitePositions.Add(tourManager.objSites[57], new Vector2(1246f, 2205.1f));
        sitePositions.Add(tourManager.objSites[58], new Vector2(1247f, 2301f));
        sitePositions.Add(tourManager.objSites[59], new Vector2(1243f, 1829f));
        sitePositions.Add(tourManager.objSites[60], new Vector2(1157f, 1379f));
        sitePositions.Add(tourManager.objSites[61], new Vector2(1157f, 1569f));
        sitePositions.Add(tourManager.objSites[62], new Vector2(1157f, 1683f));
        sitePositions.Add(tourManager.objSites[63], new Vector2(1157f, 1211.9f));
        sitePositions.Add(tourManager.objSites[64], new Vector2(1157f, 1211.9f));
        sitePositions.Add(tourManager.objSites[65], new Vector2(892f, 1146.1f));
        sitePositions.Add(tourManager.objSites[66], new Vector2(1818f, 1146.1f));
        sitePositions.Add(tourManager.objSites[67], new Vector2(2548f, 1146.1f));
        sitePositions.Add(tourManager.objSites[68], new Vector2(1461f, 833f));

        //batch7
        sitePositions.Add(tourManager.objSites[69], new Vector2(1128f, 949f));
        sitePositions.Add(tourManager.objSites[70], new Vector2(1012f, 816f));
        sitePositions.Add(tourManager.objSites[71], new Vector2(956f, 283f));
        sitePositions.Add(tourManager.objSites[72], new Vector2(1220f, 273f));
        sitePositions.Add(tourManager.objSites[73], new Vector2(1269f, 771f));
        sitePositions.Add(tourManager.objSites[74], new Vector2(768f, 185.05f));
        sitePositions.Add(tourManager.objSites[75], new Vector2(519.0002f, 185.05f));

        //batch8
        sitePositions.Add(tourManager.objSites[76], new Vector2(463f, 120.05f));
        sitePositions.Add(tourManager.objSites[77], new Vector2(168f, 185.05f));
        sitePositions.Add(tourManager.objSites[78], new Vector2(-233f, 185.05f));
        sitePositions.Add(tourManager.objSites[79], new Vector2(-623f, 185.05f));
        sitePositions.Add(tourManager.objSites[80], new Vector2(-672f, -17.95f));
        sitePositions.Add(tourManager.objSites[81], new Vector2(-490f, -139f));
        sitePositions.Add(tourManager.objSites[82], new Vector2(-281f, -141f));
        sitePositions.Add(tourManager.objSites[83], new Vector2(-32f, -131f));
        sitePositions.Add(tourManager.objSites[84], new Vector2(193f, -270.95f));

        //batch9
        sitePositions.Add(tourManager.objSites[85], new Vector2(-760f, -344.95f));
        sitePositions.Add(tourManager.objSites[86], new Vector2(-821f, -711f));
        sitePositions.Add(tourManager.objSites[87], new Vector2(-1008f, -897f));
        sitePositions.Add(tourManager.objSites[88], new Vector2(-989f, -1127f));
        sitePositions.Add(tourManager.objSites[89], new Vector2(-989f, -1404f));
        sitePositions.Add(tourManager.objSites[90], new Vector2(-1181f, -1502f));
        sitePositions.Add(tourManager.objSites[91], new Vector2(-845f, -1507f));

        //batch10
        sitePositions.Add(tourManager.objSites[92], new Vector2(-447f, -1548f));
        sitePositions.Add(tourManager.objSites[93], new Vector2(-489f, -1430f));
        sitePositions.Add(tourManager.objSites[94], new Vector2(-488f, -1112f));
        sitePositions.Add(tourManager.objSites[95], new Vector2(-464.7f, -752f));
        sitePositions.Add(tourManager.objSites[96], new Vector2(32f, -739f));
        sitePositions.Add(tourManager.objSites[97], new Vector2(575f, -756f));
        sitePositions.Add(tourManager.objSites[98], new Vector2(575f, -1091.9f));
        sitePositions.Add(tourManager.objSites[99], new Vector2(110f, -1113f));
        sitePositions.Add(tourManager.objSites[100], new Vector2(103f, -1461f));
        sitePositions.Add(tourManager.objSites[101], new Vector2(-281f, -1491f));

        //batch11
        sitePositions.Add(tourManager.objSites[102], new Vector2(-2771f, 466.05f));
        sitePositions.Add(tourManager.objSites[103], new Vector2(-2533f, 466.05f));
        sitePositions.Add(tourManager.objSites[104], new Vector2(-2533f, 466.05f));
        sitePositions.Add(tourManager.objSites[105], new Vector2(-1899f, 466.05f));
        sitePositions.Add(tourManager.objSites[106], new Vector2(-1899f, 466.05f));
        sitePositions.Add(tourManager.objSites[107], new Vector2(-1899f, 466.05f));
        sitePositions.Add(tourManager.objSites[108], new Vector2(-1899f, 466.05f));
        sitePositions.Add(tourManager.objSites[109], new Vector2(-1899f, 466.05f));
        sitePositions.Add(tourManager.objSites[110], new Vector2(-1554f, 466.05f));

        //batch12
        sitePositions.Add(tourManager.objSites[111], new Vector2(1452f, 370f));
        sitePositions.Add(tourManager.objSites[112], new Vector2(1469f, -344.95f));
        sitePositions.Add(tourManager.objSites[113], new Vector2(1511f, -1211f));
        sitePositions.Add(tourManager.objSites[114], new Vector2(1478f, -1682.9f));
        sitePositions.Add(tourManager.objSites[115], new Vector2(1269f, -1263f));
        sitePositions.Add(tourManager.objSites[116], new Vector2(882f, -1315f));
        sitePositions.Add(tourManager.objSites[117], new Vector2(1269f, -1160f));
        sitePositions.Add(tourManager.objSites[118], new Vector2(1145f, -552f));
        sitePositions.Add(tourManager.objSites[119], new Vector2(1109f, -626f));
        sitePositions.Add(tourManager.objSites[120], new Vector2(1109f, -626f));
        sitePositions.Add(tourManager.objSites[121], new Vector2(1108f, -943f));

        //batch13
        sitePositions.Add(tourManager.objSites[122], new Vector2(1485f, 1354.9f));
        sitePositions.Add(tourManager.objSites[123], new Vector2(1485f, 1354.9f));
        sitePositions.Add(tourManager.objSites[124], new Vector2(1485f, 1354.9f));
        sitePositions.Add(tourManager.objSites[125], new Vector2(1818f, 1354.9f));
        sitePositions.Add(tourManager.objSites[126], new Vector2(1818f, 1443f));
        sitePositions.Add(tourManager.objSites[127], new Vector2(1818f, 1443f));
        sitePositions.Add(tourManager.objSites[128], new Vector2(1852f, 1629f));
        sitePositions.Add(tourManager.objSites[129], new Vector2(2120f, 1630f));
        sitePositions.Add(tourManager.objSites[130], new Vector2(2518f, 1611f));
        sitePositions.Add(tourManager.objSites[131], new Vector2(2518f, 1611f));
        sitePositions.Add(tourManager.objSites[132], new Vector2(2934f, 1631f));
        sitePositions.Add(tourManager.objSites[133], new Vector2(2934f, 1631f));
        sitePositions.Add(tourManager.objSites[134], new Vector2(2031.4f, 1289.1f));
        sitePositions.Add(tourManager.objSites[135], new Vector2(2644f, 1309.9f));

        //batch14
        sitePositions.Add(tourManager.objSites[136], new Vector2(3009f, 1319.1f));
        sitePositions.Add(tourManager.objSites[137], new Vector2(3009f, 1319.1f));
        sitePositions.Add(tourManager.objSites[138], new Vector2(3408f, 1324.9f));
        sitePositions.Add(tourManager.objSites[139], new Vector2(3748f, 1355f));

        //batch15
        sitePositions.Add(tourManager.objSites[140], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[141], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[142], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[143], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[144], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[145], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[146], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[147], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[148], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[149], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[150], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[151], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[152], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[153], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[154], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[155], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[156], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[157], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[158], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[159], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[160], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[161], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[162], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[163], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[164], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[165], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[166], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[167], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[168], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[169], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[170], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[171], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[172], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[173], new Vector2(519f, 2316f));
        sitePositions.Add(tourManager.objSites[174], new Vector2(519f, 2316f));

        //batch16
        //Building 5
        //Dulo techno
        sitePositions.Add(tourManager.objSites[175], new Vector2(0.00024414f, 2315f));
        sitePositions.Add(tourManager.objSites[176], new Vector2(0.00024414f, 2315f));
        sitePositions.Add(tourManager.objSites[177], new Vector2(0.00024414f, 2315f));
        //Bandang gitna pa techno
        sitePositions.Add(tourManager.objSites[178], new Vector2(-396f, 2346f));
        sitePositions.Add(tourManager.objSites[179], new Vector2(-396f, 2346f));
        //Gitna
        sitePositions.Add(tourManager.objSites[181], new Vector2(-1031f, 2315f));
        sitePositions.Add(tourManager.objSites[182], new Vector2(-1031f, 2315f));
        sitePositions.Add(tourManager.objSites[183], new Vector2(-1031f, 2315f));
        //dulo
        sitePositions.Add(tourManager.objSites[184], new Vector2(-1798f, 2270.9f));
        sitePositions.Add(tourManager.objSites[185], new Vector2(-1798f, 2270.9f));
        sitePositions.Add(tourManager.objSites[186], new Vector2(-1798f, 2270.9f));
        sitePositions.Add(tourManager.objSites[188], new Vector2(-1798f, 2270.9f));

        sitePositions.Add(tourManager.objSites[189], new Vector2(-1031f, 2315f));
        sitePositions.Add(tourManager.objSites[191], new Vector2(-1031f, 2315f));
        sitePositions.Add(tourManager.objSites[192], new Vector2(-1031f, 2315f));
        sitePositions.Add(tourManager.objSites[193], new Vector2(-1031f, 2315f));
        sitePositions.Add(tourManager.objSites[194], new Vector2(-396f, 2346f));

        sitePositions.Add(tourManager.objSites[195], new Vector2(0.00024414f, 2315f));

        //tempo fix
        sitePositions.Add(tourManager.objSites[196], new Vector2(0.00024414f, 2315f));
        sitePositions.Add(tourManager.objSites[197], new Vector2(0.00024414f, 2315f));
        sitePositions.Add(tourManager.objSites[198], new Vector2(0.00024414f, 2315f));
        sitePositions.Add(tourManager.objSites[199], new Vector2(0.00024414f, 2315f));
        sitePositions.Add(tourManager.objSites[200], new Vector2(0.00024414f, 2315f));
        // sitePositions.Add(tourManager.objSites[194], new Vector2(225f, 2372f));


        //tempo fix
        sitePositions.Add(tourManager.objSites[201], new Vector2(-396f, 2346f));
        sitePositions.Add(tourManager.objSites[202], new Vector2(-396f, 2346f));
        sitePositions.Add(tourManager.objSites[203], new Vector2(-396f, 2346f));
        sitePositions.Add(tourManager.objSites[204], new Vector2(-396f, 2346f));
        sitePositions.Add(tourManager.objSites[205], new Vector2(-396f, 2346f));
        sitePositions.Add(tourManager.objSites[206], new Vector2(-396f, 2346f));
        sitePositions.Add(tourManager.objSites[207], new Vector2(-396f, 2346f));
        sitePositions.Add(tourManager.objSites[208], new Vector2(-396f, 2346f));
        sitePositions.Add(tourManager.objSites[209], new Vector2(-396f, 2346f));
        sitePositions.Add(tourManager.objSites[210], new Vector2(-396f, 2346f));
        sitePositions.Add(tourManager.objSites[211], new Vector2(-396f, 2346f));
        sitePositions.Add(tourManager.objSites[212], new Vector2(-396f, 2346f));
        sitePositions.Add(tourManager.objSites[213], new Vector2(-396f, 2346f));
        sitePositions.Add(tourManager.objSites[214], new Vector2(-396f, 2346f));

        //Batch 17 BLDG6 done
        sitePositions.Add(tourManager.objSites[215], new Vector2(-1506f, 348f));
        sitePositions.Add(tourManager.objSites[216], new Vector2(-1707f, 348f));
        sitePositions.Add(tourManager.objSites[217], new Vector2(-2133f, 381f));
        sitePositions.Add(tourManager.objSites[218], new Vector2(-2556f, 359f));
        sitePositions.Add(tourManager.objSites[219], new Vector2(-2714f, 357f));

        sitePositions.Add(tourManager.objSites[220], new Vector2(-2714f, 357f));
        sitePositions.Add(tourManager.objSites[221], new Vector2(-2556f, 359f));
        sitePositions.Add(tourManager.objSites[222], new Vector2(-1707f, 348f));
        sitePositions.Add(tourManager.objSites[223], new Vector2(-1506f, 348f));
        sitePositions.Add(tourManager.objSites[224], new Vector2(-1229f, 1181.9f));
        
        sitePositions.Add(tourManager.objSites[225], new Vector2(-1506f, 348f));
        sitePositions.Add(tourManager.objSites[226], new Vector2(-1707f, 348f));
        sitePositions.Add(tourManager.objSites[227], new Vector2(-2133f, 381f));
        sitePositions.Add(tourManager.objSites[228], new Vector2(-2714f, 357f));
        sitePositions.Add(tourManager.objSites[229], new Vector2(-2714f, 357f));

        sitePositions.Add(tourManager.objSites[230], new Vector2(-2133f, 381f));
        sitePositions.Add(tourManager.objSites[231], new Vector2(-1707f, 348f));
        sitePositions.Add(tourManager.objSites[232], new Vector2(-1506f, 348f));
        sitePositions.Add(tourManager.objSites[233], new Vector2(-1506f, 348f));
        sitePositions.Add(tourManager.objSites[234], new Vector2(-1707f, 348f));

        sitePositions.Add(tourManager.objSites[235], new Vector2(-2133f, 381f));
        sitePositions.Add(tourManager.objSites[236], new Vector2(-2556f, 359f));
        sitePositions.Add(tourManager.objSites[237], new Vector2(-2714f, 357f));
        sitePositions.Add(tourManager.objSites[238], new Vector2(-2714f, 357f));
        sitePositions.Add(tourManager.objSites[239], new Vector2(-2556f, 359f));
        sitePositions.Add(tourManager.objSites[240], new Vector2(-1707f, 348f));

         //Batch 18 done
        sitePositions.Add(tourManager.objSites[241], new Vector2(-1239f, 767f));
        sitePositions.Add(tourManager.objSites[242], new Vector2(-1229f, 1181.9f));
        sitePositions.Add(tourManager.objSites[243], new Vector2(-1229f, 1630f));
        sitePositions.Add(tourManager.objSites[244], new Vector2(-1229f, 1630f));
        sitePositions.Add(tourManager.objSites[245], new Vector2(-1229f, 1181.9f));
        sitePositions.Add(tourManager.objSites[246], new Vector2(-1239f, 767f));
        sitePositions.Add(tourManager.objSites[247], new Vector2(-1239f, 767f));
        sitePositions.Add(tourManager.objSites[248], new Vector2(-1229f, 1181.9f));
        sitePositions.Add(tourManager.objSites[249], new Vector2(-1229f, 1630f));
        sitePositions.Add(tourManager.objSites[250], new Vector2(-1229f, 1630f));
        sitePositions.Add(tourManager.objSites[251], new Vector2(-1229f, 1181.9f));
        sitePositions.Add(tourManager.objSites[252], new Vector2(-1239f, 767f));
        sitePositions.Add(tourManager.objSites[253], new Vector2(-1239f, 767f));
        sitePositions.Add(tourManager.objSites[254], new Vector2(-1229f, 1181.9f));
        sitePositions.Add(tourManager.objSites[255], new Vector2(-1229f, 1630f));

        //Batch19 done
        sitePositions.Add(tourManager.objSites[256], new Vector2(1220f, -1252f));
        sitePositions.Add(tourManager.objSites[257], new Vector2(1220f, -1252f));
        sitePositions.Add(tourManager.objSites[258], new Vector2(1220f, -1252f));
        sitePositions.Add(tourManager.objSites[259], new Vector2(1220f, -1252f));
        sitePositions.Add(tourManager.objSites[260], new Vector2(1220f, -1252f));

        //Batch20 (only 261-265 done)
        sitePositions.Add(tourManager.objSites[261], new Vector2(1706f, 1319.1f));
        sitePositions.Add(tourManager.objSites[262], new Vector2(1706f, 1445.9f));
        sitePositions.Add(tourManager.objSites[263], new Vector2(1706f, 1445.9f));
        sitePositions.Add(tourManager.objSites[264], new Vector2(1706f, 1445.9f));
        sitePositions.Add(tourManager.objSites[265], new Vector2(1706f, 696f));
        //Not yet done 266-285
        sitePositions.Add(tourManager.objSites[266], new Vector2(2079.4f, 1279.9f));
        sitePositions.Add(tourManager.objSites[267], new Vector2(2644f, 1319.1f));
        sitePositions.Add(tourManager.objSites[268], new Vector2(3097f, 1309.9f));
        sitePositions.Add(tourManager.objSites[269], new Vector2(3732f, 1309.9f));
        sitePositions.Add(tourManager.objSites[270], new Vector2(3732f, 1309.9f));
        sitePositions.Add(tourManager.objSites[271], new Vector2(3528f, 1309.9f));
        sitePositions.Add(tourManager.objSites[272], new Vector2(3141f, 1289.1f));
        sitePositions.Add(tourManager.objSites[273], new Vector2(2644f, 1309.9f));
        sitePositions.Add(tourManager.objSites[274], new Vector2(2295f, 1309.9f));
        sitePositions.Add(tourManager.objSites[275], new Vector2(1706f, 1289.1f));
        sitePositions.Add(tourManager.objSites[276], new Vector2(1706f, 1289.1f));
        sitePositions.Add(tourManager.objSites[277], new Vector2(1706f, 1621f));
        sitePositions.Add(tourManager.objSites[278], new Vector2(2250f, 1640f));
        sitePositions.Add(tourManager.objSites[279], new Vector2(2250f, 1640f));
        sitePositions.Add(tourManager.objSites[280], new Vector2(3788f, 1310f));
        sitePositions.Add(tourManager.objSites[281], new Vector2(3476f, 1309.9f));
        sitePositions.Add(tourManager.objSites[282], new Vector2(2948f, 1309.9f));
        sitePositions.Add(tourManager.objSites[283], new Vector2(2948f, 1309.9f));
        sitePositions.Add(tourManager.objSites[284], new Vector2(3476f, 1309.9f));
        sitePositions.Add(tourManager.objSites[285], new Vector2(3788f, 1310f));

        //Batch21
        sitePositions.Add(tourManager.objSites[286], new Vector2(1851f, 667f));
        sitePositions.Add(tourManager.objSites[287], new Vector2(1706f, 696f));
        sitePositions.Add(tourManager.objSites[288], new Vector2(2187f, 679f));
        sitePositions.Add(tourManager.objSites[289], new Vector2(2304f, 688f));
        sitePositions.Add(tourManager.objSites[290], new Vector2(1851f, 667f));
        sitePositions.Add(tourManager.objSites[291], new Vector2(1706f, 1840f));
        sitePositions.Add(tourManager.objSites[292], new Vector2(-1584f, 393f));




        //sitePositions.Add(tourManager.objSites[n], new Vector2(xposf, yposf));


        // add more sites and positions as necessary
    }

    void Update()
    {
        // Find the active site
        GameObject activeSite = null;
        foreach (GameObject site in tourManager.objSites)
        {
            if (site.activeSelf)
            {
                activeSite = site;
                break;
            }
        }

        // Set the position of the "You are here" image based on the active site
        if (activeSite != null)
        {
            Vector2 position;
            if (sitePositions.TryGetValue(activeSite, out position))
            {
                rectTransform.anchoredPosition = new Vector2(position.x, position.y);
                Debug.Log("Active site: " + activeSite);
            }
        }
    }
}
