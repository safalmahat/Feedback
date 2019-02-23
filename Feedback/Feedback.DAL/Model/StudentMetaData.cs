using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback.DAL.Model
{
   public class UserInfoMetaData
    {
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "User Name is required")]
        public string UserName { get; set; }

    }

    public class StudentMetaData
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

    }
    [MetadataType(typeof(UserInfoMetaData))]
    public partial class UserInfo
    {

    }
    [MetadataType(typeof(StudentMetaData))]
    public partial class StudentInfo
    {

    }
}
