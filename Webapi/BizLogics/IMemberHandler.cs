using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Webapi.Bizlogics
{
    public interface IMemberHandler 
    {
        //1. Return List member who is male
        List<Member> FilterMemberByGender(string gender); 
        //2. Return the oldest member
        Member ReturnTheOldestMember();
        //3. Return full name member
        List<string> GetMemberWithFullNameOnly();
        //4.1 Return list of member who has birth year is 2000
        List<Member> FilterMemberByBirthYear(int year);
        //4.2 Return list of member who has birth year is greater than 2000
        List<Member> FilterMemberByBirthYearGreaterThan(int year);
        //4.3 Return list of member who has birth year is less than 2000
        List<Member> FilterMemberByBirthYearLessThan(int year);
        //5 Return list of member who born in HN
        List<Member> FilterMemberByBirthPlace(string place);
        //Add new member
        List<Member> AddNewMember(Member member);
        List<Member> UpdateMember(Member member);
        List<Member> DeleteMember(Member member);
    }
}