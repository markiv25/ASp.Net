
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project3_FinalExam.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Services;
using Project3_FinalExam.ViewModels;

namespace Project3_FinalExam.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetFaculty _facultyRepository;
        private readonly IGetUndergraduate _undergradRepository;
        private readonly IGetGraduate _graduateRepository;
        private readonly IGetStaff _staffRepository;
        private readonly IGetHome _homeRepository;
        private readonly IGetResearch _researchRepository;
        private readonly IGetMinors _minorsRepository;
        private readonly IGetEmploy _employRepository;
        private readonly IGetMix _mixRepository;
        public HomeController(IGetFaculty facultyRepository, IGetUndergraduate undergradRepository, IGetGraduate graduateRepository, IGetStaff staffRepository, IGetHome homeRepository, IGetResearch researchRepository, IGetMinors minorsRepository, IGetEmploy employRepository, IGetMix mixRepository)
        {
            _facultyRepository = facultyRepository;
            _undergradRepository = undergradRepository;
            _graduateRepository = graduateRepository;
            _staffRepository = staffRepository;
            _homeRepository = homeRepository;
            _researchRepository = researchRepository;
            _minorsRepository = minorsRepository;
            _employRepository = employRepository;
            _mixRepository = mixRepository;
        }

        public async Task<IActionResult> GetFaculty()
        {
            var allFaculty = await _facultyRepository.GetAllFaculty();
            var sortedFaculty = allFaculty.OrderBy(f => f.username);
            var allStaff = await _staffRepository.GetAllStaff();
            var sortedStaff = allFaculty.OrderBy(f => f.username);
            var under = await _mixRepository.GetAllResearch();
            var mixViewModel = new MixViewModel()
            {
                Faculty = allFaculty.ToList(),
                staff= allStaff.ToList(),
                Research =under,
            };
            return View(mixViewModel);
        }

        public async Task<IActionResult> Index()
        {
            var allhome = await _homeRepository.GetAllHome();
            var HomeViewModel = new HomeViewModel()
            {
                home = allhome,
            };
            return View(HomeViewModel);
        }
        public async Task<IActionResult> Minors()
        {
            var allminors = await _minorsRepository.GetAllMinors();
           
            var MinorsViewModel = new MinorsViewModel()
            {
                Minors = allminors,
              
            };
            return View(MinorsViewModel);
        }
        public async Task<IActionResult> Employment()
        {
          
            var allemploy = await _employRepository.GetAllEmploy();
            var EmployViewModel = new EmployViewModel()
            {
               
                Employ = allemploy,
            };
            return View(EmployViewModel);
        }

        public async Task<IActionResult> Research()
        {
            var under = await _researchRepository.GetAllResearch();
            var ResearchViewModel = new ResearchViewModel()
            {
                Research = under,
           
            };
            return View(ResearchViewModel);
        }


        public async Task<IActionResult> Degrees()
        {
            var under = await _undergradRepository.GetUnderGradDegrees();
            var degreeViewModel = new DegreeViewModel()
            {
                UnderGrads = under,
                Title = "Degrees"
            };
            return View(degreeViewModel);
        }

        public async Task<IActionResult> GetGradMajors()
        {
            var grad = await _graduateRepository.GetGradDegrees();
            return PartialView("Grad", grad);
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
