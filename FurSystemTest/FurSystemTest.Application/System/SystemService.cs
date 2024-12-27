using FurSystemTest.Core;

namespace FurSystemTest.Application;

public class SystemService : ISystemService, IDynamicApiController, ITransient
{
    private readonly ISqlSugarClient _db = DbContext.Instance;
    public string CreateDatabase()
    {
        //建库：如果不存在创建数据库存在不会重复创建 
        _db.DbMaintenance.CreateDatabase(); // 注意 ：Oracle和个别国产库需不支持该方法，需要手动建库 


        //创建基础表：根据实体类Test  (所有数据库都支持)    
        _db.CodeFirst.InitTables(typeof(User));//这样一个表就能成功创建了
        _db.CodeFirst.InitTables(typeof(Role));
        _db.CodeFirst.InitTables(typeof(UserRole));
        _db.CodeFirst.InitTables(typeof(Security));
        _db.CodeFirst.InitTables(typeof(RoleSecurity));

        //写入初始数据seedData-User
        if (_db.Queryable<User>().Count() < 1)
        {
            //向Test表中插入初始数据集
            //_db.Insertable<User>(UserSeed()).ExecuteCommand();
        }
        else
        {
            _db.DbMaintenance.TruncateTable<User>();
            //_db.Insertable<User>(UserSeed()).ExecuteCommand();
        }

        //写入初始数据seedData-Role
        if (_db.Queryable<Role>().Count() < 1)
        {
            //向Test表中插入初始数据集
            //_db.Insertable<Role>(RoleSeed()).ExecuteCommand();
        }
        else
        {
            _db.DbMaintenance.TruncateTable<Role>();
            //_db.Insertable<Role>(RoleSeed()).ExecuteCommand();
        }


        //写入初始数据seedData-UserRole
        if (_db.Queryable<UserRole>().Count() < 1)
        {
            //向Test表中插入初始数据集
            //_db.Insertable<UserRole>(UserRoleSeed()).ExecuteCommand();
        }
        else
        {
            _db.DbMaintenance.TruncateTable<UserRole>();
            //_db.Insertable<UserRole>(UserRoleSeed()).ExecuteCommand();
        }


        return "OK";
    }


