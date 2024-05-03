﻿using Education.Domain.Entities.Auth;
using Education.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Domain.Entities
{
    public class CourseModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CourseName { get; set; }
        public string Description { get; set; }
        public double TotalTime { get; set; }
        public double Price { get; set; }
        public int SoldCount { get; set; }
        public string Language { get; set; }
        public CourseActivityModel Activity { get; set; } = CourseActivityModel.Blocked;
        //Pasdagi ma'lumotlargaCRUD amali bo'lmaydi
        public string UserId { get; set; }
        public Guid CouponId { get; set; }
        public Guid CategoryId { get; set; }
        public virtual CouponModel Coupon { get; set; }
        public virtual UserModel User { get; set; }
        public virtual CategoryModel Category { get; set; }
        public virtual CourseActivityModel CourseActivity { get; set; }
        public virtual List<LessonModel> Lessons { get; set; }
        public virtual List<CourseFeedbackModel> CourseFeedbacks { get; set; } // Renamed the property to avoid conflict
    }
}