using System.ComponentModel.DataAnnotations;

public enum School1 : long
{
    [Display(Name = "请选择")]
    Null = 9,
    [Display(Name = "瑞海蒙氏幼儿园")]
    jiyang1 = 4602261101,

    [Display(Name = "三亚市第二小学")]
    jiyang2 = 4602261102,

    [Display(Name = "三亚丰和学校（丹州校区）")]
    jiyang3 = 4602261104,

    [Display(Name = "三亚技师学校")]
    jiyang4 = 4602261105,

    [Display(Name = "三亚学院")]
    jiyang5 = 4602261106,
    //天涯区
    [Display(Name = "三亚丰和学校（育新校区）")]
    sanYaFengHeYuXin = 4602262103,

    [Display(Name = "东方明珠幼儿园")]
    dongFangMingZhu = 4602262107,

    [Display(Name = "三亚市第四小学")]
    sanYaDiSiXiaoXue = 4602262108,

    [Display(Name = "三亚市凤凰中学（初中）")]
    sanYaFengHuangChuZhong = 4602262209,

    [Display(Name = "三亚市第二中学（初中）")]
    sanYaDiErChuZhong = 4602262110,

    [Display(Name = "三亚市第二中学（高中）")]
    sanYaDiErGaoZhong = 4602262111,
    //崖州区
    [Display(Name = "崖州湾科技城第一幼儿园")]
    yaZhouWanKeJiChengDiYiYouErYuan = 4602263212,

    [Display(Name = "三亚市崖城小学")]
    sanYaYaChengXiaoXue = 4602263213,

    [Display(Name = "田家炳高级中学（高中）")]
    tianJiaBingGaoJiZhongXue = 4602263214,
    //海堂区
    [Display(Name = "海棠区第二幼儿园")]
    haiTangQuDiErYouErYuan = 4602264215,

    [Display(Name = "海棠区第一小学")]
    haiTangQuDiYiXiaoXue = 4602264216,

    [Display(Name = "中国人民大学附属中学三亚学校（初中）")]
    zhongGuoRenMinDaXueFuShuZhongXueSanYaXueXiaoChuZhong = 4602264217,
    //海口市
    //秀英区
    [Display(Name = "旅游职业学校")]
    lvYouZhiYeXueXiao = 4601151101,

    [Display(Name = "海口海港学校（高中）")]
    haiKouHaiGangXueXiaoGaoZhong = 4601151107,

    [Display(Name = "西秀镇拔南小学（丰盈小学）")]
    xiXiuZhenBaNanXiaoXueFengYingXiaoXue = 4601151206,

    [Display(Name = "东山中学（初中）")]
    dongShanZhongXueChuZhong = 4601151210,

    [Display(Name = "西秀镇中心幼儿园")]
    xiXiuZhenZhongXinYouErYuan = 4601151216,
    //琼山区
    [Display(Name = "海口市琼山中学（初中）")]
    haiKouShiQiongShanZhongXueChuZhong = 4601153105,

    [Display(Name = "海南海政学校")]
    haiNanGuoXingZhongXueGaoZhongBu = 4601153114,

    [Display(Name = "云龙镇中心小学")]
    yunLongZhenZhongXinXiaoXue = 4601153215,

    [Display(Name = "海口市琼山幼儿园")]
    haiKouShiQiongShanYouErYuan = 4601153109,

    [Display(Name = "海南师范大学")]
    haiNanShiFanDaXue = 4601153117,
    //龙华区
    [Display(Name = "市机关幼儿园")]
    shiJiGuanYouErYuan = 4601152111,

    [Display(Name = "滨海小学")]
    binHaiXiaoXue = 4601152112,

    [Display(Name = "海南侨中观澜湖学校（高中）")]
    haiNanQiaoZhongGuanLanHuXueXiaoGaoZhong = 4601152218,

    [Display(Name = "新坡中学（初中）")]
    xinPoZhongXueChuZhong = 4601152213,
    //美兰区
    [Display(Name = "灵山镇中心幼儿园")]
    lingShanZhenZhongXinYouErYuan = 4601154202,

    [Display(Name = "海联中学（初中）")]
    haiLianZhongXueChuZhong = 4601154103,

