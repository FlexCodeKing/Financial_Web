namespace Chart.Models
{
    public class Course
    {
      
            public int idCourse { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string image { get; set; }
            public List<Video> Videos { get; set; }

    }
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string VideoUrl { get; set; }
    }

    public class DataFreeCourse
    {
        public List<Course> FreeCourses()
        {
            List<Course> courselistfree = new List<Course>();
            /* courselistfree.Add(new Course()*/
            /*{
                idCourse = 1,
                title = "Khóa học miễn phí 1",
                description = "Đây là khóa học miễn phí về lập trình C#.",
                image = "/images/singin.jfif", // Thay bằng đường dẫn thực tế đến hình ảnh
                Videos = new List<Video>
                {
                    new Video { Id = 1, Title = "Bài 1: Giới thiệu C#", VideoUrl = "/Video/video1.mp4" },

                }
            });*/

            /* // Khóa học 2
             courselistfree.Add(new Course()
             {
                 idCourse = 2,
                 title = "Khóa học miễn phí 2",
                 description = "Đây là khóa học miễn phí về ASP.NET Core.",
                 image = "path_to_image_2.jpg", // Thay bằng đường dẫn thực tế đến hình ảnh
                 Videos = new List<Video>
                 {
                     new Video { Id = 3, Title = "Bài 1: Giới thiệu ASP.NET Core", VideoUrl = "path_to_video_3.mp4" },
                     new Video { Id = 4, Title = "Bài 2: Cấu trúc của một ứng dụng ASP.NET Core", VideoUrl = "path_to_video_4.mp4" }
                 }
             });*/
            return courselistfree;
        }
    }

    }
