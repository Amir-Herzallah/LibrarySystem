﻿using LibrarySystem.Core.Data;
using LibrarySystem.Core.Service;
using LibrarySystem.Infra.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialPageController : ControllerBase
    {
        private readonly ITestimonialPageService testimonialPageService;
        public TestimonialPageController(ITestimonialPageService testimonialPageService)
        {
            this.testimonialPageService = testimonialPageService;
        }
        [HttpGet]
        [Route("GetAllTestimonialPageData")]
        public List<Testimonialpage> GetAllTestimonialPageData()
        {
            return testimonialPageService.GetAllTestimonialPageData();
        }
        [HttpGet]
        [Route("GetTestimonialPageDataById/{id}")]
        public Testimonialpage GetTestimonialPageDataById(int id)
        {
            return testimonialPageService.GetTestimonialPageDataById(id);
        }
        [HttpPost]
        [Route("CreateTestimonialPageData")]
        [Authorize]
        [RequiresClaim("roleid", "1")]
        public void CreateTestimonialPageData(Testimonialpage testimonialpage)
        {
            testimonialPageService.CreateTestimonialPageData(testimonialpage);
        }
        [HttpPut]
        [Route("UpdateTestimonialPageData")]
        [Authorize]
        [RequiresClaim("roleid", "1")]
        public void UpdateTestimonialPageData(Testimonialpage testimonialpage)
        {
            testimonialPageService.UpdateTestimonialPageData(testimonialpage);
        }
        [HttpDelete]
        [Route("DeleteTestimonialPageData")]
        [Authorize]
        [RequiresClaim("roleid", "1")]
        public void DeleteTestimonialPageData(int id)
        {
            testimonialPageService.DeleteTestimonialPageData(id);
        }
    }
}