    [Display(Name = "美苑小学")]
    meiYuanXiaoXue = 4601154104,

    [Display(Name = "海口市灵山中学（高中）")]
    haiKouShiLingShanZhongXueGaoZhong = 4601154208,
    //儋州市
    //儋州市
    [Display(Name = "中国热带农业科学院幼儿园")]
    zhongGuoReDaiNongYeKeXueYuanYouErYuan = 4603271101,

    [Display(Name = "儋州市农垦那大机械厂幼儿园")]
    danZhouShiNongKenNaDaJiXieChangYouErYuan = 4603271102,

    [Display(Name = "儋州两院中心小学")]
    danZhouLiangYuanZhongXinXiaoXue = 4603271103,

    [Display(Name = "那大实验学校（四小）")]
    naDaShiYanXueXiaoSiXiao = 4603271104,

    [Display(Name = "儋州市两院中学（初中）")]
    danZhouShiLiangYuanZhongXueChuZhong = 4603271105,

    [Display(Name = "儋州市第一中学（初中）")]
    danZhouShiDiYiZhongXueChuZhong = 4603271106,

    [Display(Name = "儋州市民族中学（高中）")]
    danZhouShiMinZuZhongXueGaoZhong = 4603271107,

    [Display(Name = "儋州市第二中学（高中）")]
    danZhouShiDiErZhongXueGaoZhong = 4603271108,

    [Display(Name = "儋州市中等职业技术学校")]
    danZhouShiZhongDengZhiYeJiShuXueXiao = 4603271109,

    [Display(Name = "海南大学儋州校区")]
    haiNanDaXueDanZhouXiaoQu = 4603271110,

    [Display(Name = "东成镇中心幼儿园")]
    dongChengZhenZhongXinYouErYuan = 4603271211,

    [Display(Name = "那大镇中心幼儿园")]
    naDaZhenZhongXinYouErYuan = 4603271112,

    [Display(Name = "洋浦第二幼儿园")]
    yangPuDiErYouErYuan = 4603271213,

    [Display(Name = "洋浦第一小学")]
    yangPuDiYiXiaoXue = 4603271215,

    [Display(Name = "大成中心学校")]
    daChengZhongXinXueXiao = 4603271216,

    [Display(Name = "八一中学（初中）")]
    baYiZhongXueChuZhong = 4603271217,

    [Display(Name = "洋浦中学（初中）")]
    yangPuZhongXueChuZhong = 4603271218,

    [Display(Name = "长坡中学（高中）")]
    changPoZhongXueGaoZhong = 4603271219,

    [Display(Name = "兰洋镇中心幼儿园")]
    lanYangZhenZhongXinYouErYuan = 4603271220,
    //保亭
    [Display(Name = "保亭县第二小学")]
    baoTingXianDiErXiaoXue = 4600317101,

    [Display(Name = "什玲镇中心学校")]
    shiLingZhenZhongXinXueXiao = 4600317202,

    [Display(Name = "保亭春晖幼儿园")]
    baoTingChunHuiYouErYuan = 4600317103,

    [Display(Name = "保城镇幼儿园")]
    baoChengZhenYouErYuan = 4600317104,

    [Display(Name = "保亭中学")]
    baoTingZhongXue = 4600317105,

    [Display(Name = "响水镇金江学校")]
    xiangShuiZhenJinJiangXueXiao = 4600317206,

    [Display(Name = "海之南实验学校")]
    haiZhiNanShiYanXueXiao = 4600317207,
    //琼中
    [Display(Name = "乌石学校（小学）")]
    wuShiXueXiaoXiaoXue = 4600318201,

    [Display(Name = "乌石学校（初中）")]
    wuShiXueXiaoChuZhong = 4600318202,

    [Display(Name = "阳江学校（小学）")]
    yangJiangXueXiaoXiaoXue = 4600318203,

    [Display(Name = "阳江学校（初中）")]
    yangJiangXueXiaoChuZhong = 4600318204,

    [Display(Name = "智博幼儿园")]
    zhiBoYouErYuan = 4600318205,

    [Display(Name = "新宝贝幼儿园")]
    xinBaoBeiYouErYuan = 4600318206,

