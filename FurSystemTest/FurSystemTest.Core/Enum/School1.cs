using System.ComponentModel.DataAnnotations;

public enum School1 : long
{
    [Display(Name = "��ѡ��")]
    Null = 9,
    [Display(Name = "�������׶�԰")]
    jiyang1 = 4602261101,

    [Display(Name = "�����еڶ�Сѧ")]
    jiyang2 = 4602261102,

    [Display(Name = "���Ƿ��ѧУ������У����")]
    jiyang3 = 4602261104,

    [Display(Name = "���Ǽ�ʦѧУ")]
    jiyang4 = 4602261105,

    [Display(Name = "����ѧԺ")]
    jiyang5 = 4602261106,
    //������
    [Display(Name = "���Ƿ��ѧУ������У����")]
    sanYaFengHeYuXin = 4602262103,

    [Display(Name = "���������׶�԰")]
    dongFangMingZhu = 4602262107,

    [Display(Name = "�����е���Сѧ")]
    sanYaDiSiXiaoXue = 4602262108,

    [Display(Name = "�����з����ѧ�����У�")]
    sanYaFengHuangChuZhong = 4602262209,

    [Display(Name = "�����еڶ���ѧ�����У�")]
    sanYaDiErChuZhong = 4602262110,

    [Display(Name = "�����еڶ���ѧ�����У�")]
    sanYaDiErGaoZhong = 4602262111,
    //������
    [Display(Name = "������Ƽ��ǵ�һ�׶�԰")]
    yaZhouWanKeJiChengDiYiYouErYuan = 4602263212,

    [Display(Name = "�������³�Сѧ")]
    sanYaYaChengXiaoXue = 4602263213,

    [Display(Name = "��ұ��߼���ѧ�����У�")]
    tianJiaBingGaoJiZhongXue = 4602263214,
    //������
    [Display(Name = "�������ڶ��׶�԰")]
    haiTangQuDiErYouErYuan = 4602264215,

    [Display(Name = "��������һСѧ")]
    haiTangQuDiYiXiaoXue = 4602264216,

    [Display(Name = "�й������ѧ������ѧ����ѧУ�����У�")]
    zhongGuoRenMinDaXueFuShuZhongXueSanYaXueXiaoChuZhong = 4602264217,
    //������
    //��Ӣ��
    [Display(Name = "����ְҵѧУ")]
    lvYouZhiYeXueXiao = 4601151101,

    [Display(Name = "���ں���ѧУ�����У�")]
    haiKouHaiGangXueXiaoGaoZhong = 4601151107,

    [Display(Name = "���������Сѧ����ӯСѧ��")]
    xiXiuZhenBaNanXiaoXueFengYingXiaoXue = 4601151206,

    [Display(Name = "��ɽ��ѧ�����У�")]
    dongShanZhongXueChuZhong = 4601151210,

    [Display(Name = "�����������׶�԰")]
    xiXiuZhenZhongXinYouErYuan = 4601151216,
    //��ɽ��
    [Display(Name = "��������ɽ��ѧ�����У�")]
    haiKouShiQiongShanZhongXueChuZhong = 4601153105,

    [Display(Name = "���Ϻ���ѧУ")]
    haiNanGuoXingZhongXueGaoZhongBu = 4601153114,

    [Display(Name = "����������Сѧ")]
    yunLongZhenZhongXinXiaoXue = 4601153215,

    [Display(Name = "��������ɽ�׶�԰")]
    haiKouShiQiongShanYouErYuan = 4601153109,

    [Display(Name = "����ʦ����ѧ")]
    haiNanShiFanDaXue = 4601153117,
    //������
    [Display(Name = "�л����׶�԰")]
    shiJiGuanYouErYuan = 4601152111,

    [Display(Name = "����Сѧ")]
    binHaiXiaoXue = 4601152112,

    [Display(Name = "�������й�����ѧУ�����У�")]
    haiNanQiaoZhongGuanLanHuXueXiaoGaoZhong = 4601152218,

    [Display(Name = "������ѧ�����У�")]
    xinPoZhongXueChuZhong = 4601152213,
    //������
    [Display(Name = "��ɽ�������׶�԰")]
    lingShanZhenZhongXinYouErYuan = 4601154202,

    [Display(Name = "������ѧ�����У�")]
    haiLianZhongXueChuZhong = 4601154103,

