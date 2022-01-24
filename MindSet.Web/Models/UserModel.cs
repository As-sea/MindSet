namespace MindSet.Web.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class UserModel
    {
        public string Id { get; set; }

        [DisplayName("Username")]
        [Required(ErrorMessage = "Please enter your username")] //要求页面不能为空
        public string Name { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Please enter your password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Remember me")]
        public bool IsRememberMe { get; set; }

        public string DisplayName { get; set; }
    }
}