    [Display(Name = "琼中县幼儿园")]
    qiongZhongXianYouErYuan = 4600318107,

    [Display(Name = "琼中中学（高中）")]
    qiongZhongZhongXueGaoZhong = 4600318108,
    //万宁市
    [Display(Name = "万宁市幼儿园")]
    wanNingShiYouErYuan = 4600307101,

    [Display(Name = "万城镇中学（初中）")]
    wanChengZhenZhongXueChuZhong = 4600307105,

    [Display(Name = "三更罗幼儿园")]
    sanGengLuoYouErYuan = 4600307202,

    [Display(Name = "兴隆中心小学")]
    xingLongZhongXinXiaoXue = 4600307203,

    [Display(Name = "新中中心小学")]
    xinZhongZhongXinXiaoXue = 4600307204,

    [Display(Name = "万宁市民族中学初中部")]
    wanNingShiMinZuZhongXueChuZhongBu = 4600307206,

    [Display(Name = "万宁市民族中学高中部")]
    wanNingShiMinZuZhongXueGaoZhongBu = 4600307207,
    //屯昌
    [Display(Name = "乌坡学校（初中）")]
    wuPoXueXiaoChuZhong = 4600310201,

    [Display(Name = "枫木学校（初中）")]
    fengMuXueXiaoChuZhong = 4600310202,

    [Display(Name = "屯昌县新兴镇新兴中心小学")]
    tunChangXianXinXingZhenXinXingZhongXinXiaoXue = 4600310203,

    [Display(Name = "屯昌县幼儿园")]
    tunChangXianYouErYuan = 4600310104,

    [Display(Name = "屯昌县屯城镇中心幼儿园")]
    tunChangXianTunChengZhenZhongXinYouErYuan = 4600310105,

    [Display(Name = "华中师大一附中屯昌思源实验学校（高中）")]
    huaZhongShiDaYiFuZhongTunChangSiYuanShiYanXueXiaoGaoZhong = 4600310106,

    [Display(Name = "屯昌县枫木镇枫木中心小学")]
    tunChangXianFengMuZhenFengMuZhongXinXiaoXue = 4600310207,
    //五指山
    [Display(Name = "五指山嘉佳幼儿园")]
    wuZhiShanJiaJiaYouErYuan = 4600304101,

    [Display(Name = "五指山市幼儿园")]
    wuZhiShanShiYouErYuan = 4600304102,

    [Display(Name = "五指山思源学校（初中）")]
    wuZhiShanSiYuanXueXiaoChuZhong = 4600304103,

    [Display(Name = "五指山中学（初中）")]
    wuZhiShanZhongXueChuZhong = 4600304104,

    [Display(Name = "五指山市第三小学")]
    wuZhiShanShiDiSanXiaoXue = 4600304105,

    [Display(Name = "五指山市第一小学")]
    wuZhiShanShiDiYiXiaoXue = 4600304106,

    [Display(Name = "五指山中学（高中）")]
    wuZhiShanZhongXueGaoZhong = 4600304107,
    //东方
    [Display(Name = "东河中心学校（小学）")]
    dongHeZhongXinXueXiaoXiaoXue = 4600308201,

    [Display(Name = "广坝农场中心学校（小学）")]
    guangBaNongChangZhongXinXueXiaoXiaoXue = 4600308202,

    [Display(Name = "大田中学（初中）")]
    daTianZhongXueChuZhong = 4600308203,

    [Display(Name = "感城中学（初中）")]
    ganChengZhongXueChuZhong = 4600308204,

    [Display(Name = "琼西中学高中部")]
    qiongXiZhongXueGaoZhongBu = 4600308105,

    [Display(Name = "东方市幼儿园")]
    dongFangShiYouErYuan = 4600308106,

    [Display(Name = "感城镇中心幼儿园")]
    ganChengZhenZhongXinYouErYuan = 4600308207,
    //陵水
    [Display(Name = "陵水县机关幼儿园")]
    lingShuiXianJiGuanYouErYuan = 4600316101,

    [Display(Name = "东华初级中学（初中）")]
    dongHuaChuJiZhongXueChuZhong = 4600316102,

    [Display(Name = "陵水民族中学（初中）")]
    lingShuiMinZuZhongXueChuZhong = 4600316103,