    [Display(Name = "��ԷСѧ")]
    meiYuanXiaoXue = 4601154104,

    [Display(Name = "��������ɽ��ѧ�����У�")]
    haiKouShiLingShanZhongXueGaoZhong = 4601154208,
    //������
    //������
    [Display(Name = "�й��ȴ�ũҵ��ѧԺ�׶�԰")]
    zhongGuoReDaiNongYeKeXueYuanYouErYuan = 4603271101,

    [Display(Name = "������ũ���Ǵ��е���׶�԰")]
    danZhouShiNongKenNaDaJiXieChangYouErYuan = 4603271102,

    [Display(Name = "������Ժ����Сѧ")]
    danZhouLiangYuanZhongXinXiaoXue = 4603271103,

    [Display(Name = "�Ǵ�ʵ��ѧУ����С��")]
    naDaShiYanXueXiaoSiXiao = 4603271104,

    [Display(Name = "��������Ժ��ѧ�����У�")]
    danZhouShiLiangYuanZhongXueChuZhong = 4603271105,

    [Display(Name = "�����е�һ��ѧ�����У�")]
    danZhouShiDiYiZhongXueChuZhong = 4603271106,

    [Display(Name = "������������ѧ�����У�")]
    danZhouShiMinZuZhongXueGaoZhong = 4603271107,

    [Display(Name = "�����еڶ���ѧ�����У�")]
    danZhouShiDiErZhongXueGaoZhong = 4603271108,

    [Display(Name = "�������е�ְҵ����ѧУ")]
    danZhouShiZhongDengZhiYeJiShuXueXiao = 4603271109,

    [Display(Name = "���ϴ�ѧ����У��")]
    haiNanDaXueDanZhouXiaoQu = 4603271110,

    [Display(Name = "�����������׶�԰")]
    dongChengZhenZhongXinYouErYuan = 4603271211,

    [Display(Name = "�Ǵ��������׶�԰")]
    naDaZhenZhongXinYouErYuan = 4603271112,

    [Display(Name = "���ֵڶ��׶�԰")]
    yangPuDiErYouErYuan = 4603271213,

    [Display(Name = "���ֵ�һСѧ")]
    yangPuDiYiXiaoXue = 4603271215,

    [Display(Name = "�������ѧУ")]
    daChengZhongXinXueXiao = 4603271216,

    [Display(Name = "��һ��ѧ�����У�")]
    baYiZhongXueChuZhong = 4603271217,

    [Display(Name = "������ѧ�����У�")]
    yangPuZhongXueChuZhong = 4603271218,

    [Display(Name = "������ѧ�����У�")]
    changPoZhongXueGaoZhong = 4603271219,

    [Display(Name = "�����������׶�԰")]
    lanYangZhenZhongXinYouErYuan = 4603271220,
    //��ͤ
    [Display(Name = "��ͤ�صڶ�Сѧ")]
    baoTingXianDiErXiaoXue = 4600317101,

    [Display(Name = "ʲ��������ѧУ")]
    shiLingZhenZhongXinXueXiao = 4600317202,

    [Display(Name = "��ͤ�����׶�԰")]
    baoTingChunHuiYouErYuan = 4600317103,

    [Display(Name = "�������׶�԰")]
    baoChengZhenYouErYuan = 4600317104,

    [Display(Name = "��ͤ��ѧ")]
    baoTingZhongXue = 4600317105,

    [Display(Name = "��ˮ���ѧУ")]
    xiangShuiZhenJinJiangXueXiao = 4600317206,

    [Display(Name = "��֮��ʵ��ѧУ")]
    haiZhiNanShiYanXueXiao = 4600317207,
    //����
    [Display(Name = "��ʯѧУ��Сѧ��")]
    wuShiXueXiaoXiaoXue = 4600318201,

    [Display(Name = "��ʯѧУ�����У�")]
    wuShiXueXiaoChuZhong = 4600318202,

    [Display(Name = "����ѧУ��Сѧ��")]
    yangJiangXueXiaoXiaoXue = 4600318203,

    [Display(Name = "����ѧУ�����У�")]
    yangJiangXueXiaoChuZhong = 4600318204,

    [Display(Name = "�ǲ��׶�԰")]
    zhiBoYouErYuan = 4600318205,

    [Display(Name = "�±����׶�԰")]
    xinBaoBeiYouErYuan = 4600318206,

