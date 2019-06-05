using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dotNetServer.Models;

namespace dotNetServer.Controllers
{
  [Route("api/[controller]")]
  public class StudentController : Controller
  {
    [HttpGet]
    public IEnumerable<Student> GetAll()
    {
      // Faked Output - Replace with database request
      var studentList = new List<Student>();
      studentList.Add(new Student() { Name = "Billy", Age = "40", Sex = "Male" });
      studentList.Add(new Student() { Name = "Brian", Age = "47", Sex = "Male" });
      studentList.Add(new Student() { Name = "Peyton", Age = "19", Sex = "Female" });
      return studentList;
    }

    [HttpGet("{name}")]
    public Student Get(string name)
    {
      // Faked Output - Replace with database request
      return new Student() { Name = name };
    }

    [HttpPost]
    public Student Insert([FromBody]Student student)
    {
      // write the new student to database
      return student;
    }

  }
}