    [Display(Name = "椰林第一小学")]
    yeLinDiYiXiaoXue = 4600316104,

    [Display(Name = "文罗中心小学")]
    wenLuoZhongXinXiaoXue = 4600316205,

    [Display(Name = "桃园村幼儿园")]
    taoYuanCunYouErYuan = 4600316106,

    [Display(Name = "陵水民族中学（高中）")]
    lingShuiMinZuZhongXueGaoZhong = 4600316107,
    //琼海
    [Display(Name = "嘉积镇镇中心小学幼儿园")]
    jiaJiZhenZhongXinXiaoXueYouErYuan = 4600305101,

    [Display(Name = "实验幼儿园")]
    shiYanYouErYuan = 4600305102,

    [Display(Name = "万泉镇中心小学")]
    wanQuanZhenZhongXinXiaoXue = 4600305203,

    [Display(Name = "万泉中学（初中）")]
    wanQuanZhongXueChuZhong = 4600305204,

    [Display(Name = "中原镇中心小学")]
    zhongYuanZhenZhongXinXiaoXue = 4600305205,

    [Display(Name = "琼海华侨中学（初中）")]
    qiongHaiHuaQiaoZhongXueChuZhong = 4600305206,

    [Display(Name = "琼海华侨中学（高中）")]
    qiongHaiHuaQiaoZhongXueGaoZhong = 4600305207,
    //文昌
    [Display(Name = "文昌市田家炳中学（高中）")]
    wenChangShiTianJiaBingZhongXueGaoZhong = 4600306101,

    [Display(Name = "文昌市文汇幼儿园")]
    wenChangShiWenHuiYouErYuan = 4600306102,

    [Display(Name = "会文中心幼儿园")]
    huiWenZhongXinYouErYuan = 4600306203,

    [Display(Name = "会文中心小学")]
    huiWenZhongXinXiaoXue = 4600306204,

    [Display(Name = "会文琼文中学（初中）")]
    huiWenQiongWenZhongXueChuZhong = 4600306205,

    [Display(Name = "联东中学（小学）")]
    lianDongZhongXueXiaoXue = 4600306206,

    [Display(Name = "联东中学（初中）")]
    lianDongZhongXueChuZhong = 4600306207,
    //定安
    [Display(Name = "龙河镇中心学校（小学）")]
    longHeZhenZhongXinXueXiaoXiaoXue = 4600309201,

    [Display(Name = "龙塘中学（初中）")]
    longTangZhongXueChuZhong = 4600309202,

    [Display(Name = "龙门镇中心幼儿园")]
    longMenZhenZhongXinYouErYuan = 4600309203,

    [Display(Name = "雷鸣镇中心学校（小学）")]
    leiMingZhenZhongXinXueXiaoXiaoXue = 4600309204,

    [Display(Name = "雷鸣初级中学（初中）")]
    leiMingChuJiZhongXueChuZhong = 4600309205,

    [Display(Name = "雷鸣镇中心幼儿园")]
    leiMingZhenZhongXinYouErYuan = 4600309206,

    [Display(Name = "城南中学（高中）")]
    chengNanZhongXueGaoZhong = 4600309107,
    //澄迈
    [Display(Name = "永发中心小学")]
    yongFaZhongXinXiaoXue = 4600311201,

    [Display(Name = "文儒中学(初中）")]
    wenRuZhongXueChuZhong = 4600311202,

    [Display(Name = "昆仑学校（小学）")]
    kunLunXueXiaoXiaoXue = 4600311203,

    [Display(Name = "昆仑学校（中学）（初中）")]
    kunLunXueXiaoZhongXueChuZhong = 4600311204,

    [Display(Name = "澄迈县第二中学（高中）")]
    chengMaiXianDiErZhongXueGaoZhong = 4600311105,

    [Display(Name = "中兴童星幼儿园")]
    zhongXingTongXingYouErYuan = 4600311206,

    [Display(Name = "桥头中心幼儿园")]
    qiaoTouZhongXinYouErYuan = 4600311207,

    [Display(Name = "大拉幼儿园")]
    daLaYouErYuan = 4600311208,
    //白沙
    [Display(Name = "七坊镇中心学校（小学）")]
    qiFangZhenZhongXinXueXiaoXiaoXue = 4600313201,