    [Display(Name = "�������׶�԰")]
    qiongZhongXianYouErYuan = 4600318107,

    [Display(Name = "������ѧ�����У�")]
    qiongZhongZhongXueGaoZhong = 4600318108,
    //������
    [Display(Name = "�������׶�԰")]
    wanNingShiYouErYuan = 4600307101,

    [Display(Name = "�������ѧ�����У�")]
    wanChengZhenZhongXueChuZhong = 4600307105,

    [Display(Name = "�������׶�԰")]
    sanGengLuoYouErYuan = 4600307202,

    [Display(Name = "��¡����Сѧ")]
    xingLongZhongXinXiaoXue = 4600307203,

    [Display(Name = "��������Сѧ")]
    xinZhongZhongXinXiaoXue = 4600307204,

    [Display(Name = "������������ѧ���в�")]
    wanNingShiMinZuZhongXueChuZhongBu = 4600307206,

    [Display(Name = "������������ѧ���в�")]
    wanNingShiMinZuZhongXueGaoZhongBu = 4600307207,
    //�Ͳ�
    [Display(Name = "����ѧУ�����У�")]
    wuPoXueXiaoChuZhong = 4600310201,

    [Display(Name = "��ľѧУ�����У�")]
    fengMuXueXiaoChuZhong = 4600310202,

    [Display(Name = "�Ͳ�����������������Сѧ")]
    tunChangXianXinXingZhenXinXingZhongXinXiaoXue = 4600310203,

    [Display(Name = "�Ͳ����׶�԰")]
    tunChangXianYouErYuan = 4600310104,

    [Display(Name = "�Ͳ����ͳ��������׶�԰")]
    tunChangXianTunChengZhenZhongXinYouErYuan = 4600310105,

    [Display(Name = "����ʦ��һ�����Ͳ�˼Դʵ��ѧУ�����У�")]
    huaZhongShiDaYiFuZhongTunChangSiYuanShiYanXueXiaoGaoZhong = 4600310106,

    [Display(Name = "�Ͳ��ط�ľ���ľ����Сѧ")]
    tunChangXianFengMuZhenFengMuZhongXinXiaoXue = 4600310207,
    //��ָɽ
    [Display(Name = "��ָɽ�μ��׶�԰")]
    wuZhiShanJiaJiaYouErYuan = 4600304101,

    [Display(Name = "��ָɽ���׶�԰")]
    wuZhiShanShiYouErYuan = 4600304102,

    [Display(Name = "��ָɽ˼ԴѧУ�����У�")]
    wuZhiShanSiYuanXueXiaoChuZhong = 4600304103,

    [Display(Name = "��ָɽ��ѧ�����У�")]
    wuZhiShanZhongXueChuZhong = 4600304104,

    [Display(Name = "��ָɽ�е���Сѧ")]
    wuZhiShanShiDiSanXiaoXue = 4600304105,

    [Display(Name = "��ָɽ�е�һСѧ")]
    wuZhiShanShiDiYiXiaoXue = 4600304106,

    [Display(Name = "��ָɽ��ѧ�����У�")]
    wuZhiShanZhongXueGaoZhong = 4600304107,
    //����
    [Display(Name = "��������ѧУ��Сѧ��")]
    dongHeZhongXinXueXiaoXiaoXue = 4600308201,

    [Display(Name = "���ũ������ѧУ��Сѧ��")]
    guangBaNongChangZhongXinXueXiaoXiaoXue = 4600308202,

    [Display(Name = "������ѧ�����У�")]
    daTianZhongXueChuZhong = 4600308203,

    [Display(Name = "�г���ѧ�����У�")]
    ganChengZhongXueChuZhong = 4600308204,

    [Display(Name = "������ѧ���в�")]
    qiongXiZhongXueGaoZhongBu = 4600308105,

    [Display(Name = "�������׶�԰")]
    dongFangShiYouErYuan = 4600308106,

    [Display(Name = "�г��������׶�԰")]
    ganChengZhenZhongXinYouErYuan = 4600308207,
    //��ˮ
    [Display(Name = "��ˮ�ػ����׶�԰")]
    lingShuiXianJiGuanYouErYuan = 4600316101,

    [Display(Name = "����������ѧ�����У�")]
    dongHuaChuJiZhongXueChuZhong = 4600316102,