    ////向User表中插入的数据List<User>
    //private static List<User> UserSeed()
    //{
    //    var users = new List<User>()
    //     {
    //         new User(){UserId=0, Account="Admin",Password="12345",Name="超级管理员",Code="46",Level=1,Status=1},
    //         new User(){UserId=1, Account="User1",Password="12345",Name="管理员",Code="46",Level=2,Status=1},
    //         new User(){UserId=2,Account="User2",Password="12345",Name = "用户",Code="46",Level=3,Status=1},
    //         new User() { UserId=3, Name = "海南省", Code = "46",Password="12345", Level = 1, Status = 1, Account = "hn" },
    //         new User() { UserId=4, Name = "三亚市", Code = "4602",Password="12345", Level = 2, Status = 1, Account = "sys" },
    //         new User() { UserId=5, Name = "吉阳区", Code = "4602261",Password="12345", Level = 3, Status = 1, Account = "jyq" },
    //         new User() { UserId=6, Name = "瑞海蒙氏幼儿园", Code = "4602261101",Password="12345", Level = 3, Status = 1, Account = "rhmsry" },
    //         new User() { UserId=7, Name = "三亚市第二小学", Code = "4602261102",Password="12345", Level = 3, Status = 1, Account = "sysdexx" },
    //         new User() { UserId=8, Name = "三亚丰和学校(丹州校区)", Code = "4602261104",Password="12345", Level = 3, Status = 1, Account = "syfhxx" },
    //         new User() { UserId=9, Name = "三亚技师学校", Code = "4602261105",Password="12345", Level = 3, Status = 1, Account = "syjsxx" },
    //         new User() { UserId=10, Name = "三亚学院", Code = "4602261106",Password="12345", Level = 3, Status = 1, Account = "syxy" },
    //         new User() { UserId=11, Name = "天涯区", Code = "4602262",Password="12345", Level = 3, Status = 1, Account = "tyq" },
    //         new User() { UserId=12, Name = "三亚丰和学校(育新校区)", Code = "4602262103",Password="12345", Level = 3, Status = 1, Account = "syfhxx" },
    //         new User() { UserId=13, Name = "东方明珠幼儿园", Code = "4602262107",Password="12345", Level = 3, Status = 1, Account = "dfmzyry" },
    //         new User() { UserId=14, Name = "三亚市第四小学", Code = "4602262108",Password="12345", Level = 3, Status = 1, Account = "sydsxx" },
    //         new User() { UserId=15, Name = "三亚市凤凰中学(初中)", Code = "4602262209",Password="12345", Level = 3, Status = 1, Account = "syfhzx" },
    //         new User() { UserId=16, Name = "三亚市第二中学(初中)", Code = "4602262110",Password="12345", Level = 3, Status = 1, Account = "sydexx" },
    //         new User() { UserId=17, Name = "三亚市第二中学(高中)", Code = "4602262111",Password="12345", Level = 3, Status = 1, Account = "sydexx" },
    //         new User() { UserId=18, Name = "崖州区", Code = "4602263",Password="12345", Level = 3, Status = 1, Account = "yzq" },
    //         new User() { UserId=19, Name = "崖州湾科技城第一幼儿园", Code = "4602263212",Password="12345", Level = 3, Status = 1, Account = "yzwkjcdy" },
    //         new User() { UserId=20, Name = "三亚市崖城小学", Code = "4602263213",Password="12345", Level = 3, Status = 1, Account = "sysycxx" },
    //         new User() { UserId=21, Name = "田家炳高级中学(高中)", Code = "4602263214",Password="12345", Level = 3, Status = 1, Account = "tjbgjzx" },
    //         new User() { UserId=22, Name = "海棠区", Code = "4602264",Password="12345", Level = 3, Status = 1, Account = "htq" },
    //         new User() { UserId=23, Name = "海棠区第二幼儿园", Code = "4602264215",Password="12345", Level = 3, Status = 1, Account = "htqdeyry" },
    //         new User() { UserId=24, Name = "海棠区第一小学", Code = "4602264216",Password="12345", Level = 3, Status = 1, Account = "htqdyxx" },
    //         new User() { UserId=25, Name = "中国人民大学附属中学三亚学校(初中)", Code = "4602264217",Password="12345", Level = 3, Status = 1, Account = "zgrmdxfszxsyxx" },
    //         new User() { UserId=26, Name = "海口市", Code = "4601",Password="12345", Level = 1, Status = 1, Account = "hks" },
    //         new User() { UserId=27, Name = "秀英区", Code = "4601151",Password="12345", Level = 3, Status = 1, Account = "xyq" },
    //         new User() { UserId=28, Name = "旅游职业学校", Code = "4601151101",Password="12345", Level = 3, Status = 1, Account = "lyzyxx" },
    //         new User() { UserId=29, Name = "海口海港学校(高中)", Code = "4601151107",Password="12345", Level = 3, Status = 1, Account = "hkhgxx" },
    //         new User() { UserId=30, Name = "西秀镇拔南小学(丰盈小学)", Code = "4601151206",Password="12345", Level = 3, Status = 1, Account = "xxzbnxx" },
    //         new User() { UserId=31, Name = "东山中学(初中)", Code = "4601151210",Password="12345", Level = 3, Status = 1, Account = "dszx" },
    //         new User() { UserId=32, Name = "西秀镇中心幼儿园", Code = "4601151216",Password="12345", Level = 3, Status = 1, Account = "xxzxyry" },
    //         new User() { UserId=33, Name = "琼山区", Code = "4601153",Password="12345", Level = 3, Status = 1, Account = "qsq" },
    //         new User() { UserId=34, Name = "海口市琼山中学(初中)", Code = "4601153105",Password="12345", Level = 3, Status = 1, Account = "hksqszx" },
    //         new User() { UserId=35, Name = "海南海政学校", Code = "4601153114",Password="12345", Level = 3, Status = 1, Account = "hnhzxx" },
    //         new User() { UserId=36, Name = "云龙镇中心小学", Code = "4601153215",Password="12345", Level = 3, Status = 1, Account = "ylzzxxx" },
    //         new User() { UserId=37, Name = "海口市琼山幼儿园", Code = "4601153109",Password="12345", Level = 3, Status = 1, Account = "hksqsyyy" },
    //         new User() { UserId=38, Name = "海南师范大学", Code = "4601153117",Password="12345", Level = 3, Status = 1, Account = "hnsfdx" },
    //         new User() { UserId=39, Name = "龙华区", Code = "4601152",Password="12345", Level = 3, Status = 1, Account = "lhq" },
    //         new User() { UserId=40, Name = "市机关幼儿园", Code = "4601152111",Password="12345", Level = 3, Status = 1, Account = "sjgyry" },
    //         new User() { UserId=41, Name = "滨海小学", Code = "4601152112",Password="12345", Level = 3, Status = 1, Account = "bhxx" },
    //         new User() { UserId=42, Name = "海南侨中观澜湖学校(高中)", Code = "4601152218",Password="12345", Level = 3, Status = 1, Account = "hnqzglhxxgzb" },
    //         new User() { UserId=43, Name = "新坡中学(初中)", Code = "4601152213",Password="12345", Level = 3, Status = 1, Account = "xpzxcz" },
    //         new User() { UserId=44, Name = "美兰区", Code = "4601154",Password="12345", Level = 3, Status = 1, Account = "mlq" },
    //         new User() { UserId=45, Name = "灵山镇中心幼儿园", Code = "4601154202",Password="12345", Level = 3, Status = 1, Account = "lszzxyry" },
    //         new User() { UserId=46, Name = "海联中学(初中)", Code = "4601154103",Password="12345", Level = 3, Status = 1, Account = "hlzx" },
    //         new User() { UserId=47, Name = "美苑小学", Code = "4601154104",Password="12345", Level = 3, Status = 1, Account = "myxx" },
    //         new User() { UserId=48, Name = "海口市灵山中学(高中)", Code = "4601154208",Password="12345", Level = 3, Status = 1, Account = "hkslszxgzb" },
    //         new User() { UserId=49, Name = "儋州市", Code = "4603",Password="12345", Level = 1, Status = 1, Account = "dzs" },
    //         new User() { UserId=50, Name = "儋州市", Code = "4603271",Password="12345", Level = 3, Status = 1, Account = "dzs" },
    //         new User() { UserId=51, Name = "中国热带农业科学院幼儿园", Code = "4603271101",Password="12345", Level = 3, Status = 1, Account = "zgrdnykxyyry" },
    //         new User() { UserId=52, Name = "儋州市农垦那大机械厂幼儿园", Code = "4603271102",Password="12345", Level = 3, Status = 1, Account = "dzsnkndjxcny" },
    //         new User() { UserId=53, Name = "儋州市两院小学", Code = "4603271103",Password="12345", Level = 3, Status = 1, Account = "dzseyxx" },
    //         new User() { UserId=54, Name = "那大实验学校(四小)", Code = "4603271104",Password="12345", Level = 3, Status = 1, Account = "ndsyxxsx" },
    //         new User() { UserId=55, Name = "儋州市两院中学(初中)", Code = "4603271105",Password="12345", Level = 3, Status = 1, Account = "dzslyzxcz" },
    //         new User() { UserId=56, Name = "儋州市第一中学(初中)", Code = "4603271106",Password="12345", Level = 3, Status = 1, Account = "dzsdyzxcz" },
    //         new User() { UserId=57, Name = "儋州市民族中学(高中)", Code = "4603271107",Password="12345", Level = 3, Status = 1, Account = "dzsmzzxgzb" },
    //         new User() { UserId=58, Name = "儋州市第二中学(高中)", Code = "4603271108",Password="12345", Level = 3, Status = 1, Account = "dzsdezxgzb" },
    //         new User() { UserId=59, Name = "儋州市中等职业技术学校", Code = "4603271109",Password="12345", Level = 3, Status = 1, Account = "dzszdzzyjsx" },
    //         new User() { UserId=60, Name = "海南大学儋州校区", Code = "4603271110",Password="12345", Level = 3, Status = 1, Account = "hndxdzxq" },
    //         new User() { UserId=61, Name = "东成镇中心幼儿园", Code = "4603271211",Password="12345", Level = 3, Status = 1, Account = "dczzxyry" },
    //         new User() { UserId=62, Name = "那大镇中心幼儿园", Code = "4603271112",Password="12345", Level = 3, Status = 1, Account = "ndzzxyry" },
    //         new User() { UserId=63, Name = "洋浦第二幼儿园", Code = "4603271213",Password="12345", Level = 3, Status = 1, Account = "ypdeyry" },
    //         new User() { UserId=64, Name = "洋浦第一小学", Code = "4603271215",Password="12345", Level = 3, Status = 1, Account = "ypdyxx" },
    //         new User() { UserId=65, Name = "大成中心学校", Code = "4603271216",Password="12345", Level = 3, Status = 1, Account = "dczxxxyx" },
    //         new User() { UserId=66, Name = "八一中学(初中)", Code = "4603271217",Password="12345", Level = 3, Status = 1, Account = "byzxcz" },
    //         new User() { UserId=67, Name = "洋浦中学(初中)", Code = "4603271218",Password="12345", Level = 3, Status = 1, Account = "ypzxcz" },
    //         new User() { UserId=68, Name = "长坡中学(高中)", Code = "4603271219",Password="12345", Level = 3, Status = 1, Account = "cpzxgz" },
    //         new User() { UserId=69, Name = "兰洋镇中心幼儿园", Code = "4603271220",Password="12345", Level = 3, Status = 1, Account = "lyzzxyry" },
    //         new User() { UserId=70, Name = "保亭", Code = "4600317",Password="12345", Level = 2, Status = 1, Account = "bt" },
    //         new User() { UserId=71, Name = "保亭县第二小学", Code = "4600317101",Password="12345", Level = 3, Status = 1, Account = "btxdexx" },
    //         new User() { UserId=72, Name = "什玲镇中心学校", Code = "4600317202",Password="12345", Level = 3, Status = 1, Account = "slzzxxx" },
    //         new User() { UserId=73, Name = "保亭春晖幼儿园", Code = "4600317103",Password="12345", Level = 3, Status = 1, Account = "btchyry" },
    //         new User() { UserId=74, Name = "保城镇幼儿园", Code = "4600317104",Password="12345", Level = 3, Status = 1, Account = "bczyry" },
    //         new User() { UserId=75, Name = "保亭中学", Code = "4600317105",Password="12345", Level = 3, Status = 1, Account = "btzx" },
    //         new User() { UserId=76, Name = "响水镇金江学校", Code = "4600317206",Password="12345", Level = 3, Status = 1, Account = "xszjjxx" },
    //         new User() { UserId=77, Name = "海之南实验学校", Code = "4600317207",Password="12345", Level = 3, Status = 1, Account = "hznsyxx" },
    //         new User() { UserId=78, Name = "琼中", Code = "4600318",Password="12345", Level = 2, Status = 1, Account = "qz" },
    //         new User() { UserId=79, Name = "乌石学校(小学)", Code = "4600318201",Password="12345", Level = 3, Status = 1, Account = "wsxx" },
    //         new User() { UserId=80, Name = "乌石学校(初中)", Code = "4600318202",Password="12345", Level = 3, Status = 1, Account = "wscz" },
    //         new User() { UserId=81, Name = "阳江学校(小学)", Code = "4600318203",Password="12345", Level = 3, Status = 1, Account = "yjxx" },
    //         new User() { UserId=82, Name = "阳江学校(初中)", Code = "4600318204",Password="12345", Level = 3, Status = 1, Account = "yjcz" },
    //         new User() { UserId=83, Name = "智博幼儿园", Code = "4600318205",Password="12345", Level = 3, Status = 1, Account = "zbyey" },
    //         new User() { UserId=84, Name = "新宝贝幼儿园", Code = "4600318206",Password="12345", Level = 3, Status = 1, Account = "xbyey" },
    //         new User() { UserId=85, Name = "琼中县幼儿园", Code = "4600318107",Password="12345", Level = 3, Status = 1, Account = "qzxyey" },
    //         new User() { UserId=86, Name = "琼中中学(高中)", Code = "4600318108",Password="12345", Level = 3, Status = 1, Account = "qzzxzgzb" },
    //         new User() { UserId=87, Name = "万宁市", Code = "4600307",Password="12345", Level = 2, Status = 1, Account = "wns" },
    //         new User() { UserId=88, Name = "万宁市幼儿园", Code = "4600307101",Password="12345", Level = 3, Status = 1, Account = "wnsyey" },
    //         new User() { UserId=89, Name = "万城镇中学(初中)", Code = "4600307105",Password="12345", Level = 3, Status = 1, Account = "wczzxcz" },
    //         new User() { UserId=90, Name = "三更罗幼儿园", Code = "4600307202",Password="12345", Level = 3, Status = 1, Account = "sglyey" },
    //         new User() { UserId=91, Name = "兴隆中心小学", Code = "4600307203",Password="12345", Level = 3, Status = 1, Account = "xlzxxxyx" },
    //         new User() { UserId=92, Name = "新中中心小学", Code = "4600307204",Password="12345", Level = 3, Status = 1, Account = "xzzxxxyx" },
    //         new User() { UserId=93, Name = "万宁市民族中学初中部", Code = "4600307206",Password="12345", Level = 3, Status = 1, Account = "wnsmzzxczb" },
    //         new User() { UserId=94, Name = "万宁市民族中学高中部", Code = "4600307207",Password="12345", Level = 3, Status = 1, Account = "wnsmzzxgzb" },
    //         new User() { UserId=95, Name = "屯昌", Code = "4600310",Password="12345", Level = 2, Status = 1, Account = "tc" },
    //         new User() { UserId=96, Name = "乌坡学校(初中)", Code = "4600310201",Password="12345", Level = 3, Status = 1, Account = "wpxxcz" },
    //         new User() { UserId=97, Name = "枫木学校(初中)", Code = "4600310202",Password="12345", Level = 3, Status = 1, Account = "fmxxcz" },
    //         new User() { UserId=98, Name = "屯昌县新兴镇新兴中心小学", Code = "4600310203",Password="12345", Level = 3, Status = 1, Account = "tcxxzxzxxxyx" },
    //         new User() { UserId=99, Name = "屯昌县幼儿园", Code = "4600310104",Password="12345", Level = 3, Status = 1, Account = "tcxyey" },
    //         new User() { UserId=100, Name = "屯昌县屯城镇中心幼儿园", Code = "4600310105",Password="12345", Level = 3, Status = 1, Account = "tcxtczzxyey" },
    //         new User() { UserId=101, Name = "华中师大一附中屯昌思源实验学校(高中)", Code = "4600310106",Password="12345", Level = 3, Status = 1, Account = "hzsdyfztcsysyxxgzb" },
    //         new User() { UserId=102, Name = "屯昌县枫木镇枫木中心小学", Code = "4600310207",Password="12345", Level = 3, Status = 1, Account = "tcxfmzfmzxxx" },
    //         new User() { UserId=103, Name = "五指山", Code = "4600304",Password="12345", Level = 2, Status = 1, Account = "wzs" },
    //         new User() { UserId=104, Name = "五指山嘉佳幼儿园", Code = "4600304101",Password="12345", Level = 3, Status = 1, Account = "wzsjjyey" },
    //         new User() { UserId=105, Name = "五指山市幼儿园", Code = "4600304102",Password="12345", Level = 3, Status = 1, Account = "wzssyey" },
    //         new User() { UserId=106, Name = "五指山思源学校(初中)", Code = "4600304103",Password="12345", Level = 3, Status = 1, Account = "wzssyxxcz" },
    //         new User() { UserId=107, Name = "五指山中学(初中)", Code = "4600304104",Password="12345", Level = 3, Status = 1, Account = "wzszxcz" },
    //         new User() { UserId=108, Name = "五指山市第三小学", Code = "4600304105",Password="12345", Level = 3, Status = 1, Account = "wzsdsxx" },
    //         new User() { UserId=109, Name = "五指山市第一小学", Code = "4600304106",Password="12345", Level = 3, Status = 1, Account = "wzssdyxx" },
    //         new User() { UserId=110, Name = "五指山中学(高中)", Code = "4600304107",Password="12345", Level = 3, Status = 1, Account = "wzszxgz" },
    //         new User() { UserId=111, Name = "东方", Code = "4600308",Password="12345", Level = 2, Status = 1, Account = "df" },
    //         new User() { UserId=112, Name = "东河中心学校(小学)", Code = "4600308201",Password="12345", Level = 3, Status = 1, Account = "dhzxxxxx" },
    //         new User() { UserId=113, Name = "广坝农场中心学校(小学)", Code = "4600308202",Password="12345", Level = 3, Status = 1, Account = "gbnczxxx" },
    //         new User() { UserId=114, Name = "大田中学(初中)", Code = "4600308203",Password="12345", Level = 3, Status = 1, Account = "dtzxcz" },
    //         new User() { UserId=115, Name = "感城中学(初中)", Code = "4600308204",Password="12345", Level = 3, Status = 1, Account = "gczxxcz" },
    //         new User() { UserId=116, Name = "琼西中学高中部", Code = "4600308105",Password="12345", Level = 3, Status = 1, Account = "qxzxgzb" },
    //         new User() { UserId=117, Name = "东方市幼儿园", Code = "4600308106",Password="12345", Level = 3, Status = 1, Account = "dfsyey" },
    //         new User() { UserId=118, Name = "感城镇中心幼儿园", Code = "4600308207",Password="12345", Level = 3, Status = 1, Account = "gczzzxyey" },
    //         new User() { UserId=119, Name = "陵水", Code = "4600316",Password="12345", Level = 2, Status = 1, Account = "ls" },
    //         new User() { UserId=120, Name = "陵水县机关幼儿园", Code = "4600316101",Password="12345", Level = 3, Status = 1, Account = "lsxjgyey" },
    //         new User() { UserId=121, Name = "东华初级中学(初中)", Code = "4600316102",Password="12345", Level = 3, Status = 1, Account = "dhcjzx" },
    //         new User() { UserId=122, Name = "陵水民族中学(初中)", Code = "4600316103",Password="12345", Level = 3, Status = 1, Account = "lsmzzxcz" },
    //         new User() { UserId=123, Name = "椰林第一小学", Code = "4600316104",Password="12345", Level = 3, Status = 1, Account = "yldyxx" },
    //         new User() { UserId=124, Name = "文罗中心小学", Code = "4600316205",Password="12345", Level = 3, Status = 1, Account = "wlzxx" },
    //         new User() { UserId=125, Name = "桃园村幼儿园", Code = "4600316106",Password="12345", Level = 3, Status = 1, Account = "tycyey" },
    //         new User() { UserId=126, Name = "陵水民族中学(高中)", Code = "4600316107",Password="12345", Level = 3, Status = 1, Account = "lsmzxgz" },
    //         new User() { UserId=127, Name = "琼海", Code = "4600305",Password="12345", Level = 2, Status = 1, Account = "qh" },
    //         new User() { UserId=128, Name = "嘉积镇镇中心小学幼儿园", Code = "4600305101",Password="12345", Level = 3, Status = 1, Account = "jjzzzxxxyey" },
    //         new User() { UserId=129, Name = "实验幼儿园", Code = "4600305102",Password="12345", Level = 3, Status = 1, Account = "syyey" },
    //         new User() { UserId=130, Name = "万泉镇中心小学", Code = "4600305203",Password="12345", Level = 3, Status = 1, Account = "wqzxxxyx" },
    //         new User() { UserId=131, Name = "万泉中学(初中)", Code = "4600305204",Password="12345", Level = 3, Status = 1, Account = "wqzzcz" },
    //         new User() { UserId=132, Name = "中原镇中心小学", Code = "4600305205",Password="12345", Level = 3, Status = 1, Account = "zyzzxxx" },
    //         new User() { UserId=133, Name = "琼海华侨中学(初中)", Code = "4600305206",Password="12345", Level = 3, Status = 1, Account = "qhhqzxcz" },
    //         new User() { UserId=134, Name = "琼海华侨中学(高中)", Code = "4600305207",Password="12345", Level = 3, Status = 1, Account = "qhhqzxgz" },
    //         new User() { UserId=135, Name = "文昌", Code = "4600306",Password="12345", Level = 2, Status = 1, Account = "wc" },
    //         new User() { UserId=136, Name = "文昌市田家炳中学(高中)", Code = "4600306101",Password="12345", Level = 3, Status = 1, Account = "wcstjbzx" },
    //         new User() { UserId=137, Name = "文昌市文汇幼儿园", Code = "4600306102",Password="12345", Level = 3, Status = 1, Account = "wcswhyey" },
    //         new User() { UserId=138, Name = "会文中心幼儿园", Code = "4600306203",Password="12345", Level = 3, Status = 1, Account = "hwzxyey" },
    //         new User() { UserId=139, Name = "会文中心小学", Code = "4600306204",Password="12345", Level = 3, Status = 1, Account = "hwzxxx" },
    //         new User() { UserId=140, Name = "会文琼文中学(初中)", Code = "4600306205",Password="12345", Level = 3, Status = 1, Account = "hwqwzcz" },
    //         new User() { UserId=141, Name = "联东中学(小学)", Code = "4600306206",Password="12345", Level = 3, Status = 1, Account = "ldzxxx" },
    //         new User() { UserId=142, Name = "联东中学(初中)", Code = "4600306207",Password="12345", Level = 3, Status = 1, Account = "ldzxcz" },
    //         new User() { UserId=143, Name = "定安", Code = "4600309",Password="12345", Level = 2, Status = 1, Account = "da" },
    //         new User() { UserId=144, Name = "龙河镇中心学校(小学)", Code = "4600309201",Password="12345", Level = 3, Status = 1, Account = "lhzzxxxyx" },
    //         new User() { UserId=145, Name = "龙塘中学(初中)", Code = "4600309202",Password="12345", Level = 3, Status = 1, Account = "ltzxcz" },
    //         new User() { UserId=146, Name = "龙门镇中心幼儿园", Code = "4600309203",Password="12345", Level = 3, Status = 1, Account = "lmzxyey" },
    //         new User() { UserId=147, Name = "雷鸣镇中心学校(小学)", Code = "4600309204",Password="12345", Level = 3, Status = 1, Account = "lmzzxxxyx" },
    //         new User() { UserId=148, Name = "雷鸣初级中学(初中)", Code = "4600309205",Password="12345", Level = 3, Status = 1, Account = "lmcjzzcz" },
    //         new User() { UserId=149, Name = "雷鸣镇中心幼儿园", Code = "4600309206",Password="12345", Level = 3, Status = 1, Account = "lmzzxyey" },
    //         new User() { UserId=150, Name = "城南中学(高中)", Code = "4600309107",Password="12345", Level = 3, Status = 1, Account = "cnzxgz" },
    //         new User() { UserId=151, Name = "澄迈", Code = "4600311",Password="12345", Level = 2, Status = 1, Account = "cm" },
    //         new User() { UserId=152, Name = "永发中心小学", Code = "4600311201",Password="12345", Level = 3, Status = 1, Account = "yfzxxx" },
    //         new User() { UserId=153, Name = "文儒中学(初中)", Code = "4600311202",Password="12345", Level = 3, Status = 1, Account = "wrzzxcz" },
    //         new User() { UserId=154, Name = "昆仑学校(小学)", Code = "4600311203",Password="12345", Level = 3, Status = 1, Account = "klxx" },
    //         new User() { UserId=155, Name = "昆仑学校(中学)(初中)", Code = "4600311204",Password="12345", Level = 3, Status = 1, Account = "klxxcz" },
    //         new User() { UserId=156, Name = "澄迈县第二中学(高中)", Code = "4600311105",Password="12345", Level = 3, Status = 1, Account = "cmxedezxgzb" },
    //         new User() { UserId=157, Name = "中兴童星幼儿园", Code = "4600311206",Password="12345", Level = 3, Status = 1, Account = "zxtxyey" },
    //         new User() { UserId=158, Name = "桥头中心幼儿园", Code = "4600311207",Password="12345", Level = 3, Status = 1, Account = "qtxzyey" },
    //         new User() { UserId=159, Name = "大拉幼儿园", Code = "4600311208",Password="12345", Level = 3, Status = 1, Account = "dlyey" },
    //         new User() { UserId=160, Name = "白沙", Code = "4600313",Password="12345", Level = 2, Status = 1, Account = "bs" },
    //         new User() { UserId=161, Name = "七坊镇中心学校(小学)", Code = "4600313201",Password="12345", Level = 3, Status = 1, Account = "qfzxxx" },
    //         new User() { UserId=162, Name = "七坊中学(初中)", Code = "4600313202",Password="12345", Level = 3, Status = 1, Account = "qfzxcz" },
    //         new User() { UserId=163, Name = "邦溪镇中心学校(小学)", Code = "4600313203",Password="12345", Level = 3, Status = 1, Account = "bxzzxxx" },
    //         new User() { UserId=164, Name = "邦溪初级中学(初中)", Code = "4600313204",Password="12345", Level = 3, Status = 1, Account = "bxcjzx" },
    //         new User() { UserId=165, Name = "白沙中学(高中)", Code = "4600313105",Password="12345", Level = 3, Status = 1, Account = "bszx" },
    //         new User() { UserId=166, Name = "邦溪镇中心幼儿园", Code = "4600313206",Password="12345", Level = 3, Status = 1, Account = "bxyzxyey" },
    //         new User() { UserId=167, Name = "七坊镇中心幼儿园", Code = "4600313207",Password="12345", Level = 3, Status = 1, Account = "qfzzxyey" },
    //         new User() { UserId=168, Name = "打安镇中心幼儿园", Code = "4600313208",Password="12345", Level = 3, Status = 1, Account = "dazzxyey" },
    //         new User() { UserId=169, Name = "打安萌萌乐幼儿园", Code = "4600313209",Password="12345", Level = 3, Status = 1, Account = "dammlyey" },
    //         new User() { UserId=170, Name = "元门乡中心幼儿园", Code = "4600313210",Password="12345", Level = 3, Status = 1, Account = "ymxzyey" },
    //         new User() { UserId=171, Name = "昌江", Code = "4600314",Password="12345", Level = 2, Status = 1, Account = "cj" },
    //         new User() { UserId=172, Name = "石碌镇中心幼儿园", Code = "4600314101",Password="12345", Level = 3, Status = 1, Account = "slzzxyey" },
    //         new User() { UserId=173, Name = "矿建幼儿园", Code = "4600314102",Password="12345", Level = 3, Status = 1, Account = "kjyey" },
    //         new User() { UserId=174, Name = "佳佳幼儿园", Code = "4600314103",Password="12345", Level = 3, Status = 1, Account = "jjyey" },
    //         new User() { UserId=175, Name = "思源实验学校(初中)", Code = "4600314104",Password="12345", Level = 3, Status = 1, Account = "sysyxxcz" },
    //         new User() { UserId=176, Name = "十月田学校(小学)", Code = "4600314205",Password="12345", Level = 3, Status = 1, Account = "sytxxxx" },
    //         new User() { UserId=178, Name = "乌烈镇学校(小学)", Code = "4600314206",Password="12345", Level = 3, Status = 1, Account = "wlzxx" },
    //         new User() { UserId=179, Name = "乌烈镇学校(初中)", Code = "4600314207",Password="12345", Level = 3, Status = 1, Account = "wlzxcz" },
    //         new User() { UserId=180, Name = "昌江中学(高中)", Code = "4600314108",Password="12345", Level = 3, Status = 1, Account = "cjzxgz" },
    //         new User() { UserId=181, Name = "乐东", Code = "4600315",Password="12345", Level = 2, Status = 1, Account = "ld" },
    //         new User() { UserId=182, Name = "海南乐东思源实验高级中学(高中)", Code = "4600315101",Password="12345", Level = 3, Status = 1, Account = "hnldsysygjzx" },
    //         new User() { UserId=183, Name = "九所镇中心幼儿园", Code = "4600315202",Password="12345", Level = 3, Status = 1, Account = "jszzxyry" },
    //         new User() { UserId=184, Name = "乐东县机关幼儿园", Code = "4600315103",Password="12345", Level = 3, Status = 1, Account = "ldxjgyry" },
    //         new User() { UserId=185, Name = "九所中心学校(小学)", Code = "4600315204",Password="12345", Level = 3, Status = 1, Account = "jszxxx" },
    //         new User() { UserId=186, Name = "万冲中心学校(小学)", Code = "4600315205",Password="12345", Level = 3, Status = 1, Account = "wczxxx" },
    //         new User() { UserId=187, Name = "九所中学(初中)", Code = "4600315206",Password="12345", Level = 3, Status = 1, Account = "jszxcz" },
    //         new User() { UserId=188, Name = "千家中学(初中)", Code = "4600315207",Password="12345", Level = 3, Status = 1, Account = "qjzx" },
    //         new User() { UserId=189, Name = "临高", Code = "4600319",Password="12345", Level = 2, Status = 1, Account = "lg" },
    //         new User() { UserId=190, Name = "新盈中心学校(小学)", Code = "4600319201",Password="12345", Level = 3, Status = 1, Account = "xyzxxx" },
    //         new User() { UserId=191, Name = "加来中心学校(小学)", Code = "4600319202",Password="12345", Level = 3, Status = 1, Account = "jlzxxx" },
    //         new User() { UserId=192, Name = "美台中学(初中 )", Code = "4600319103",Password="12345", Level = 3, Status = 1, Account = "mtcz" },
    //         new User() { UserId=193, Name = "皇桐中学(初中)", Code = "4600319204",Password="12345", Level = 3, Status = 1, Account = "htzx" },
    //         new User() { UserId=194, Name = "新盈港幼儿园", Code = "4600319205",Password="12345", Level = 3, Status = 1, Account = "xygyey" },
    //         new User() { UserId=195, Name = "英苗幼儿园", Code = "4600319206",Password="12345", Level = 3, Status = 1, Account = "ymyey" },
    //         new User() { UserId=196, Name = "临高县第二中学(高中)", Code = "4600319107",Password="12345", Level = 3, Status = 1, Account = "lgxdezx" },
    //         new User() { UserId=197, Name = "三沙市", Code = "4612",Password="12345", Level = 2, Status = 1, Account = "sss" },
    //         new User() { UserId=198, Name = "永兴", Code = "4612200",Password="12345", Level = 2, Status = 1, Account = "yx" },
    //         new User() { UserId=199, Name = "三沙永兴学校(幼儿园和1-3年级)", Code = "4612200101",Password="12345", Level = 3, Status = 1, Account = "ssyxx" }

