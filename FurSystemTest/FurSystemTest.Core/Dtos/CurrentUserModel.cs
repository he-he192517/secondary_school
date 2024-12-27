namespace FurSystemTest.Core.Dtos
{
    /// <summary>
    /// 当前用户信息
    /// </summary>
    public class CurrentUserModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Account { get; set; }

        public string Mobile { get; set; }

        public string Role { get; set; }
    }
}