    [Display(Name = "��ˮ������ѧ�����У�")]
    lingShuiMinZuZhongXueChuZhong = 4600316103,

    [Display(Name = "Ҭ�ֵ�һСѧ")]
    yeLinDiYiXiaoXue = 4600316104,

    [Display(Name = "��������Сѧ")]
    wenLuoZhongXinXiaoXue = 4600316205,

    [Display(Name = "��԰���׶�԰")]
    taoYuanCunYouErYuan = 4600316106,

    [Display(Name = "��ˮ������ѧ�����У�")]
    lingShuiMinZuZhongXueGaoZhong = 4600316107,
    //��
    [Display(Name = "�λ���������Сѧ�׶�԰")]
    jiaJiZhenZhongXinXiaoXueYouErYuan = 4600305101,

    [Display(Name = "ʵ���׶�԰")]
    shiYanYouErYuan = 4600305102,

    [Display(Name = "��Ȫ������Сѧ")]
    wanQuanZhenZhongXinXiaoXue = 4600305203,

    [Display(Name = "��Ȫ��ѧ�����У�")]
    wanQuanZhongXueChuZhong = 4600305204,

    [Display(Name = "��ԭ������Сѧ")]
    zhongYuanZhenZhongXinXiaoXue = 4600305205,

    [Display(Name = "��������ѧ�����У�")]
    qiongHaiHuaQiaoZhongXueChuZhong = 4600305206,

    [Display(Name = "��������ѧ�����У�")]
    qiongHaiHuaQiaoZhongXueGaoZhong = 4600305207,
    //�Ĳ�
    [Display(Name = "�Ĳ�����ұ���ѧ�����У�")]
    wenChangShiTianJiaBingZhongXueGaoZhong = 4600306101,

    [Display(Name = "�Ĳ����Ļ��׶�԰")]
    wenChangShiWenHuiYouErYuan = 4600306102,

    [Display(Name = "���������׶�԰")]
    huiWenZhongXinYouErYuan = 4600306203,

    [Display(Name = "��������Сѧ")]
    huiWenZhongXinXiaoXue = 4600306204,

    [Display(Name = "����������ѧ�����У�")]
    huiWenQiongWenZhongXueChuZhong = 4600306205,

    [Display(Name = "������ѧ��Сѧ��")]
    lianDongZhongXueXiaoXue = 4600306206,

    [Display(Name = "������ѧ�����У�")]
    lianDongZhongXueChuZhong = 4600306207,
    //����
    [Display(Name = "����������ѧУ��Сѧ��")]
    longHeZhenZhongXinXueXiaoXiaoXue = 4600309201,

    [Display(Name = "������ѧ�����У�")]
    longTangZhongXueChuZhong = 4600309202,

    [Display(Name = "�����������׶�԰")]
    longMenZhenZhongXinYouErYuan = 4600309203,

    [Display(Name = "����������ѧУ��Сѧ��")]
    leiMingZhenZhongXinXueXiaoXiaoXue = 4600309204,

    [Display(Name = "����������ѧ�����У�")]
    leiMingChuJiZhongXueChuZhong = 4600309205,

    [Display(Name = "�����������׶�԰")]
    leiMingZhenZhongXinYouErYuan = 4600309206,

    [Display(Name = "������ѧ�����У�")]
    chengNanZhongXueGaoZhong = 4600309107,
    //����
    [Display(Name = "��������Сѧ")]
    yongFaZhongXinXiaoXue = 4600311201,

    [Display(Name = "������ѧ(���У�")]
    wenRuZhongXueChuZhong = 4600311202,

    [Display(Name = "����ѧУ��Сѧ��")]
    kunLunXueXiaoXiaoXue = 4600311203,

    [Display(Name = "����ѧУ����ѧ�������У�")]
    kunLunXueXiaoZhongXueChuZhong = 4600311204,

    [Display(Name = "�����صڶ���ѧ�����У�")]
    chengMaiXianDiErZhongXueGaoZhong = 4600311105,

    [Display(Name = "����ͯ���׶�԰")]
    zhongXingTongXingYouErYuan = 4600311206,

    [Display(Name = "��ͷ�����׶�԰")]
    qiaoTouZhongXinYouErYuan = 4600311207,

    [Display(Name = "�����׶�԰")]
    daLaYouErYuan = 4600311208,
    //��ɳ
    [Display(Name = "�߷�������ѧУ��Сѧ��")]
    qiFangZhenZhongXinXueXiaoXiaoXue = 4600313201,