         //};
        //return users;
    //}
    //向Role表中插入的数据List<Role>
    private static List<Role> RoleSeed()
    {
        var roles = new List<Role>()
            {
                new Role(){RoleId=1, Name="SysAdmin",Remark="系统管理员"},
                new Role(){RoleId=2, Name="DataAdmin",Remark="市级管理员"},
                new Role(){RoleId=3, Name="SysUser",Remark="学校"}

            };
        return roles;
    }

    //向RUserRole表中插入的数据List<UserRole>
    private static List<UserRole> UserRoleSeed()
    {
        var userroles = new List<UserRole>()
            {
                new UserRole(){UserId=0, RoleId=1},
                new UserRole(){UserId=1, RoleId=2},
                new UserRole(){UserId=2, RoleId=3},
                new UserRole(){UserId=3, RoleId=1},
                new UserRole(){UserId=4, RoleId=2},
                new UserRole(){UserId=5, RoleId=3},
                new UserRole(){UserId=6, RoleId=3},
                new UserRole(){UserId=7, RoleId=3},
                new UserRole(){UserId=8, RoleId=3},
                new UserRole(){UserId=9, RoleId=3},
                new UserRole(){UserId=10, RoleId=3},
                new UserRole(){UserId=11, RoleId=3},
                new UserRole(){UserId=12, RoleId=3},
                new UserRole(){UserId=13, RoleId=3},
                new UserRole(){UserId=14, RoleId=3},
                new UserRole(){UserId=15, RoleId=3},
                new UserRole(){UserId=16, RoleId=3},
                new UserRole(){UserId=17, RoleId=3},
                new UserRole(){UserId=18, RoleId=3},
                new UserRole(){UserId=19, RoleId=3},
                new UserRole(){UserId=20, RoleId=3},
                new UserRole(){UserId=21, RoleId=3},
                new UserRole(){UserId=22, RoleId=3},
                new UserRole(){UserId=23, RoleId=3},
                new UserRole(){UserId=24, RoleId=3},
                new UserRole(){UserId=25, RoleId=3},
                new UserRole(){UserId=26, RoleId=1},
                new UserRole(){UserId=27, RoleId=3},
                new UserRole(){UserId=28, RoleId=3},
                new UserRole(){UserId=29, RoleId=3},
                new UserRole(){UserId=30, RoleId=3},
                new UserRole(){UserId=31, RoleId=3},
                new UserRole(){UserId=32, RoleId=3},
                new UserRole(){UserId=33, RoleId=3},
                new UserRole(){UserId=34, RoleId=3},
                new UserRole(){UserId=35, RoleId=3},
                new UserRole(){UserId=36, RoleId=3},
                new UserRole(){UserId=37, RoleId=3},
                new UserRole(){UserId=38, RoleId=3},
                new UserRole(){UserId=39, RoleId=3},
                new UserRole(){UserId=40, RoleId=3},
                new UserRole(){UserId=41, RoleId=3},
                new UserRole(){UserId=42, RoleId=3},
                new UserRole(){UserId=43, RoleId=3},
                new UserRole(){UserId=44, RoleId=3},
                new UserRole(){UserId=45, RoleId=3},
                new UserRole(){UserId=46, RoleId=3},
                new UserRole(){UserId=47, RoleId=3},
                new UserRole(){UserId=48, RoleId=3},
                new UserRole(){UserId=49, RoleId=1},
                new UserRole(){UserId=50, RoleId=3},
                new UserRole(){UserId=51, RoleId=3},
                new UserRole(){UserId=52, RoleId=3},
                new UserRole(){UserId=53, RoleId=3},
                new UserRole(){UserId=54, RoleId=3},
                new UserRole(){UserId=55, RoleId=3},
                new UserRole(){UserId=56, RoleId=3},
                new UserRole(){UserId=57, RoleId=3},
                new UserRole(){UserId=58, RoleId=3},
                new UserRole(){UserId=59, RoleId=3},
                new UserRole(){UserId=60, RoleId=3},
                new UserRole(){UserId=61, RoleId=3},
                new UserRole(){UserId=62, RoleId=3},
                new UserRole(){UserId=63, RoleId=3},
                new UserRole(){UserId=64, RoleId=3},
                new UserRole(){UserId=65, RoleId=3},
                new UserRole(){UserId=66, RoleId=3},
                new UserRole(){UserId=67, RoleId=3},
                new UserRole(){UserId=68, RoleId=3},
                new UserRole(){UserId=69, RoleId=3},
                new UserRole(){UserId=70, RoleId=2},
                new UserRole(){UserId=71, RoleId=3},
                new UserRole(){UserId=72, RoleId=3},
                new UserRole(){UserId=73, RoleId=3},
                new UserRole(){UserId=74, RoleId=3},
                new UserRole(){UserId=75, RoleId=3},
                new UserRole(){UserId=76, RoleId=3},
                new UserRole(){UserId=77, RoleId=3},
                new UserRole(){UserId=78, RoleId=2},
                new UserRole(){UserId=79, RoleId=3},
                new UserRole(){UserId=80, RoleId=3},
                new UserRole(){UserId=81, RoleId=3},
                new UserRole(){UserId=82, RoleId=3},
                new UserRole(){UserId=83, RoleId=3},
                new UserRole(){UserId=84, RoleId=3},
                new UserRole(){UserId=85, RoleId=3},
                new UserRole(){UserId=86, RoleId=3},
                new UserRole(){UserId=87, RoleId=2},
                new UserRole(){UserId=88, RoleId=3},
                new UserRole(){UserId=89, RoleId=3},
                new UserRole(){UserId=90, RoleId=3},
                new UserRole(){UserId=91, RoleId=3},
                new UserRole(){UserId=92, RoleId=3},
                new UserRole(){UserId=93, RoleId=3},
                new UserRole(){UserId=94, RoleId=3},
                new UserRole(){UserId=95, RoleId=2},
                new UserRole(){UserId=96, RoleId=3},
                new UserRole(){UserId=97, RoleId=3},
                new UserRole(){UserId=98, RoleId=3},
                new UserRole(){UserId=99, RoleId=3},
                new UserRole(){UserId=100, RoleId=3},
                new UserRole(){UserId=101, RoleId=3},
                new UserRole(){UserId=102, RoleId=3},
                new UserRole(){UserId=103, RoleId=2},
                new UserRole(){UserId=104, RoleId=3},
                new UserRole(){UserId=105, RoleId=3},
                new UserRole(){UserId=106, RoleId=3},
                new UserRole(){UserId=107, RoleId=3},
                new UserRole(){UserId=108, RoleId=3},
                new UserRole(){UserId=109, RoleId=3},
                new UserRole(){UserId=110, RoleId=3},
                new UserRole(){UserId=111, RoleId=2},
                new UserRole(){UserId=112, RoleId=3},
                new UserRole(){UserId=113, RoleId=3},
                new UserRole(){UserId=114, RoleId=3},
                new UserRole(){UserId=115, RoleId=3},
                new UserRole(){UserId=116, RoleId=3},
                new UserRole(){UserId=117, RoleId=3},
                new UserRole(){UserId=118, RoleId=3},
                new UserRole(){UserId=119, RoleId=2},
                new UserRole(){UserId=120, RoleId=3},
                new UserRole(){UserId=121, RoleId=3},
                new UserRole(){UserId=122, RoleId=3},
                new UserRole(){UserId=123, RoleId=3},
                new UserRole(){UserId=124, RoleId=3},
                new UserRole(){UserId=125, RoleId=3},
                new UserRole(){UserId=126, RoleId=3},
                new UserRole(){UserId=127, RoleId=2},
                new UserRole(){UserId=128, RoleId=3},
                new UserRole(){UserId=129, RoleId=3},
                new UserRole(){UserId=130, RoleId=3},
                new UserRole(){UserId=131, RoleId=3},
                new UserRole(){UserId=132, RoleId=3},
                new UserRole(){UserId=133, RoleId=3},
                new UserRole(){UserId=134, RoleId=3},
                new UserRole(){UserId=135, RoleId=2},
                new UserRole(){UserId=136, RoleId=3},
                new UserRole(){UserId=137, RoleId=3},
                new UserRole(){UserId=138, RoleId=3},
                new UserRole(){UserId=139, RoleId=3},
                new UserRole(){UserId=140, RoleId=3},
                new UserRole(){UserId=141, RoleId=3},
                new UserRole(){UserId=142, RoleId=3},
                new UserRole(){UserId=143, RoleId=2},
                new UserRole(){UserId=144, RoleId=3},
                new UserRole(){UserId=145, RoleId=3},
                new UserRole(){UserId=146, RoleId=3},
                new UserRole(){UserId=147, RoleId=3},
                new UserRole(){UserId=148, RoleId=3},
                new UserRole(){UserId=149, RoleId=3},
                new UserRole(){UserId=150, RoleId=3},
                new UserRole(){UserId=151, RoleId=2},
                new UserRole(){UserId=152, RoleId=3},
                new UserRole(){UserId=153, RoleId=3},
                new UserRole(){UserId=154, RoleId=3},
                new UserRole(){UserId=155, RoleId=3},
                new UserRole(){UserId=156, RoleId=3},
                new UserRole(){UserId=157, RoleId=3},
                new UserRole(){UserId=158, RoleId=3},
                new UserRole(){UserId=159, RoleId=3},
                new UserRole(){UserId=160, RoleId=2},
                new UserRole(){UserId=161, RoleId=3},
                new UserRole(){UserId=162, RoleId=3},
                new UserRole(){UserId=163, RoleId=3},
                new UserRole(){UserId=164, RoleId=3},
                new UserRole(){UserId=165, RoleId=3},
                new UserRole(){UserId=166, RoleId=3},
                new UserRole(){UserId=167, RoleId=3},
                new UserRole(){UserId=168, RoleId=3},
                new UserRole(){UserId=169, RoleId=3},
                new UserRole(){UserId=170, RoleId=3},
                new UserRole(){UserId=171, RoleId=2},
                new UserRole(){UserId=172, RoleId=3},
                new UserRole(){UserId=173, RoleId=3},
                new UserRole(){UserId=174, RoleId=3},
                new UserRole(){UserId=175, RoleId=3},
                new UserRole(){UserId=179, RoleId=3},
                new UserRole(){UserId=180, RoleId=3},
                new UserRole(){UserId=181, RoleId=2},
                new UserRole(){UserId=182, RoleId=3},
                new UserRole(){UserId=183, RoleId=3},
                new UserRole(){UserId=184, RoleId=3},
                new UserRole(){UserId=185, RoleId=3},
                new UserRole(){UserId=186, RoleId=3},
                new UserRole(){UserId=187, RoleId=3},
                new UserRole(){UserId=188, RoleId=3},
                new UserRole(){UserId=189, RoleId=2},
                new UserRole(){UserId=190, RoleId=3},
                new UserRole(){UserId=191, RoleId=3},
                new UserRole(){UserId=192, RoleId=3},
                new UserRole(){UserId=193, RoleId=3},
                new UserRole(){UserId=194, RoleId=3},
                new UserRole(){UserId=195, RoleId=3},
                new UserRole(){UserId=196, RoleId=3},
                new UserRole(){UserId=197, RoleId=2},
                new UserRole(){UserId=198, RoleId=2},
                new UserRole(){UserId=199, RoleId=3}

            };
        return userroles;
    }

    public string GetDescription()
    {
        return "让 .NET 开发更简单，更通用，更流行。";
    }

}