    [Display(Name = "七坊中学（初中）")]
    qiFangZhongXueChuZhong = 4600313202,

    [Display(Name = "邦溪镇中心学校（小学）")]
    bangXiZhenZhongXinXueXiaoXiaoXue = 4600313203,

    [Display(Name = "邦溪初级中学（初中）")]
    bangXiChuJiZhongXueChuZhong = 4600313204,

    [Display(Name = "白沙中学（高中）")]
    baiShaZhongXueGaoZhong = 4600313105,

    [Display(Name = "邦溪镇中心幼儿园")]
    bangXiZhenZhongXinYouErYuan = 4600313206,

    [Display(Name = "七坊镇中心幼儿园")]
    qiFangZhenZhongXinYouErYuan = 4600313207,

    [Display(Name = "打安镇中心幼儿园")]
    daAnZhenZhongXinYouErYuan = 4600313208,

    [Display(Name = "打安萌萌乐幼儿园")]
    daAnMengMengLeYouErYuan = 4600313209,

    [Display(Name = "元门乡中心幼儿园")]
    yuanMenXiangZhongXinYouErYuan = 4600313210,
    //昌江
    [Display(Name = "石碌镇中心幼儿园")]
    shiLuZhenZhongXinYouErYuan = 4600314101,

    [Display(Name = "矿建幼儿园")]
    kuangJianYouErYuan = 4600314102,

    [Display(Name = "佳佳幼儿园")]
    jiaJiaYouErYuan = 4600314103,

    [Display(Name = "思源实验学校（初中）")]
    siYuanShiYanXueXiaoChuZhong = 4600314104,

    [Display(Name = "十月田学校（小学）")]
    shiYueTianXueXiaoXiaoXue = 4600314205,

    [Display(Name = "乌烈镇学校（小学）")]
    wuLieZhenXueXiaoXiaoXue = 4600314206,

    [Display(Name = "乌烈镇学校（初中）")]
    wuLieZhenXueXiaoChuZhong = 4600314207,

    [Display(Name = "昌江中学（高中）")]
    changJiangZhongXueGaoZhong = 4600314108,
    //乐东
    [Display(Name = "海南乐东思源实验高级中学（高中）")]
    leDongSiYuanShiYanGaoJiZhongXue = 4600315101,

    [Display(Name = "九所镇中心幼儿园")]
    jiuSuoZhenZhongXinYouErYuan = 4600315202,

    [Display(Name = "乐东县机关幼儿园")]
    leDongXianJiGuanYouErYuan = 4600315103,

    [Display(Name = "九所中心学校（小学）")]
    jiuSuoZhongXinXueXiaoXiaoXue = 4600315204,

    [Display(Name = "万冲中心学校（小学）")]
    wanChongZhongXinXueXiaoXiaoXue = 4600315205,

    [Display(Name = "九所中学（初中）")]
    jiuSuoZhongXueChuZhong = 4600315206,

    [Display(Name = "千家中学（初中）")]
    qianJiaZhongXueChuZhong = 4600315207,
    //临高
    [Display(Name = "新盈中心学校（小学）")]
    xinYingZhongXinXueXiaoXiaoXue = 4600319201,

    [Display(Name = "加来中心学校（小学）")]
    jiaLaiZhongXinXueXiaoXiaoXue = 4600319202,

    [Display(Name = "美台中学（初中 ）")]
    meiTaiZhongXueChuZhong = 4600319103,

    [Display(Name = "皇桐中学（初中）")]
    huangTongZhongXueChuZhong = 4600319204,

    [Display(Name = "新盈港幼儿园")]
    xinYingGangYouErYuan = 4600319205,

    [Display(Name = "英苗幼儿园")]
    yingMiaoYouErYuan = 4600319206,

    [Display(Name = "临高县第二中学（高中）")]
    linGaoXianDiErZhongXueGaoZhong = 4600319107,
    //三沙市
    //永兴
    [Display(Name = "三沙永兴学校（幼儿园和1-3年级）")]
    sanShaYongXingXueXiaoYouErYuan = 4612200101,

}