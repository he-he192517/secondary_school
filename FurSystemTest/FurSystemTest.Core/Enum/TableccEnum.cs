using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;

namespace FurSystemTest.Core
{
    public enum Gender_cc
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "男性")]
        Male = 1,

        [Display(Name = "女性")]
        Female = 2
    }

    public enum Whethe_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "否")]
        Yes = 1,
        [Display(Name = "是")]
        No = 2,
    }

    public enum Whether_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "是")]
        Yes = 1,
        [Display(Name = "否")]
        No = 2,
    }

    public enum Ethnicity_cc
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
        Uyghur = 7,
        [Display(Name = "其他")]
        Other = 8
    }

    public enum ConsumptionFrequenc_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "从来不")]
        Never = 1,

        [Display(Name = "少于每天1次")]
        LessThanOncePerDay = 2,

        [Display(Name = "每天1次及以上")]
        OncePerDayOrMore = 3,
    }

    public enum ConsumptionFrequen_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "天天吃")]
        Never = 1,

        [Display(Name = "有时吃")]
        LessThanOncePerDay = 2,

        [Display(Name = "从来不吃")]
        OncePerDayOrMore = 3,
    }

    public enum ConsumptionFrequency_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "从来不吃")]
        Never = 1,

        [Display(Name = "少于每天1次")]
        LessThanOncePerDay = 2,

        [Display(Name = "每天1次")]
        OncePerDayOrMore = 3,

        [Display(Name = "每天2次及以上")]
        twicePerDayOrMore = 3,
    }

    public enum FruitVariety_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "从来不吃或少于每天1种")]
        NeverOrLessThanOncePerDay = 1,

        [Display(Name = "每天1种")]
        OncePerDay = 2,

        [Display(Name = "每天2种")]
        TwicePerDay = 3,

        [Display(Name = "每天3种及以上")]
        ThreeOrMorePerDay = 4,
    }

    public enum HighIntensityExerciseFrequency_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "0天")]
        ZeroDays = 1,

        [Display(Name = "1天")]
        OneDay = 2,

        [Display(Name = "2天")]
        TwoDays = 3,

        [Display(Name = "3天")]
        ThreeDays = 4,

        [Display(Name = "4天")]
        FourDays = 5,

        [Display(Name = "5天")]
        FiveDays = 6,

        [Display(Name = "6天")]
        SixDays = 7,

        [Display(Name = "7天")]
        SevenDays = 8
    }

    public enum WeekendHolidayExerciseFrequency_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "都能做到")]
        CanDoEveryday = 1,

        [Display(Name = "多数能做到")]
        CanDoMostDays = 2,

        [Display(Name = "一半的日子能做到")]
        CanDoHalfOfTheDays = 3,

        [Display(Name = "少数能做到")]
        CanDoFewDays = 4,

        [Display(Name = "几乎做不到")]
        CanHardlyDo = 5
    }

    public enum Frequency_cc
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

    public enum SwimmingSafety_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "没有")]
        No = 1,

        [Display(Name = "有")]
        Yes = 2
    }

    public enum SelfHarmFrequency_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "0次")]
        ZeroTimes = 1,

        [Display(Name = "1次")]
        OneTime = 2,

        [Display(Name = "2~5次")]
        TwoToFiveTimes = 3,

        [Display(Name = "6次或以上")]
        SixOrMoreTimes = 4
    }

    public enum SmokingFrequency_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "过去30天里我没有吸过烟")]
        NotSmokedInPast30Days = 1,

        [Display(Name = "吸过，过去30天里吸过 天")]
        SmokedInPast30Days = 2
    }

    public enum DailyCigaretteConsumption_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "过去30天里我没有吸过烟")]
        NotSmokedInPast30Days = 1,

        [Display(Name = "不到1支")]
        LessThan1Cigarette = 2,

        [Display(Name = "每天1-10支")]
        OneToTenCigarettes = 3,

        [Display(Name = "每天11-20支")]
        ElevenToTwentyCigarettes = 4,

        [Display(Name = "每天超过20支")]
        MoreThanTwentyCigarettes = 5
    }

    public enum AlcoholConsumptionFrequency_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "我没有喝过酒或仅仅尝过几口")]
        NoneOrAFewSips = 1,

        [Display(Name = "1-9（含9）天")]
        OneToNineDays = 2,

        [Display(Name = "10-19（含19）天")]
        TenToNineteenDays = 3,

        [Display(Name = "20-29（含29）天")]
        TwentyToTwentyNineDays = 4,

        [Display(Name = "30天")]
        ThirtyDays = 5
    }

    public enum AlcoholConsumptionFrequenc_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "0天")]
        NoneOrAFewSips = 1,

        [Display(Name = "1-9（含9）天")]
        OneToNineDays = 2,

        [Display(Name = "10-19（含19）天")]
        TenToNineteenDays = 3,

        [Display(Name = "20-29（含29）天")]
        TwentyToTwentyNineDays = 4,

        [Display(Name = "30天")]
        ThirtyDays = 5
    }
    public enum AlcoholIntoxicationSymptoms_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "0次")]
        None = 1,

        [Display(Name = "1-2（含2）次")]
        OneToTwoTimes = 2,

        [Display(Name = "3-9（含9）次")]
        ThreeToNineTimes = 3,

        [Display(Name = "10次及以上")]
        TenTimesOrMore = 4
    }

    public enum CoughSyrupDosage_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "1. 60ml以下")]
        LessThan60ml = 1,

        [Display(Name = "2. 60ml～")]
        SixtyMlOrMore = 2,

        [Display(Name = "3. 一瓶")]
        OneBottle = 3,

        [Display(Name = "4. 一瓶以上")]
        MoreThanOneBottle = 4
    }

    public enum ActivityTime_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "我没有看过电视和用电脑")]
        None = 1,

        [Display(Name = "不到1小时")]
        LessThan1Hour = 2,

        [Display(Name = "1-2小时")]
        OneToTwoHours = 3,

        [Display(Name = "2-3小时")]
        TwoToThreeHours = 4,

        [Display(Name = "3-4小时")]
        ThreeToFourHours = 5,

        [Display(Name = "4小时及以上")]
        FourOrMoreHours = 6
    }

    public enum MobileDeviceTime_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "我没有用过")]
        None = 1,
        [Display(Name = "用过")]
        Used = 2
    }

    public enum OutdoorActivityTime_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "不到1小时")]
        LessThan1Hour = 1,
        [Display(Name = "1-2小时")]
        OneTo2Hours = 2,
        [Display(Name = "2-3小时")]
        TwoTo3Hours = 3,
        [Display(Name = "3小时及以上")]
        ThreeOrMoreHours = 4,
        [Display(Name = "不知道")]
        DonNotKnow = 5
    }

    public enum BackpackHabit_cc
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

    public enum BackpackWeight_cc
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

    public enum MattressFirmness_cc
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

    public enum ShoeSoleWear_cc
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

    public enum ShoeSoleInnerOuterWear_cc
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

    public enum PostureRequirement_cc
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

    public enum Frequencys_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Description("从不")]
        Never = 1,

        [Description("1-2次")]
        OnceOrTwice = 2,

        [Description("3-4次")]
        ThreeOrFourTimes = 3,

        [Description("5-6次")]
        FiveOrSixTimes = 4,

        [Description("每天1次")]
        OnceADay = 5,

        [Description("每天2次及以上")]
        TwiceOrMoreADay = 6
    }

    public enum HIVPreventionEducation_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "有")]
        Yes = 1,

        [Display(Name = "没有")]
        No = 2,

        [Display(Name = "不知道")]
        DonotKnow = 3
    }

    public enum SexualBehavior_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "无")]
        None = 1,

        [Display(Name = "和同性发生过")]
        SameSex = 2,

        [Display(Name = "和异性发生过")]
        OppositeSex = 3,

        [Display(Name = "既和同性也和异性发生过")]
        Both = 4
    }

    public enum AgeAtFirstSex_cc
    {
        [Display(Name = "请选择")]
        Null = 99,
        [Display(Name = "无")]
        None = 1,

        [Display(Name = "11岁或以下")]
        ElevenOrBelow = 2,

        [Display(Name = "12岁")]
        Twelve = 3,

        [Display(Name = "13岁")]
        Thirteen = 4,

        [Display(Name = "14岁")]
        Fourteen = 5,

        [Display(Name = "15岁")]
        Fifteen = 6,

        [Display(Name = "16岁")]
        Sixteen = 7,

        [Display(Name = "17岁")]
        Seventeen = 8,

        [Display(Name = "18岁及以上")]
        EighteenOrAbove = 9
    }

    public enum CondomUsageAtFirstSex_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "是")]
        Yes = 1,

        [Display(Name = "不是")]
        No = 2
    }

    public enum NumberOfSexualPartners_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "1人")]
        One = 1,

        [Display(Name = "2人及以上")]
        TwoOrMore = 2
    }

    public enum YesNo_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "有")]
        Yes = 1,

        [Display(Name = "没有")]
        No = 2
    }

    public enum Frequencysy_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "没有或偶尔（少于1天）")]
        NoneOrOccasional = 1,

        [Display(Name = "有时（1-2天）")]
        Sometimes = 2,

        [Display(Name = "时常或一半时间（3-4天）")]
        OftenOrHalfOfTheTime = 3,

        [Display(Name = "多数时间或持续（5-7天）")]
        MostOfTheTimeOrContinuous = 4
    }

    public enum k02_cc
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "30分钟以下")]
        NoneOrOccasional = 1,

        [Display(Name = "30分钟-60分钟")]
        Sometimes = 2,

        [Display(Name = "60分钟-120分钟")]
        OftenOrHalfOfTheTime = 3,

        [Display(Name = "120分钟-180分钟")]
        MostOfTheTimeOrContinuous = 4,

        [Display(Name = "180分钟以上")]
        OverMostOfTheTimeOrContinuous = 5
    }
}