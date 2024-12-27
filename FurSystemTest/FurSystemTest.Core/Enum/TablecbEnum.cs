using System.ComponentModel.DataAnnotations;

namespace FurSystemTest.Core
{
    public enum Gender_cb
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "男")]
        Man = 1,
        [Display(Name = "女")]
        Woman = 2,
    }

    public enum ft2_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "有")]
        Yes = 1,

        [Display(Name = "没有")]
        No = 2
    }
    public enum Whether_cb
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "是")]
        Yes = 1,
        [Display(Name = "否")]
        No = 2,
    }

    public enum Ethnicity_cb
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

    public enum B01_cb
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

    public enum B03_cb
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

    public enum B06_cb
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

    public enum Classes_cb
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

    public enum ExerciseDays_cb
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

    public enum WeekendExercise_cb
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

    public enum InjuryFrequency_cb
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

    public enum BullyingDuration_cb
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

    public enum judgement_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "没有")]
        No = 1,

        [Display(Name = "有")]
        Yes = 2
    }

    public enum SmokingStatusLast30Days_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "过去30天里我没有吸过烟")]
        NotSmokedInLast30Days = 1,

        [Display(Name = "吸过，过去30天里吸过烟")]
        SmokedInLast30Days = 2
    }

    public enum SmokingFrequencyLast30Days_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "过去30天里我没有吸过烟")]
        NotSmokedInLast30Days = 1,

        [Display(Name = "不到1支")]
        LessThan1Cigarette = 2,

        [Display(Name = "每天1-10（含10）支")]
        OneToTenCigarettesPerDay = 3,

        [Display(Name = "每天11-20（含20）支")]
        ElevenToTwentyCigarettesPerDay = 4,

        [Display(Name = "每天超过20支")]
        MoreThanTwentyCigarettesPerDay = 5
    }

    public enum CoughSyrupUsage_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "60ml以下")]
        LessThan60ml = 1,

        [Display(Name = "60ml～")]
        SixtyMlOrMore = 2,

        [Display(Name = "一瓶")]
        OneBottle = 3,

        [Display(Name = "一瓶以上")]
        MoreThanOneBottle = 4
    }

    public enum YesNoEnum_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "否")]
        no = 1,

        [Display(Name = "是")]
        yes = 2,
    }

    public enum TimeRangeEnum_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "30分钟以下")]
        LessThanThirtyMinutes = 1,

        [Display(Name = "30分钟~")]
        MoreThanThirtyMinutes = 2,

        [Display(Name = "60分钟~")]
        MoreThanSixtyMinutes = 3,

        [Display(Name = "120分钟~")]
        MoreThanOneHundredTwenty = 4,

        [Display(Name = "180分钟以上")]
        MoreThanOneHundredEighty = 5,
    }

    public enum FrequencyEnum_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "从不")]
        never = 1,

        [Display(Name = "1-2次")]
        onetotwo = 2,

        [Display(Name = "3-4次")]
        threetofour = 3,

        [Display(Name = "5-6次")]
        fivetosix = 4,

        [Display(Name = "每天1次")]
        Onceaday = 5,

        [Display(Name = "每天2次及以上")]
        Twiceaday = 6
    }

    public enum ToothBrushingFrequency_cb
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

    public enum YesNoUnknown_cb
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

    public enum HaveOrNone_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "有")]
        have = 1,

        [Display(Name = "都没有")]
        none = 2
    }

    public enum ClassAttendance_cb
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

    public enum SpittingBehavior_cb
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

    public enum CoughEtiquette_cb
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

    public enum WashingFrequency_cb
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

    public enum HaveOrNot_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "有")]
        Have = 1,

        [Display(Name = "没有")]
        Not = 2,

        [Display(Name = "不知道")]
        Unknow = 3
    }

    public enum Frequency_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "从不（或仅个别人轮换）")]
        NeverOrRarely = 1,

        [Display(Name = "一学期一次")]
        OncePerSemester = 2,

        [Display(Name = "一个月一次")]
        OncePerMonth = 3,

        [Display(Name = "两周一次")]
        OncePerFortnight = 4,

        [Display(Name = "每周一次")]
        OncePerWeek = 5
    }

    public enum Frequency1_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "从不或课桌椅不可调")]
        NeverOrDeskChairNotAdjustable = 1,

        [Display(Name = "一学年一次")]
        OncePerSchoolYear = 2,

        [Display(Name = "一学期一次")]
        OncePerSemester = 3,

        [Display(Name = "两至三个月一次")]
        OnceEveryTwoToThreeMonths = 4
    }

    public enum Frequency2_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "1次")]
        Once = 1,

        [Display(Name = "2次")]
        Twice = 2,

        [Display(Name = "3次及以上")]
        ThreeOrMoreTimes = 3,

        [Display(Name = "在校不做")]
        NotAtSchool = 4
    }

    public enum Frequency3_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "教学楼内")]
        Once = 1,

        [Display(Name = "户外（如操场等）")]
        Twice = 2,
    }

    public enum Frequency4_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "不到1小时")]
        LessThan1Hour = 1,

        [Display(Name = "1-2（不含2）小时")]
        OneToTwoHours = 2,

        [Display(Name = "2-3（不含3）小时")]
        TwoToThreeHours = 3,

        [Display(Name = "3小时及以上")]
        ThreeOrMoreHours = 4,

        [Display(Name = "不知道")]
        DonNotKnow = 5,

        [Display(Name = "没有作业")]
        NoHomework = 6
    }

    public enum Frequency5_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "不到1小时")]
        LessThan1Hour = 1,

        [Display(Name = "1-2（不含2）小时")]
        OneToTwoHours = 2,

        [Display(Name = "2-3（不含3）小时")]
        TwoToThreeHours = 3,

        [Display(Name = "3小时及以上")]
        ThreeOrMoreHours = 4,

        [Display(Name = "不知道")]
        DonNotKnow = 5,

        [Display(Name = "无补习班")]
        NoCramSchool = 6
    }

    public enum Frequency6_cb
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

    public enum Frequency7_cb
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


    public enum AgeGroup_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "3岁以前")]
        Before3YearsOld = 1,

        [Display(Name = "3岁")]
        ThreeYearsOld = 2,

        [Display(Name = "4岁")]
        FourYearsOld = 3,

        [Display(Name = "5岁")]
        FiveYearsOld = 4,

        [Display(Name = "6岁以后（含6岁)")]
        SixOrMoreYearsOld = 5,

        [Display(Name = "从来没参加过")]
        NeverParticipated = 6
    }

    public enum ViewingDuration_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "我没有看过")]
        NotWatched = 1,

        [Display(Name = "不到1小时")]
        LessThan1Hour = 2,

        [Display(Name = "1-2（不含2）小时")]
        OneToTwoHours = 3,

        [Display(Name = "2-3（不含3）小时")]
        TwoToThreeHours = 4,

        [Display(Name = "3-4（不含4）小时")]
        ThreeToFourHours = 5,

        [Display(Name = "4小时及以上")]
        FourOrMoreHours = 6
    }

    public enum UsageDuration_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "我没有用过")]
        NotUsed = 1,

        [Display(Name = "不到1小时")]
        LessThan1Hour = 2,

        [Display(Name = "1-2（不含2）小时")]
        OneToTwoHours = 3,

        [Display(Name = "2-3（不含3）小时")]
        TwoToThreeHours = 4,

        [Display(Name = "3-4（不含4）小时")]
        ThreeToFourHours = 5,

        [Display(Name = "4小时及以上")]
        FourOrMoreHours = 6
    }

    public enum UsageStatus_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "我没有用过")]
        NotUsed = 1,

        [Display(Name = "用过")]
        Used = 2
    }

    public enum UsageStatu_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "我没有看（玩）过")]
        NotUsed = 1,

        [Display(Name = "用过")]
        Used = 2
    }

    public enum LightingOption_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "同时使用台灯和屋顶灯")]
        BothDeskAndCeiling = 1,

        [Display(Name = "仅使用台灯")]
        OnlyDesk = 2,

        [Display(Name = "仅使用屋顶灯")]
        OnlyCeiling = 3,

        [Display(Name = "其他")]
        Other = 4
    }

    public enum Frequency8_cb
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

    public enum Frequency9_cb
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

        [Display(Name = "从不用电视")]
        NeverUseComputer = 5
    }

    public enum Duration_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "15分钟及以内")]
        LessThan15Minutes = 1,

        [Display(Name = "超过15分钟，但不到0.5小时")]
        Over15MinutesButLessThan30Minutes = 2,

        [Display(Name = "0.5-1（不含1）小时")]
        HalfTo1HourButLessThan1Hour = 3,

        [Display(Name = "1-2（不含2）小时")]
        OneTo2HoursButLessThan2Hours = 4,

        [Display(Name = "2-3（不含3）小时")]
        TwoTo3HoursButLessThan3Hours = 5,

        [Display(Name = "3小时及以上")]
        ThreeOrMoreHours = 6
    }
    public enum Duration1_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "不到1小时")]
        LessThan1Hour = 1,

        [Display(Name = "1-2（不含2）小时")]
        OneToTwoHours = 2,

        [Display(Name = "2-3（不含3）小时")]
        TwoToThreeHours = 3,

        [Display(Name = "3小时及以上")]
        ThreeOrMoreHours = 4,

        [Display(Name = "不知道")]
        DonNotKnow = 5
    }
    public enum VisionStatus_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "只有父亲近视")]
        OnlyFatherShortSighted = 1,

        [Display(Name = "只有母亲近视")]
        OnlyMotherShortSighted = 2,

        [Display(Name = "父母都近视")]
        BothParentsShortSighted = 3,

        [Display(Name = "父母都不近视")]
        NeitherParentShortSighted = 4
    }
    public enum number_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "0次")]
        ZeroTimes = 1,

        [Display(Name = "1次")]
        Once = 2,

        [Display(Name = "2次")]
        Twice = 3,

        [Display(Name = "3次")]
        ThreeTimes = 4,

        [Display(Name = "4次及以上")]
        FourOrMoreTimes = 5
    }

    public enum EyewearStatus_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "一直佩戴")]
        AlwaysWear = 1,

        [Display(Name = "有时佩戴")]
        SometimesWear = 2,

        [Display(Name = "不佩戴")]
        NeverWear = 3
    }

    public enum EyeExamination_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "验光")]
        Refraction = 1,

        [Display(Name = "散瞳（散瞳治疗后，你在太亮的地方会睁不开眼）")]
        DilatedPupil = 2,

        [Display(Name = "验光和散瞳")]
        RefractionAndDilatedPupil = 3,

        [Display(Name = "都没有")]
        None = 4
    }

    public enum Frequencysy_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "没有或偶尔（少于1天）")]
        RarelyOrNever = 1,

        [Display(Name = "有时（1-2天）")]
        Sometimes = 2,

        [Display(Name = "时常或一半时间（3-4天）")]
        OftenOrHalfTime = 3,

        [Display(Name = "多数时间或持续（5-7天）")]
        MostTimeOrContinuously = 4
    }


    public enum BackpackUsage_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "双肩包背胸前")]
        TwoShoulderFront = 1,

        [Display(Name = "双肩包背背后")]
        TwoShoulderBack = 2,

        [Display(Name = "双肩包背在一侧")]
        TwoShoulderSide = 3,

        [Display(Name = "背单肩包")]
        SingleShoulder = 4,

        [Display(Name = "使用带轮书包")]
        WheeledBackpack = 5
    }

    public enum WeightPerception_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "很轻")]
        VeryLight = 1,

        [Display(Name = "较轻")]
        Light = 2,

        [Display(Name = "中等")]
        Moderate = 3,

        [Display(Name = "较重")]
        Heavy = 4,

        [Display(Name = "很重")]
        VeryHeavy = 5,

        [Display(Name = "没感觉")]
        NoFeeling = 6
    }

    public enum MattressFirmness_cb
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

    public enum FootWearPattern_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "没有差别")]
        NoDifference = 1,

        [Display(Name = "左脚磨损严重")]
        LeftFootWorn = 2,

        [Display(Name = "右脚磨损严重")]
        RightFootWorn = 3
    }

    public enum ShoeWearPattern_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "没有")]
        None = 1,

        [Display(Name = "内侧磨损严重")]
        InnerWorn = 2,

        [Display(Name = "外侧磨损严重")]
        OuterWorn = 3
    }

    public enum PostureHabit_cb
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "无所谓，舒服就行")]
        NoPreference = 1,

        [Display(Name = "还好，有时会监督自己一下")]
        OkaySometimesMonitor = 2,

        [Display(Name = "时常会提醒自己")]
        OftenRemindMyself = 3,

        [Display(Name = "时刻保持良好的姿势")]
        AlwaysMaintainGoodPosture = 4
    }
}
