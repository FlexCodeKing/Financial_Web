using Chart.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

public class CoursesController : Controller
{
    // Tạo danh sách khóa học tĩnh trong Controller
    private static List<Course> courselistfree = new List<Course>
    {
        new Course
        {
            idCourse = 1,
            title = "Khóa học miễn phí 1",
            description = "Đây là khóa học miễn phí về lập trình C#.",
            image = "/images/singin.jfif",
            Videos = new List<Video>
            {
                new Video { Id = 1, Title = "Bài 1: Giới thiệu C#", VideoUrl = "/Video/video1.mp4" },
                new Video { Id = 2, Title = "Bài 2: Biến trong C#", VideoUrl = "/Video/dan.mp4" }
            }
        },
        new Course
        {
            idCourse = 2,
            title = "Khóa học miễn phí 2",
            description = "Đây là khóa học miễn phí về ASP.NET Core.",
            image = "/images/singin.jfif",
            Videos = new List<Video>
            {
                new Video { Id = 1, Title = "Bài 1: Giới thiệu ASP.NET Core", VideoUrl = "/Video/game.mp4" },
                 new Video { Id = 2, Title = "Bài 2: Giới thiệu ASP.NET Core", VideoUrl = "/Video/long.mp4" }
            }
        }
    };

    // Biến tĩnh để theo dõi idCourse hiện tại
    private static int currentCourseId = 5;  // ID tiếp theo sau các khóa học ban đầu
    private static int currentVideoId = 5;   // ID tiếp theo sau các video ban đầu

    // Hành động hiển thị danh sách khóa học
    public IActionResult Course()
    {
        return View(courselistfree);
    }

    // Hành động hiển thị chi tiết khóa học theo idCourse
    public IActionResult Details(int idCourse)
    {
        var course = courselistfree.FirstOrDefault(c => c.idCourse == idCourse);

        if (course == null)
        {
            return NotFound(); // Trả về trang 404 nếu không tìm thấy khóa học
        }

        return View(course);
    }

    // Hành động hiển thị video theo idVideo
    public IActionResult Video(int idCourse, int idVideo)
    {
        var course = courselistfree.FirstOrDefault(c => c.idCourse == idCourse);
        if (course == null)
        {
            return NotFound();
        }

        var videofind = course.Videos.FirstOrDefault(v => v.Id == idVideo);
        if (videofind == null)
        {
            return NotFound();
        }

        return View(videofind);
    }

    [HttpGet]
    public IActionResult AddCourse()
    {
        return View(new Course { Videos = new List<Video> { new Video() } });
    }

    [HttpPost]

    [HttpPost]
    public IActionResult AddCourse(Course newCourse)
    {
        // Tự động tăng IdCourse cho khóa học mới
        newCourse.idCourse = currentCourseId++;

        // Tự động tăng Id cho từng video trong khóa học mới
        foreach (var video in newCourse.Videos)
        {
            video.Id = currentVideoId++;
        }

        // Thêm khóa học mới vào danh sách
        courselistfree.Add(newCourse);

        // Sau khi thêm khóa học thành công, chuyển hướng về trang danh sách khóa học
        return RedirectToAction("Course");
    }

}
