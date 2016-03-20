namespace Deerchao.War3Share.W3gParser
{
    public static class ChineseItemString
    {
        public static string GetStringFromItemId(string itemId)
        {
            switch (itemId)
            {
                #region Heroes
                case "Hamg":
                    return "大法师";
                case "Hmkg":
                    return "山丘之王";
                case "Hpal":
                    return "圣骑士";
                case "Hblm":
                    return "血魔法师";

                case "Edem":
                    return "恶魔猎手";
                case "Ekee":
                    return "丛林守护者";
                case "Emoo":
                    return "月之女祭司";
                case "Ewar":
                    return "守望者";

                case "Obla":
                    return "剑圣";
                case "Ofar":
                    return "先知";
                case "Otch":
                    return "牛头人酋长";
                case "Oshd":
                    return "暗影猎手";

                case "Udea":
                    return "死亡骑士";
                case "Udre":
                    return "恐惧魔王";
                case "Ulic":
                    return "巫妖";
                case "Ucrl":
                    return "地穴领主";

                case "Npbm":
                    return "熊猫酿酒师";
                case "Nbrn":
                    return "黑暗游侠";
                case "Nngs":
                    return "那迦女海妖";
                case "Nplh":
                    return "深渊领主";
                case "Nbst":
                    return "兽王";
                case "Ntin":
                    return "地精修补匠";
                case "Nfir":
                    return "火焰领主";
                case "Nalc":
                    return "地精炼金术士";
                #endregion

                #region Hero abilities
                case "AHbz":
                    return "暴风雪";
                case "AHwe":
                    return "召唤水元素";
                case "AHab":
                    return "辉煌光环";
                case "AHmt":
                    return "群体传送";

                case "AHtb":
                    return "风暴之锤";
                case "AHtc":
                    return "雷霆一击";
                case "AHbh":
                    return "重击";
                case "AHav":
                    return "天神下凡";

                case "AHhb":
                    return "圣光";
                case "AHds":
                    return "神圣之盾";
                case "AHad":
                    return "专注光环";
                case "AHre":
                    return "复活";

                case "AHdr":
                    return "魔法吸吮";
                case "AHfs":
                    return "烈焰风暴";
                case "AHbn":
                    return "放逐";
                case "AHpx":
                    return "火凤凰";

                case "AEmb":
                    return "法力燃烧";
                case "AEim":
                    return "献祭";
                case "AEev":
                    return "闪避";
                case "AEme":
                    return "变身";

                case "AEer":
                    return "缠绕根须";
                case "AEfn":
                    return "自然之力";
                case "AEah":
                    return "荆棘光环";
                case "AEtq":
                    return "宁静之雨";

                case "AEst":
                    return "侦察";
                case "AHfa":
                    return "灼热之箭";
                case "AEar":
                    return "强击光环";
                case "AEsf":
                    return "群星坠落";

                case "AEbl":
                    return "闪烁";
                case "AEfk":
                    return "刀阵旋风";
                case "AEsh":
                    return "暗影突袭";
                case "AEsv":
                    return "复仇天神";

                case "AOwk":
                    return "疾风步";
                case "AOmi":
                    return "镜像";
                case "AOcr":
                    return "致命一击";
                case "AOww":
                    return "剑刃风暴";

                case "AOcl":
                    return "闪电链";
                case "AOfs":
                    return "透视";
                case "AOsf":
                    return "召唤精灵狼";
                case "AOeq":
                    return "地震";

                case "AOsh":
                    return "冲击波";
                case "AOae":
                    return "耐久光环";
                case "AOws":
                    return "战争践踏";
                case "AOre":
                    return "重生";

                case "AOhw":
                    return "医疗波";
                case "AOhx":
                    return "妖术";
                case "AOsw":
                    return "毒蛇守卫";
                case "AOvd":
                    return "巫毒";

                case "AUdc":
                    return "死亡缠绕";
                case "AUdp":
                    return "死亡契约";
                case "AUau":
                    return "邪恶光环";
                case "AUan":
                    return "操作光环";

                case "AUcs":
                    return "腐臭蜂群";
                case "AUsl":
                    return "睡眠";
                case "AUav":
                    return "吸血光环";
                case "AUin":
                    return "地狱火";

                case "AUfn":
                    return "霜冻新星";
                case "AUfa":
                    return "冰霜护甲";
                case "AUdr":
                    return "黑暗仪式";
                case "AUdd":
                    return "死亡凋零";

                case "AUim":
                    return "穿刺";
                case "AUts":
                    return "尖刺外壳";
                case "AUcb":
                    return "腐尸甲虫";
                case "AUls":
                    return "蝗虫群";

                case "ANbf":
                    return "火焰呼吸";
                case "ANdb":
                    return "醉拳";
                case "ANdh":
                    return "醉酒云雾";
                case "ANef":
                    return "火土风暴";

                case "ANdr":
                    return "生命汲取";
                case "ANsi":
                    return "沉默";
                case "ANba":
                    return "黑暗之箭";
                case "ANch":
                    return "符咒";

                case "ANms":
                    return "魔法护盾";
                case "ANfa":
                    return "冰冻之箭";
                case "ANfl":
                    return "叉状闪电";
                case "ANto":
                    return "龙卷风";

                case "ANrf":
                    return "火焰之雨";
                case "ANca":
                    return "分裂攻击";
                case "ANht":
                    return "恐怖嚎叫";
                case "ANdo":
                    return "毁灭守卫";

                case "ANsg":
                    return "召唤熊";
                case "ANsq":
                    return "召唤豪猪";
                case "ANsw":
                    return "召唤战鹰";
                case "ANst":
                    return "惊吓";

                case "ANeg":
                    return "工程升级";
                case "ANcs":
                    return "火箭弹";
                case "ANsy":
                    return "口袋工场";
                case "ANrg":
                    return "机械地精";

                case "ANic":
                    return "燃灰";
                case "ANso":
                    return "灵魂燃烧";
                case "ANlm":
                    return "招唤炎魔";
                case "ANvc":
                    return "火山爆发";

                case "ANhs":
                    return "医疗气雾";
                case "ANab":
                    return "酸性炸弹";
                case "ANcr":
                    return "化学风暴";
                case "ANtm":
                    return "炼金术";
                #endregion

                #region Units
                case "hfoo":
                    return "步兵";
                case "hkni":
                    return "骑士";
                case "hmpr":
                    return "牧师";
                case "hmtm":
                    return "迫击炮小队";
                case "hpea":
                    return "农民";
                case "hrif":
                    return "矮人火枪手";
                case "hsor":
                    return "女巫";
                case "hmtt":
                    return "蒸汽机车";
                case "hgry":
                    return "狮鹫骑士";
                case "hgyr":
                    return "飞行机器";
                case "hspt":
                    return "魔法破坏者";
                case "hdhw":
                    return "龙鹰骑士";

                case "ebal":
                    return "投刃车";
                case "echm":
                    return "奇美拉";
                case "edoc":
                    return "利爪德鲁伊";
                case "edot":
                    return "风之德鲁伊";
                case "ewsp":
                    return "小精灵";
                case "esen":
                    return "女猎手";
                case "earc":
                    return "弓箭手";
                case "edry":
                    return "树妖";
                case "ehip":
                    return "角鹰兽";
                case "emtg":
                    return "山岭巨人";
                case "efdr":
                    return "精灵龙";


                case "ocat":
                    return "投石车";
                case "odoc":
                    return "巨魔巫医";
                case "ogru":
                    return "兽族步兵";
                case "ohun":
                    return "巨魔猎头者";
                case "okod":
                    return "科多兽";
                case "opeo":
                    return "苦工";
                case "orai":
                    return "掠夺者";
                case "oshm":
                    return "撒满祭司";
                case "otau":
                    return "牛头人";
                case "owyv":
                    return "风骑士";
                case "ospw":
                    return "灵魂行者";
                case "otbr":
                    return "巨魔蝙蝠骑士";

                case "uaco":
                    return "侍僧";
                case "uabo":
                    return "憎恶";
                case "uban":
                    return "女妖";
                case "ucry":
                    return "地穴恶魔";
                case "ufro":
                    return "冰霜巨龙";
                case "ugar":
                    return "石像鬼";
                case "ugho":
                    return "食尸鬼";
                case "unec":
                    return "男巫";
                case "umtw":
                    return "绞肉车";
                case "ushd":
                    return "阴影";
                case "uobs":
                    return "十胜石雕像";
                case "ubsp":
                    return "破坏者";

                #region neu
                case "nskm":
                    return "Skeletal Marksman";
                case "nskf":
                    return "燃烧弓箭手";
                case "nws1":
                    return "龙鹰";
                case "nban":
                    return "强盗";
                case "nrog":
                    return "流氓";
                case "nenf":
                    return "强制者";
                case "nass":
                    return "刺客";
                case "nbdk":
                    return "Black Drake";
                case "nrdk":
                    return "Red Dragon Whelp";
                case "nbdr":
                    return "Black Dragon Whelp";
                case "nrdr":
                    return "Red Drake";
                case "nbwm":
                    return "黑龙";
                case "nrwm":
                    return "红龙";
                case "nadr":
                    return "蓝龙";
                case "nadw":
                    return "Blue Dragon Whelp";
                case "nadk":
                    return "Blue Drake";
                case "nbzd":
                    return "青龙";
                case "nbzk":
                    return "Bronze Drake";
                case "nbzw":
                    return "Bronze Dragon Whelp";
                case "ngrd":
                    return "绿龙";
                case "ngdk":
                    return "Green Drake";
                case "ngrw":
                    return "Green Dragon Whelp";
                case "ncea":
                    return "半人马弓箭手";
                case "ncen":
                    return "Centaur Outrunner";
                case "ncer":
                    return "Centaur Drudge";
                case "ndth":
                    return "黑暗树魔高级牧师";
                case "ndtp":
                    return "黑暗树魔影子牧师";
                case "ndtb":
                    return "黑暗树魔狂战士";
                case "ndtw":
                    return "黑暗树魔首领";
                case "ndtr":
                    return "黑暗树魔";
                case "ndtt":
                    return "Dark Troll Trapper";
                case "nfsh":
                    return "树魔高级牧师";
                case "nfsp":
                    return "树魔影子牧师";
                case "nftr":
                    return "冰霜树魔";
                case "nftb":
                    return "树魔狂战士";
                case "nftt":
                    return "Forest Troll Trapper";
                case "nftk":
                    return "冰霜树魔首领";
                case "ngrk":
                    return "泥潭傀儡";
                case "ngir":
                    return "地精撕裂者";
                case "nfrs":
                    return "Furbolg Shaman";
                case "ngna":
                    return "Gnoll Poacher";
                case "ngns":
                    return "Gnoll Assassin";
                case "ngno":
                    return "Gnoll";
                case "ngnb":
                    return "Gnoll Brute";
                case "ngnw":
                    return "Gnoll Warden";
                case "ngnv":
                    return "Gnoll Overseer";
                case "ngsp":
                    return "地精工兵";
                case "nhrr":
                    return "Harpy Rogue";
                case "nhrw":
                    return "Harpy Windwitch";
                case "nits":
                    return "冰霜树魔狂战士";
                case "nitt":
                    return "Ice Troll Trapper";
                case "nkob":
                    return "Kobold";
                case "nkog":
                    return "Kobold Geomancer";
                case "nthl":
                    return "Thunder Lizard";
                case "nmfs":
                    return "Murloc Flesheater";
                case "nmrr":
                    return "Murloc Huntsman";
                case "nowb":
                    return "Wildkin";
                case "nrzm":
                    return "Razormane Medicine Man";
                case "nnwa":
                    return "Nerubian Warrior";
                case "nnwl":
                    return "Nerubian Webspinner";
                case "nogr":
                    return "食人鬼战士";
                case "nogm":
                    return "食人鬼拳手";
                case "nogl":
                    return "食人鬼首领";
                case "nomg":
                    return "食人鬼法师";
                case "nrvs":
                    return "Frost Revenant";
                case "nslf":
                    return "Sludge Flinger";
                case "nsts":
                    return "Satyr Shadowdancer";
                case "nstl":
                    return "Satyr Soulstealer";
                case "nzep":
                    return "地精飞艇";
                case "ntrt":
                    return "Giant Sea Turtle";
                case "nlds":
                    return "Makrura Deepseer";
                case "nlsn":
                    return "Makrura Snapper";
                case "nmsn":
                    return "Mur'gul Snarecaster";
                case "nscb":
                    return "Spider Crab Shorecrawler";
                case "nbot":
                    return "运输船";
                case "nsc2":
                    return "Spider Crab Limbripper";
                case "nsc3":
                    return "Spider Crab Behemoth";
                case "nbdm":
                    return "Blue Dragonspawn Meddler";
                case "nmgw":
                    return "Magnataur Warrior";
                case "nanb":
                    return "Barbed Arachnathid";
                case "nanm":
                    return "Barbed Arachnathid";
                case "nfps":
                    return "Polar Furbolg Shaman";
                case "nmgv":
                    return "Magic Vault";
                case "nitb":
                    return "Icy Treasure Box";
                case "npfl":
                    return "Fel Beast";
                case "ndrd":
                    return "Draenei Darkslayer";
                case "ndrm":
                    return "Draenei Disciple";
                case "nvdw":
                    return "Voidwalker";
                case "nvdg":
                    return "Greater Voidwalker";
                case "nnht":
                    return "Nether Dragon Hatchling";
                case "nndk":
                    return "Nether Drake";
                case "nndr":
                    return "Nether Dragon";
                #endregion
                #endregion

                #region building upgrade
                case "hkee":
                    return "主城(升级)";
                case "hcas":
                    return "城堡(升级)";
                case "hctw":
                    return "炮塔(升级)";
                case "hgtw":
                    return "防御塔(升级)";
                case "hatw":
                    return "神秘之塔(升级)";
                case "unp1":
                    return "亡者大厅(升级)";
                case "unp2":
                    return "黑色城堡(升级)";
                case "uzg1":
                    return "幽魂之塔(升级)";
                case "uzg2":
                    return "蛛网怪塔(升级)";
                case "ofrt":
                    return "要塞(升级)";
                case "ostr":
                    return "堡垒(升级)";
                case "etoa":
                    return "远古之树(升级)";
                case "etoe":
                    return "永恒之树(升级)";

                #endregion

                #region buildings
                case "halt":
                    return "国王祭坛";
                case "harm":
                    return "工场";
                case "hars":
                    return "神秘圣地";
                case "hbar":
                    return "兵营";
                case "hbla":
                    return "铁匠铺";
                case "hhou":
                    return "农场";
                case "hgra":
                    return "狮鹫笼";
                case "hwtw":
                    return "侦查塔";
                case "hvlt":
                    return "神秘藏宝室";
                case "hlum":
                    return "伐木场";
                case "htow":
                    return "城镇大厅";

                case "etrp":
                    return "远古守护者";
                case "etol":
                    return "生命之树";
                case "edob":
                    return "猎手大厅";
                case "eate":
                    return "长者祭坛";
                case "eden":
                    return "奇迹古树";
                case "eaoe":
                    return "知识古树";
                case "eaom":
                    return "战争古树";
                case "eaow":
                    return "风之古树";
                case "edos":
                    return "奇美拉栖木";
                case "emow":
                    return "月亮井";

                case "oalt":
                    return "风暴祭坛";
                case "obar":
                    return "兵营";
                case "obea":
                    return "兽栏";
                case "ofor":
                    return "战争磨坊";
                case "ogre":
                    return "兽人大厅";
                case "osld":
                    return "灵魂归宿";
                case "otrb":
                    return "兽人地洞";
                case "orbr":
                    return "强化兽人地洞";
                case "otto":
                    return "牛头人图腾";
                case "ovln":
                    return "巫毒商店";
                case "owtw":
                    return "守卫塔";

                case "uaod":
                    return "黑暗祭坛";
                case "unpl":
                    return "大墓地";
                case "usep":
                    return "地穴";
                case "utod":
                    return "诅咒神庙";
                case "utom":
                    return "古墓废墟";
                case "ugol":
                    return "闹鬼金矿";
                case "uzig":
                    return "通灵塔";
                case "ubon":
                    return "埋骨地";
                case "usap":
                    return "牺牲深渊";
                case "uslh":
                    return "屠宰场";
                case "ugrv":
                    return "坟场";
                #endregion

                #region item
                case "I00Q": return "107-医疗药剂";
                case "I0AJ": return "111-岗哨守卫";
                case "I08R": return "108-急救药剂";
                case "I08L": return "114-扳手";
                case "I00S": return "109-魔法药剂";
                case "stwp": return "113-回城卷轴";
                case "wswd": return "112-探测守卫";
                case "pinv": return "110-隐形药水";
                case "I01V": return "39-刺客佩刀";
                case "I02D": return "31-力量图腾";
                case "I01N": return "23-力量手套";
                case "I00N": return "12-加速手套";
                case "I036": return "34-勇气勋章";
                case "I02H": return "19-卡嘉护身符";
                case "I08S": return "42-国王之冠";
                case "I01U": return "3-大斧";
                case "I00F": return "6-守护指环";
                case "I02C": return "32-霜寒之刃";
                case "I00G": return "27-巨人腰带";
                case "I02B": return "33-巫师手杖";
                case "I01R": return "17-恢复指环";
                case "I038": return "36-戈尔贡短弓";
                case "I00E": return "2-攻击之爪";
                case "I01O": return "24-敏捷便鞋";
                case "I01P": return "25-智力斗篷";
                case "I02E": return "40-月光枪";
                case "I01Y": return "10-月光铠甲";
                case "I03A": return "1-木棒";
                case "I00P": return "13-死亡面罩";
                case "I07Z": return "125-毒液之球Lv1";
                case "I081": return "126-毒液之球Lv2";
                case "I080": return "127-毒液之球Lv3";
                case "I04E": return "5-沉重铁锤";
                case "I02F": return "21-治疗戒指";
                case "I00L": return "29-法师长袍";
                case "I037": return "35-独眼巨人之斧";
                case "I00J": return "15-生命护身符";
                case "I07I": return "43-祈祷项链";
                case "I02I": return "38-神圣戒指";
                case "I03E": return "41-秘银铠甲";
                case "I00M": return "28-精灵长靴";
                case "I00K": return "16-能量垂饰";
                case "I01S": return "18-艺人面罩";
                case "I039": return "37-萨拉莫之杖";
                case "I00O": return "30-贵族圆环";
                case "I00H": return "11-速度之靴";
                case "I01T": return "4-铁剑";
                case "I00I": return "14-闪避护符";
                case "I03B": return "122-霜冻之球Lv1";
                case "I07F": return "123-霜冻之球Lv2";
                case "I07G": return "124-霜冻之球Lv3";
                case "I03D": return "22-魔力护腕";
                case "I01Q": return "26-魔法别针";
                case "I02G": return "20-魔法垂饰";
                case "I07M": return "8-鳞甲";
                case "I08N": return "128-黑暗之球Lv1";
                case "I08O": return "129-黑暗之球Lv2";
                case "I08P": return "130-黑暗之球Lv3";
                case "I047": return "9-龙甲";
                case "I01W": return "7-木盾";
                case "I029": return "45-神秘手套";
                case "I04G": return "69-暗杀斧";
                case "I03K": return "67-开山巨斧";
                case "I056": return "70-幻影斧";
                case "I02O": return "63-嗜血";
                case "I01D": return "99-优越之戒";
                case "I027": return "47-维持挂件";
                case "I028": return "46-蜘蛛戒指";
                case "I040": return "85-金手指";
                case "I00X": return "52-盗贼短剑";
                case "I023": return "95-幽灵之靴";
                case "I09D": return "77-赫卡特法杖";
                case "I04R": return "73-水晶杖";
                case "I03I": return "66-雪盲";
                case "I042": return "55-爆炎剑";
                case "I095": return "64-撕裂者";
                case "I04N": return "90-皮盾";
                case "I03U": return "100-宝石项链";
                case "I012": return "101-生命之戒";
                case "I090": return "44-坚韧指环";
                case "I018": return "54-退魔短剑";
                case "I063": return "79-平行法杖";
                case "I04A": return "93-幻化之盾";
                case "I02P": return "75-霞光";
                case "I04Y": return "74-言灵";
                case "I019": return "97-圣贤靴";
                case "I05W": return "98-飞翔靴";
                case "I092": return "115-合金战靴";
                case "I08U": return "96-冲刺靴";
                case "I03Y": return "56-圣裁";
                case "I02N": return "53-青玉";
                case "I01E": return "91-镜盾";
                case "I021": return "51-灼热之盾";
                case "I03M": return "50-治疗头巾";
                case "I044": return "48-羽毛别针";
                case "I04T": return "82-勇敢者面具";
                case "I058": return "72-卡拉的征服";
                case "I050": return "78-北风之杖";
                case "I06M": return "62-王者之剑";
                case "I04W": return "60-皓月";
                case "I06E": return "59-绝望剃刀";
                case "I03S": return "86-尖刺铠甲";
                case "I04P": return "92-荣誉护盾";
                case "I03W": return "105-邪恶图腾";
                case "I0AR": return "89-色雷胸甲";
                case "I09N": return "104-北极星";
                case "I03Q": return "49-双鞭";
                case "I04I": return "84-复仇面具";
                case "I08W": return "102-鲜血宝石";
                case "I09B": return "103-克罗托的眷顾";
                case "I04B": return "87-瑟西的胸章";
                case "I06C": return "65-石制巨锤";
                case "I09G": return "81-梅里克魔杖";
                case "I06A": return "88-青卫甲";
                case "I03G": return "68-托尔的魔法锤";
                case "I099": return "94-血之赞歌";
                case "I054": return "118-古代精灵之杖";
                case "I06I": return "57-冥殿之针";
                case "I066": return "61-蝴蝶";
                case "I05I": return "72-辉耀";
                case "I068": return "58-魅影";
                case "I060": return "106-奥西里斯之心";
                case "I052": return "116-提丰之邪力";
                case "I05P": return "76-希尔菲的魔杖";
                case "I064": return "117-星杖";
                case "I08X": return "80-盖亚之杖";
                case "I0A1": return "71-毁灭之斧";
                case "I0AC": return "121-亡灵铠甲";
                case "I0A9": return "119-痛苦头骨";
                case "I0AB": return "120-十字章挂件";
                case "I0A2": return "154-冥殿之针改";
                case "I07H": return "153-神圣之盾";
                case "I03C": return "152-疾雷鞋";
                case "sreg": return "恢复卷轴";
                case "gold": return "金币";
                case "lmbr": return "木头";
                case "fgun": return "Flare Gun";
                case "pomn": return "Potion of Omniscience";
                case "gomn": return "Glyph of Omniscience";
                case "wneu": return "中和权杖";
                case "silk": return "Spider Silk Broach";
                case "lure": return "Monster Lure";
                case "skul": return "Sacrificial Skull";
                case "moon": return "月亮石";
                case "brac": return "Runed Bracers";
                case "vamp": return "Vampiric Potion";
                case "woms": return "偷魔权杖";
                case "tcas": return "微型城堡";
                case "tgrh": return "微型大厅";
                case "tsct": return "象牙塔";
                case "wshs": return "Wand of Shadowsight";
                case "tret": return "重修之书";
                case "sneg": return "否定权杖";
                case "stel": return "传送权杖";
                case "spre": return "保存权杖";
                case "mcri": return "机械小动物";
                case "spsh": return "魔法护盾";
                case "sbok": return "Spell Book";
                case "ssan": return "避难权杖";
                case "shas": return "速度卷轴";
                case "dust": return "显影尘土";
                case "oslo": return "减速之球";
                case "dsum": return "Diamond of Summoning";
                case "sor1": return "Shadow Orb +1";
                case "sor2": return "Shadow Orb +2";
                case "sor3": return "Shadow Orb +3";
                case "sor4": return "Shadow Orb +4";
                case "sor5": return "Shadow Orb +5";
                case "sor6": return "Shadow Orb +6";
                case "sor7": return "Shadow Orb +7";
                case "sor8": return "Shadow Orb +8";
                case "sor9": return "Shadow Orb +9";
                case "sora": return "Shadow Orb +10";
                case "sorf": return "Shadow Orb Fragment";
                case "fwss": return "Frost Wyrm Skull Shield";
                case "ram1": return "Ring of the Archmagi";
                case "ram2": return "Ring of the Archmagi";
                case "ram3": return "Ring of the Archmagi";
                case "ram4": return "Ring of the Archmagi";
                case "shtm": return "Shamanic Totem";
                case "shwd": return "Shimmerweed";
                case "btst": return "Battle Standard";
                case "skrt": return "Skeletal Artifact";
                case "thle": return "雷霆蜥蜴蛋";
                case "sclp": return "Secret Level Powerup";
                case "gldo": return "Orb of Kil'jaeden";
                case "tbsm": return "Tiny Blacksmith";
                case "tfar": return "Tiny Farm";
                case "tlum": return "Tiny Lumber Mill";
                case "tbar": return "Tiny Barracks";
                case "tbak": return "Tiny Altar of Kings";
                case "mgtk": return "Magic Key Chain";
                case "stre": return "Staff of Reanimation";
                case "horl": return "Sacred Relic";
                case "hbth": return "Helm of Battlethirst";
                case "blba": return "Bladebane Armor";
                case "rugt": return "Runed Gauntlets";
                case "frhg": return "Firehand Gauntlets";
                case "gvsm": return "Gloves of Spell Mastery";
                case "crdt": return "Crown of the Deathlord";
                case "arsc": return "Arcane Scroll";
                case "scul": return "Scroll of the Unholy Legion";
                case "tmsc": return "Tome of Sacrifices";
                case "dtsb": return "Drek'thar's Spellbook";
                case "grsl": return "Grimoire of Souls";
                case "arsh": return "Arcanite Shield";
                case "shdt": return "Shield of the Deathlord";
                case "shhn": return "荣誉护盾";
                case "shen": return "Enchanted Shield";
                case "thdm": return "Thunderlizard Diamond";
                case "stpg": return "Clockwork Penguin";
                case "shrs": return "Shimmerglaze Roast";
                case "bfhr": return "Bloodfeather's Heart";
                case "cosl": return "Celestial Orb of Souls";
                case "shcw": return "Shaman Claws";
                case "srbd": return "Searing Blade";
                case "frgd": return "Frostguard";
                case "envl": return "Enchanted Vial";
                case "rump": return "Rusty Mining Pick";
                case "mort": return "Mogrin's Report";
                case "srtl": return "Serathil";
                case "stwa": return "Sturdy War Axe";
                case "klmm": return "Killmaim";
                case "rots": return "Scepter of the Sea";
                case "axas": return "Ancestral Staff";
                case "mnsf": return "Mindstaff";
                case "schl": return "Scepter of Healing";
                case "asbl": return "Assassin's Blade";
                case "kgal": return "Keg of Ale";
                case "dphe": return "Thunder Phoenix Egg";
                case "dkfw": return "Keg of Thunderwater";
                case "dthb": return "Thunderbloom Bulb";

                #endregion

                #region research
                case "Rhss": return "魔法控制";
                case "Rhme": return "铁剑术";
                case "Rhra": return "黑火药";
                case "Rhar": return "镶皮甲";
                case "Rhla": return "铁甲";
                case "Rhac": return "石工术";
                case "Rhgb": return "矮人直升机炸弹";
                case "Rhlh": return "伐木术";
                case "Rhde": return "盾牌";
                case "Rhan": return "动物作战训练";
                case "Rhpt": return "牧师训练";
                case "Rhst": return "女巫训练";
                case "Rhri": return "长管火枪";
                case "Rhse": return "魔法岗哨";
                case "Rhfl": return "闪光弹";
                case "Rhhb": return "风暴之锤";
                case "Rhrt": return "弹幕攻击";
                case "Rhpm": return "背包";
                case "Rhfc": return "高射炮火";
                case "Rhfs": return "碎片攻击";
                case "Rhcd": return "乌云";
                case "Resm": return "月之力量";
                case "Resw": return "野性力量";
                case "Rema": return "月之护甲";
                case "Rerh": return "加强隐蔽";
                case "Reuv": return "夜视";
                case "Renb": return "自然的祝福";
                case "Reib": return "硬弓";
                case "Remk": return "射击术";
                case "Resc": return "哨兵";
                case "Remg": return "月刃";
                case "Redt": return "风德训练";
                case "Redc": return "熊德训练";
                case "Resi": return "驱散";
                case "Reht": return "骑乘角鹰兽";
                case "Recb": return "腐蚀之息";
                case "Repb": return "穿刺投刃";
                case "Rers": return "抗性皮肤";
                case "Rehs": return "硬化皮肤";
                case "Reeb": return "利爪之痕";
                case "Reec": return "猛禽之痕";
                case "Rews": return "月井之春";
                case "Repm": return "背包";
                case "Roch": return "Chaos";
                case "Rome": return "近战武器";
                case "Rora": return "远程武器";
                case "Roar": return "防御";
                case "Rwdm": return "强化战鼓";
                case "Ropg": return "掠夺";
                case "Robs": return "狂暴力量";
                case "Rows": return "粉碎";
                case "Roen": return "诱补";
                case "Rovs": return "毒矛";
                case "Rowd": return "巫医训练";
                case "Rost": return "萨满训练";
                case "Rosp": return "长钉路障";
                case "Rotr": return "巨魔再生";
                case "Rolf": return "液体炸弹";
                case "Ropm": return "背包";
                case "Rowt": return "灵魂行者训练";
                case "Robk": return "狂战士升级";
                case "Rorb": return "加强防御";
                case "Robf": return "燃烧之油";
                case "Rusp": return "毁灭形态";
                case "Rume": return "邪恶力量";
                case "Rura": return "生物攻击";
                case "Ruar": return "邪恶装甲";
                case "Rucr": return "生物甲壳";
                case "Ruac": return "食尸";
                case "Rugf": return "食尸鬼狂暴";
                case "Ruwb": return "网";
                case "Rusf": return "石像形态";
                case "Rune": return "男妖训练";
                case "Ruba": return "女妖训练";
                case "Rufb": return "冰冻吐息";
                case "Rusl": return "骨质增强";
                case "Rupc": return "瘟疫云雾";
                case "Rusm": return "骷髅支配";
                case "Rubu": return "钻地";
                case "Ruex": return "挖掘尸体";
                case "Rupm": return "背包";

                #endregion

                default:
                    return itemId;
            }
        }
    }
}