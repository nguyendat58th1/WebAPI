using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Webapi.Bizlogics
{
    public class MemberHandler : IMemberHandler
    {
        private List<Member> _listMembers;

        public MemberHandler()
        {
            SeedingData();
        }
        public List<Member> FilterMemberByBirthPlace(string place)
        {
            var result = _listMembers.Where(x => x.BirthPlace == place).ToList();
            return result;
        }

        public List<Member> FilterMemberByBirthYear(int year)
        {
            var result = _listMembers.Where(x => x.DateOfBirth.Year == year).ToList();
            return result;
        }

        public List<Member> FilterMemberByBirthYearGreaterThan(int year)
        {
            var result = _listMembers.Where(x => x.DateOfBirth.Year > year).ToList();
            return result;
        }

        public List<Member> FilterMemberByBirthYearLessThan(int year)
        {
            var result = _listMembers.Where(x => x.DateOfBirth.Year < year).ToList();
            return result;
        }

        public List<string> GetMemberWithFullNameOnly()
        {
            var result = _listMembers.Select(x => $"{x.FirstName + x.LastName}").ToList();
            return result;
        }

        public List<Member> FilterMemberByGender(string gender)
        {
            var result = _listMembers.Where(x => x.Gender == gender).ToList();
            return result;
        }

        public Member ReturnTheOldestMember()
        {
            var minDob = _listMembers.Min(x => x.DateOfBirth);
            var result = _listMembers.FirstOrDefault(x => x.DateOfBirth == minDob);
            return result;
        }

        private void SeedingData()
        {
            _listMembers = new List<Member>
            {
                new Member
                {
                    FirstName = "Loi",
                    LastName = "Le",
                    DateOfBirth = new DateTime(1998,2,5),
                    BirthPlace = "Hanoi",
                    PhoneNumber = "0938535",
                    Gender = "Male",
                    isGraduated = true,
                    StartDate = new DateTime(2020,5,6),
                    EndDate = new DateTime(2021,12,4)
                },
                new Member
                {
                    FirstName = "Hai",
                    LastName = "Nguyen",
                    DateOfBirth = new DateTime(1998,2,5),
                    BirthPlace = "Hanoi",
                    PhoneNumber = "0938535",
                    Gender = "Female",
                    isGraduated = true,
                    StartDate = new DateTime(2020,5,6),
                    EndDate = new DateTime(2021,12,4)
                },
                new Member
                {
                    FirstName = "Phu",
                    LastName = "Tran",
                    DateOfBirth = new DateTime(1998,2,5),
                    BirthPlace = "Hanoi",
                    PhoneNumber = "0938535",
                    Gender = "Male",
                    isGraduated = true,
                    StartDate = new DateTime(2020,5,6),
                    EndDate = new DateTime(2021,12,4)
                },
                new Member
                {
                    FirstName = "Vu",
                    LastName = "Le",
                    DateOfBirth = new DateTime(1998,2,5),
                    BirthPlace = "Hanoi",
                    PhoneNumber = "0938535",
                    Gender = "Male",
                    isGraduated = true,
                    StartDate = new DateTime(2020,5,6),
                    EndDate = new DateTime(2021,12,4)
                },
                new Member
                {
                    FirstName = "Ha",
                    LastName = "Pham",
                    DateOfBirth = new DateTime(1998,2,5),
                    BirthPlace = "Hanoi",
                    PhoneNumber = "0938535",
                    Gender = "Female",
                    isGraduated = true,
                    StartDate = new DateTime(2020,5,6),
                    EndDate = new DateTime(2021,12,4)
                }
            };
        }

        public List<Member> AddNewMember(Member member)
        {
            _listMembers.Add(member);
            return _listMembers;
        }
        public List<Member> DeleteMember(Member member)
        {
            _listMembers.Remove(member);
            return _listMembers;
        }

        public List<Member> UpdateMember(Member member)
        {
            var result = _listMembers.Where(x => x.LastName == member.LastName).FirstOrDefault();
            result.LastName = member.LastName;
            result.FirstName = member.FirstName;
            result.Gender = member.Gender;
            result.PhoneNumber = member.PhoneNumber;
            result.DateOfBirth = member.DateOfBirth;
            result.BirthPlace = member.BirthPlace;
            result.isGraduated = member.isGraduated;
            result.StartDate = member.StartDate;
            result.EndDate = member.EndDate;
            return _listMembers;
        }
    }
}