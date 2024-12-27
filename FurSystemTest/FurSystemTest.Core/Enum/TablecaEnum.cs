﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Core
{
    public enum Gender_ca
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "男")]
        Man = 1,
        [Display(Name = "女")]
        Woman = 2,
    }

    public enum Whether_ca
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "是")]
        Yes = 1,
        [Display(Name = "否")]
        No = 2,
    }

    public enum Wheth_ca
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "是")]
        Yes = 1,
        [Display(Name = "否")]
        No = 2,
    }

    public enum Ethnicity_ca
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "汉族")]
        Han = 1,
        [Display(Name = "蒙古族")]
        Mongolian = 2,
        [Display(Name = "藏族")]
        Tibetan = 3,
        [Display(Name = "壮族")]
        Zhuang = 4,
        [Display(Name = "回族")]
        Hui = 5,
        [Display(Name = "满族")]
        Manchu = 6,
        [Display(Name = "维吾尔族")]
        Uighur = 7,
        [Display(Name = "其他")]
        Other = 8
    }

    public enum B01_ca
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "从来不喝")]
        One = 1,
        [Display(Name = "少于每天1次")]
        Two = 2,
        [Display(Name = "每天1次及以上")]
        Three = 3,
    }

    public enum B03_ca
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "从来不吃")]
        One = 1,
        [Display(Name = "少于每天1次")]
        Two = 2,
        [Display(Name = "每天1次及以上")]
        Three = 3,
    }

    public enum B04_ca
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "从来不吃")]
        One = 1,
        [Display(Name = "少于每天1次")]
        Two = 2,
        [Display(Name = "每天1次")]
        Three = 3,
        [Display(Name = "每天2次及以上")]
        four = 4,
    }

    public enum B041_ca
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "从来不吃或少于每天1种")]
        One = 1,
        [Display(Name = "每天1种")]
        Two = 2,
        [Display(Name = "每天2种")]
        Three = 3,
        [Display(Name = "每天3种及以上")]
        four = 4,
    }

    public enum B06_ca
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "天天吃")]
        One = 1,
        [Display(Name = "有时吃")]
        Two = 2,
        [Display(Name = "从来不吃")]
        Three = 3,

    }


    public enum q3_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "从不")]
        Never = 1,

        [Display(Name = "偶尔")]
        Occasionally = 2,

        [Display(Name = "经常")]
        Often = 3,

        [Display(Name = "总是")]
        Always = 4,

        [Display(Name = "从不看电视")]
        NeverUseComputer = 5
    }

    public enum Classes_ca
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "0节")]
        ZeroClasses = 0,

        [Display(Name = "1节")]
        OneClass = 1,

        [Display(Name = "2节")]
        TwoClasses = 2,

        [Display(Name = "3节")]
        ThreeClasses = 3,

        [Display(Name = "4节")]
        FourClasses = 4,

        [Display(Name = "5节及以上")]
        FiveOrMoreClasses = 5
    }

    public enum ExerciseDays_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "0天")]
        ZeroDays = 0,

        [Display(Name = "1天")]
        OneDay = 1,

        [Display(Name = "2天")]
        TwoDays = 2,

        [Display(Name = "3天")]
        ThreeDays = 3,

        [Display(Name = "4天")]
        FourDays = 4,

        [Display(Name = "5天")]
        FiveDays = 5,

        [Display(Name = "6天")]
        SixDays = 6,

        [Display(Name = "7天")]
        SevenDays = 7
    }

    public enum WeekendExercise_ca
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "都能做到")]
        CanAlwaysDo = 1,

        [Display(Name = "多数能做到")]
        CanMostlyDo = 2,

        [Display(Name = "一半的日子能做到")]
        CanHalfTheTime = 3,

        [Display(Name = "少数能做到")]
        CanOccasionallyDo = 4,

        [Display(Name = "几乎做不到")]
        CanHardlyDo = 5
    }

    public enum InjuryFrequency_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "从未")]
        Never = 1,

        [Display(Name = "有时")]
        Sometimes = 2,

        [Display(Name = "经常")]
        Often = 3
    }

    public enum BullyingDuration_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "1个月及以下")]
        LessThan1Month = 1,

        [Display(Name = "2月~")]
        TwoMonths = 2,

        [Display(Name = "3月~")]
        ThreeMonths = 3,

        [Display(Name = "6月~")]
        SixMonths = 4,

        [Display(Name = "12月及以上")]
        TwelveMonthsOrMore = 5,

        [Display(Name = "从未")]
        Never = 6
    }

    public enum E04_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "0次")]
        one1 = 1,

        [Display(Name = "1次~")]
        Twos = 2,

        [Display(Name = "2-5（含5）次")]
        Threes = 3,

        [Display(Name = "6次或以上")]
        Sixs = 4
    }

    public enum judgement_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "没有")]
        No = 1,

        [Display(Name = "有")]
        Yes = 2
    }

    public enum c2_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "30分钟以下")]
        LessThan30Minutes = 1,

        [Display(Name = "30分钟~")]
        ThirtyTo60Minutes = 2,

        [Display(Name = "60分钟~")]
        SixtyTo120Minutes = 3,

        [Display(Name = "120分钟~")]
        OneTwentyTo180Minutes = 4,

        [Display(Name = "180分钟以上")]
        MoreThan180Minutes = 5
    }


    public enum k3_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "从不")]
        NotSmokedInLast30Days = 1,

        [Display(Name = "1-2次")]
        LessThan1Cigarette = 2,

        [Display(Name = "3-4次")]
        OneToTenCigarettesPerDay = 3,

        [Display(Name = "5-6次")]
        ElevenToTwentyCigarettesPerDay = 4,

        [Display(Name = "每天1次")]
        MoreThanTwentyCigarettesPerDay = 5,

        [Display(Name = "每天2次及以上")]
        ThanTwentyCigarettesPerDay = 6
    }


    public enum a7_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "早晚刷牙")]
        morningandnight = 1,

        [Display(Name = "仅早晨刷牙")]
        moring = 2,

        [Display(Name = "仅晚上刷牙")]
        night = 3,

        [Display(Name = "偶尔或从不刷牙")]
        Occasionallyornever = 4
    }

    public enum Wh_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "是")]
        yes = 1,

        [Display(Name = "否")]
        no = 2,

        [Display(Name = "不知道")]
        unknow = 3
    }

    public enum ff2_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "有")]
        have = 1,

        [Display(Name = "都没有")]
        none = 2
    }


    public enum ft2_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "有")]
        Yes = 1,

        [Display(Name = "没有")]
        No = 2
    }

    public enum c5_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "每次都上课")]
        EveryTime = 1,

        [Display(Name = "多数会上课")]
        MostOfTheTime = 2,

        [Display(Name = "有时会上课")]
        Sometimes = 3,

        [Display(Name = "很少会上课")]
        Rarely = 4,

        [Display(Name = "不会上课")]
        Never = 5
    }

    public enum c6_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "吐在纸巾或手帕上")]
        SpitInTissueOrHandkerchief = 1,

        [Display(Name = "吐到痰盂、垃圾桶或厕所里")]
        SpitInSpittoonOrTrashCanOrToilet = 2,

        [Display(Name = "直接吐在地上")]
        SpitOnTheGround = 3,

        [Display(Name = "咽下")]
        Swallow = 4
    }

    public enum c7_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "不遮挡")]
        NoCover = 1,

        [Display(Name = "用手遮捂")]
        CoverWithHand = 2,

        [Display(Name = "用纸巾、手帕或衣袖遮挡")]
        CoverWithTissueHandkerchiefOrSleeve = 3
    }

    public enum c8_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "每次都洗")]
        AlwaysWash = 1,

        [Display(Name = "基本都洗")]
        MostlyWash = 2,

        [Display(Name = "有时洗有时不洗")]
        SometimesWashSometimesNot = 3,

        [Display(Name = "几乎不洗")]
        RarelyWash = 4,

        [Display(Name = "从来不洗")]
        NeverWash = 5
    }

    public enum cc1_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "从不（或仅个别人轮换）")]
        NeverOrOccasionally = 1,

        [Display(Name = "一学期一次")]
        OncePerSemester = 2,

        [Display(Name = "一个月一次")]
        OncePerMonth = 3,

        [Display(Name = "两周一次")]
        OncePerTwoWeeks = 4,

        [Display(Name = "每周一次")]
        OncePerWeek = 5
    }

    public enum cc2_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "从不或课桌椅不可调")]
        NeverOrNonAdjustable = 1,

        [Display(Name = "一学年一次")]
        OncePerYear = 2,

        [Display(Name = "一学期一次")]
        OncePerSemester = 3,

        [Display(Name = "两至三个月一次")]
        OncePerTwoToThreeMonths = 4
    }

    public enum cc3_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "1次")]
        Once = 1,

        [Display(Name = "2次")]
        Twice = 2,

        [Display(Name = "3次及以上")]
        ThreeOrMore = 3,

        [Display(Name = "在校不做")]
        NotDoingInSchool = 4
    }

    public enum cc4_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "教学楼内")]
        Indoors = 1,

        [Display(Name = "户外（如操场等）")]
        Outdoors = 2
    }

    public enum cc5_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "不到1小时")]
        LessThanOneHour = 1,

        [Display(Name = "1-2（不含2）小时")]
        OneToTwoHours = 2,

        [Display(Name = "2-3（不含3）小时")]
        TwoToThreeHours = 3,

        [Display(Name = "3小时及以上")]
        ThreeOrMoreHours = 4,

        [Display(Name = "不知道")]
        DoNotKnow = 5,

        [Display(Name = "没有作业")]
        NoHomework = 6
    }

    public enum cc6_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "不到1小时")]
        LessThanOneHour = 1,

        [Display(Name = "1-2（不含2）小时")]
        OneToTwoHours = 2,

        [Display(Name = "2-3（不含3）小时")]
        TwoToThreeHours = 3,

        [Display(Name = "3小时及以上")]
        ThreeOrMoreHours = 4,

        [Display(Name = "不知道")]
        DoNotKnow = 5,

        [Display(Name = "无补习班")]
        NoTuitionClass = 6
    }

    public enum cc7_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "3岁以前")]
        BeforeThreeYearsOld = 1,

        [Display(Name = "3岁")]
        ThreeYearsOld = 2,

        [Display(Name = "4岁")]
        FourYearsOld = 3,

        [Display(Name = "5岁")]
        FiveYearsOld = 4,

        [Display(Name = "6岁以后（含6岁)")]
        AfterSixYearsOld = 5,

        [Display(Name = "从来没参加过")]
        NeverParticipated = 6
    }

    public enum cc8_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "经常")]
        Often = 1,

        [Display(Name = "有时")]
        Sometimes = 2,

        [Display(Name = "没有")]
        Never = 3
    }

    public enum t_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "从不")]
        Never = 1,

        [Display(Name = "偶尔")]
        Occasionally = 2,

        [Display(Name = "经常")]
        Often = 3,

        [Display(Name = "总是")]
        Always = 4
    }

    public enum q1_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "同时使用台灯和屋顶灯")]
        BothTableLampAndCeilingLight = 1,

        [Display(Name = "仅使用台灯")]
        OnlyTableLamp = 2,

        [Display(Name = "仅使用屋顶灯")]
        OnlyCeilingLight = 3,

        [Display(Name = "其他")]
        Other = 4
    }

    public enum q2_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "从不")]
        Never = 1,

        [Display(Name = "偶尔")]
        Occasionally = 2,

        [Display(Name = "经常")]
        Often = 3,

        [Display(Name = "总是")]
        Always = 4,

        [Display(Name = "从不用电脑")]
        NeverUseComputer = 5
    }

    public enum q4_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "15分钟及以内")]
        LessThan15Minutes = 1,

        [Display(Name = "超过15分钟，但不到0.5小时")]
        Between15MinutesAnd30Minutes = 2,

        [Display(Name = "0.5-1（不含1）小时")]
        Between30MinutesAnd1Hour = 3,

        [Display(Name = "1-2（不含2）小时")]
        Between1And2Hours = 4,

        [Display(Name = "2-3（不含3）小时")]
        Between2And3Hours = 5,

        [Display(Name = "3小时及以上")]
        MoreThan3Hours = 6
    }





    public enum cc0_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "我没有看过")]
        NeverSeen = 1,

        [Display(Name = "不到1小时")]
        LessThanOneHour = 2,

        [Display(Name = "1-2（不含2）小时")]
        OneToTwoHours = 3,

        [Display(Name = "2-3（不含3）小时")]
        TwoToThreeHours = 4,

        [Display(Name = "3-4（不含4）小时")]
        ThreeToFourHours = 5,

        [Display(Name = "4小时及以上")]
        FourOrMoreHours = 6
    }

    public enum ccc8_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "我没有用过")]
        NeverUsed = 1,

        [Display(Name = "用过")]
        Used = 2
    }

    public enum ccc7_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "我没有看（玩）过")]
        NeverSeenOrPlayed = 1,

        [Display(Name = "用过")]
        Used = 2
    }

    public enum ttt_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "只有父亲近视")]
        OnlyFatherMyopia = 1,

        [Display(Name = "只有母亲近视")]
        OnlyMotherMyopia = 2,

        [Display(Name = "父母都近视")]
        BothParentsMyopia = 3,

        [Display(Name = "父母都不近视")]
        NeitherParentMyopia = 4
    }

    public enum a1_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "0次")]
        ZeroTimes = 1,

        [Display(Name = "1次")]
        OneTime = 2,

        [Display(Name = "2次")]
        TwoTimes = 3,

        [Display(Name = "3次")]
        ThreeTimes = 4,

        [Display(Name = "4次及以上")]
        FourOrMoreTimes = 5
    }

    public enum a5_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "一直佩戴")]
        AlwaysWearing = 1,

        [Display(Name = "有时佩戴")]
        SometimesWearing = 2,

        [Display(Name = "不佩戴")]
        NotWearing = 3
    }

    public enum a6_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "验光")]
        Optometry = 1,

        [Display(Name = "散瞳")]
        Mydriasis = 2,

        [Display(Name = "验光和散瞳")]
        BothOptometryAndMydriasis = 3,

        [Display(Name = "都没有")]
        None = 4
    }

    //g
    public enum cm9_ca
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "不到1小时")]
        LessThan1Hour = 1,

        [Display(Name = "1-2（不含2）小时")]
        Between1And2Hours = 2,

        [Display(Name = "2-3（不含3）小时")]
        Between2And3Hours = 3,

        [Display(Name = "3小时及以上")]
        MoreThan3Hours = 4,

        [Display(Name = "不知道")]
        Unknown = 5
    }

    public enum w1_ca
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "双肩包背胸前")]
        DoubleStrapFront = 1,

        [Display(Name = "双肩包背背后")]
        DoubleStrapBack = 2,

        [Display(Name = "双肩包背在一侧")]
        DoubleStrapOneSide = 3,

        [Display(Name = "背单肩包")]
        SingleStrap = 4,

        [Display(Name = "使用带轮书包")]
        WheeledBackpack = 5
    }

    public enum w2_ca
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "很轻")]
        VeryLight = 1,

        [Display(Name = "较轻")]
        Light = 2,

        [Display(Name = "中等")]
        Medium = 3,

        [Display(Name = "较重")]
        Heavy = 4,

        [Display(Name = "很重")]
        VeryHeavy = 5,

        [Display(Name = "没感觉")]
        NoFeeling = 6
    }

    public enum w4_ca
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "偏软")]
        Soft = 1,

        [Display(Name = "适中")]
        Medium = 2,

        [Display(Name = "偏硬")]
        Firm = 3
    }

    public enum w5_ca
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "没有差别")]
        NoDifference = 1,

        [Display(Name = "左脚磨损严重")]
        LeftFootHeavyWear = 2,

        [Display(Name = "右脚磨损严重")]
        RightFootHeavyWear = 3
    }

    public enum w6_ca
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "没有")]
        NoWear = 1,

        [Display(Name = "内侧磨损严重")]
        InnerSoleHeavyWear = 2,

        [Display(Name = "外侧磨损严重")]
        OuterSoleHeavyWear = 3
    }

    public enum w7_ca
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "无所谓，舒服就行")]
        NoPreference = 1,

        [Display(Name = "还好，有时会监督自己一下")]
        OkayWithSomeMonitoring = 2,

        [Display(Name = "时常会提醒自己")]
        FrequentSelfReminders = 3,

        [Display(Name = "时刻保持良好的姿势")]
        AlwaysMaintainGoodPosture = 4
    }
}
