using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webapi.Bizlogics;
namespace Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : Controller
    {
        private IMemberHandler _memberhandler;

        public MemberController(IMemberHandler memberHandler)
        {
            _memberhandler = memberHandler;
        }
        [HttpGet]
        [Route("/api/member/memberbygender/{gender}")]
        public List<Member> FilterMemberByGender(string gender)
        {
            return _memberhandler.FilterMemberByGender(gender);
        }
        [HttpGet]
        [Route("/api/member/memberbyplace/{place}")]
        public List<Member> FilterMemberByPlace(string place)
        {
            return _memberhandler.FilterMemberByBirthPlace(place);
        }

        [HttpGet]
        [Route("/api/member/theoldestmember")]
        public Member ReturnTheOldestMember()
        {
            return _memberhandler.ReturnTheOldestMember();
        }
        
        [HttpGet]
        [Route("/api/member/getmemberwithfullname")]
        public List<string> GetMemberWithFullNameOnly()
        {
            return _memberhandler.GetMemberWithFullNameOnly();
        }
        
        [HttpGet]
        [Route("/api/member/getmemberwithfullname")]
        public List<Member> FilterMemberByBirthYear(int year)
        {
            return _memberhandler.FilterMemberByBirthYear(year);
        }
        
        [HttpGet]
        [Route("/api/member/getmemberwithfullname")]
        public List<Member> FilterMemberByGreaterThanBirthYear(int year)
        {
            return _memberhandler.FilterMemberByBirthYearGreaterThan(year);
        }
        
        [HttpGet]
        [Route("/api/member/getmemberwithfullname")]
        public List<Member> FilterMemberByLessThanBirthYear(int year)
        {
            return _memberhandler.FilterMemberByBirthYearLessThan(year);
        }
        

        [HttpPost]
        public List<Member> Post(Member member)
        {
            return _memberhandler.AddNewMember(member);
        }

        [HttpPost]
        public List<Member> Update(Member member)
        {
            return _memberhandler.UpdateMember(member);
        }

        [HttpDelete]
        public List<Member> Delete(Member member)
        {
            return _memberhandler.DeleteMember(member);
        }
        public IActionResult Index()
        {
            
            return View();
        }
    }
}