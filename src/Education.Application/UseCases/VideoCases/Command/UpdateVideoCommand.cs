﻿using Education.Domain.Entities.DemoModels;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Application.UseCases.VideoCases.Command
{
    public class UpdateVideoCommand:IRequest<ResponseModel>
    {
        public Guid LessonId { get; set; }
        public IFormFile Video { get; set; }
    }
}
