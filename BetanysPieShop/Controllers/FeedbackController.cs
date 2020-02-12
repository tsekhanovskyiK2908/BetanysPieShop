﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BetanysPieShop.Models;
using Microsoft.AspNetCore.Authorization;

namespace BetanysPieShop.Controllers
{   
    [Authorize]
    public class FeedbackController : Controller
    {
        private IFeedbackRepository _feedbackRepository;

        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {   
            if(ModelState.IsValid)
            {
                _feedbackRepository.AddFeedback(feedback);

                return RedirectToAction("FeedbackComplete");
            }

            return View(feedback);
            
        }

        public IActionResult FeedbackComplete()
        {
            return View();
        }
    }
}