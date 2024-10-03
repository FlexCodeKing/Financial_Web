using Chart.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class CoursesController : Controller
{
    public IActionResult Course()
    {
        var courselistfree = new List<Course>
        {
            new Course
            {
                idCourse = 1,
                title = "Khóa học miễn phí 1",
                description = "Đây là khóa học miễn phí về lập trình C#.",
                image = "/images/singin.jfif", // Ensure this path is correct
                Videos = new List<Video>
                {
                    new Video { Id = 1, Title = "Bài 1: Giới thiệu C#", VideoUrl = "/Video/video1.mp4" },
                    new Video { Id = 2, Title = "Bài 2: Cơ bản về biến và kiểu dữ liệu", VideoUrl = "path_to_video_2.mp4" }
                }
            },
            new Course
            {
                idCourse = 2,
                title = "Khóa học miễn phí 2",
                description = "Khóa học miễn phí về lập trình Web.",
                image = "/images/singin2.jfif", // Ensure this path is correct
                Videos = new List<Video>
                {
                    new Video { Id = 1, Title = "Bài 1: Giới thiệu Web", VideoUrl = "path_to_video_3.mp4" },
                    new Video { Id = 2, Title = "Bài 2: HTML cơ bản", VideoUrl = "path_to_video_4.mp4" }
                }
            }
        };

        return View(courselistfree); // Pass the list to the view
    }
}