    [Display(Name = "�߷���ѧ�����У�")]
    qiFangZhongXueChuZhong = 4600313202,

    [Display(Name = "��Ϫ������ѧУ��Сѧ��")]
    bangXiZhenZhongXinXueXiaoXiaoXue = 4600313203,

    [Display(Name = "��Ϫ������ѧ�����У�")]
    bangXiChuJiZhongXueChuZhong = 4600313204,

    [Display(Name = "��ɳ��ѧ�����У�")]
    baiShaZhongXueGaoZhong = 4600313105,

    [Display(Name = "��Ϫ�������׶�԰")]
    bangXiZhenZhongXinYouErYuan = 4600313206,

    [Display(Name = "�߷��������׶�԰")]
    qiFangZhenZhongXinYouErYuan = 4600313207,

    [Display(Name = "���������׶�԰")]
    daAnZhenZhongXinYouErYuan = 4600313208,

    [Display(Name = "���������׶�԰")]
    daAnMengMengLeYouErYuan = 4600313209,

    [Display(Name = "Ԫ���������׶�԰")]
    yuanMenXiangZhongXinYouErYuan = 4600313210,
    //����
    [Display(Name = "ʯµ�������׶�԰")]
    shiLuZhenZhongXinYouErYuan = 4600314101,

    [Display(Name = "���׶�԰")]
    kuangJianYouErYuan = 4600314102,

    [Display(Name = "�Ѽ��׶�԰")]
    jiaJiaYouErYuan = 4600314103,

    [Display(Name = "˼Դʵ��ѧУ�����У�")]
    siYuanShiYanXueXiaoChuZhong = 4600314104,

    [Display(Name = "ʮ����ѧУ��Сѧ��")]
    shiYueTianXueXiaoXiaoXue = 4600314205,

    [Display(Name = "������ѧУ��Сѧ��")]
    wuLieZhenXueXiaoXiaoXue = 4600314206,

    [Display(Name = "������ѧУ�����У�")]
    wuLieZhenXueXiaoChuZhong = 4600314207,

    [Display(Name = "������ѧ�����У�")]
    changJiangZhongXueGaoZhong = 4600314108,
    //�ֶ�
    [Display(Name = "�����ֶ�˼Դʵ��߼���ѧ�����У�")]
    leDongSiYuanShiYanGaoJiZhongXue = 4600315101,

    [Display(Name = "�����������׶�԰")]
    jiuSuoZhenZhongXinYouErYuan = 4600315202,

    [Display(Name = "�ֶ��ػ����׶�԰")]
    leDongXianJiGuanYouErYuan = 4600315103,

    [Display(Name = "��������ѧУ��Сѧ��")]
    jiuSuoZhongXinXueXiaoXiaoXue = 4600315204,

    [Display(Name = "�������ѧУ��Сѧ��")]
    wanChongZhongXinXueXiaoXiaoXue = 4600315205,

    [Display(Name = "������ѧ�����У�")]
    jiuSuoZhongXueChuZhong = 4600315206,

    [Display(Name = "ǧ����ѧ�����У�")]
    qianJiaZhongXueChuZhong = 4600315207,
    //�ٸ�
    [Display(Name = "��ӯ����ѧУ��Сѧ��")]
    xinYingZhongXinXueXiaoXiaoXue = 4600319201,

    [Display(Name = "��������ѧУ��Сѧ��")]
    jiaLaiZhongXinXueXiaoXiaoXue = 4600319202,

    [Display(Name = "��̨��ѧ������ ��")]
    meiTaiZhongXueChuZhong = 4600319103,

    [Display(Name = "��ͩ��ѧ�����У�")]
    huangTongZhongXueChuZhong = 4600319204,

    [Display(Name = "��ӯ���׶�԰")]
    xinYingGangYouErYuan = 4600319205,

    [Display(Name = "Ӣ���׶�԰")]
    yingMiaoYouErYuan = 4600319206,

    [Display(Name = "�ٸ��صڶ���ѧ�����У�")]
    linGaoXianDiErZhongXueGaoZhong = 4600319107,
    //��ɳ��
    //����
    [Display(Name = "��ɳ����ѧУ���׶�԰��1-3�꼶��")]
    sanShaYongXingXueXiaoYouErYuan = 4612200101,

}