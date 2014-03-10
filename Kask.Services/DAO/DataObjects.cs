﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Kask.Services.DAO
{
    public interface IDataObject
    {
        int ID { get; set; }
    }

    [DataContract]
    public class ApplicationDAO    :   IDataObject
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int ApplicationID { get; set; }

        [DataMember]
        public string ApplicationStatus { get; set; }

        [DataMember]
        public string SalaryExpectation { get; set; }

        [DataMember]
        public byte? FullTime { get; set; }

        #region Available shifts
        [DataMember]
        public byte? AvailableForDays { get; set; }

        [DataMember]
        public byte? AvailableForEvenings { get; set; }

        [DataMember]
        public byte? AvailableForWeekends { get; set; }
        #endregion

        #region Available Hours
        [DataMember]
        public TimeSpan? MondayFrom { get; set; }

        [DataMember]
        public TimeSpan? TuesdayFrom { get; set; }

        [DataMember]
        public TimeSpan? WednesdayFrom { get; set; }

        [DataMember]
        public TimeSpan? ThursdayFrom { get; set; }

        [DataMember]
        public TimeSpan? FridayFrom { get; set; }

        [DataMember]
        public TimeSpan? SaturdayFrom { get; set; }

        [DataMember]
        public TimeSpan? SundayFrom { get; set; }

        [DataMember]
        public TimeSpan? MondayTo { get; set; }

        [DataMember]
        public TimeSpan? TuesdayTo { get; set; }

        [DataMember]
        public TimeSpan? WednesdayTo { get; set; }

        [DataMember]
        public TimeSpan? ThursdayTo { get; set; }

        [DataMember]
        public TimeSpan? FridayTo { get; set; }

        [DataMember]
        public TimeSpan? SaturdayTo { get; set; }

        [DataMember]
        public TimeSpan? SundayTo { get; set; }
        #endregion
    }

    [DataContract]
    public class ApplicantDAO   :   IDataObject
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int ApplicantID { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string MiddleName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string SSN { get; set; }

        [DataMember]
        public string Gender { get; set; }

        [DataMember]
        public string ApplicantAddress { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string NameAlias { get; set; }
    }

    [DataContract]
    public class AppliedDAO :   IDataObject
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int AppliedID { get; set; }

        [DataMember]
        public int ApllicantID { get; set; }

        [DataMember]
        public int ApllicationID { get; set; }

        [DataMember]
        public int JobID { get; set; }

        [DataMember]
        public DateTime DateApplied { get; set; }
    }

    [DataContract]
    public class SkillDAO  :   IDataObject
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int SkillID { get; set; }

        [DataMember]
        public string SkillName {get; set;}
    }

    [DataContract]
    public class AssociateDAO   :   IDataObject
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int ApplicantID { get; set; }

        [DataMember]
        public int ReferenceID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Title { get; set; }
    }

    [DataContract]
    public class EducationDAO   :   IDataObject
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int ApplicantID { get; set; }

        [DataMember]
        public int SchoolID { get; set; }

        [DataMember]
        public DateTime? YearsAttendedFrom { get; set; }

        [DataMember]
        public DateTime? YearsAttendedTo { get; set; }

        [DataMember]
        public byte? Graduated { get; set; }

        [DataMember]
        public string DegreeAndMajor { get; set; }
    }

    [DataContract]
    public class EmployerDAO : IDataObject
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int EmployerID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string EmployerAddress { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }
    }

    [DataContract]
    public class EmploymentDAO : IDataObject
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int ApplicantID { get; set; }

        [DataMember]
        public int EmployerID { get; set; }

        [DataMember]
        public byte? MayWeContactCurrentEmployer { get; set; }

        [DataMember]
        public DateTime? EmployedFrom { get; set; }

        [DataMember]
        public DateTime? EmployedTo { get; set; }

        [DataMember]
        public string Supervisor { get; set; }

        [DataMember]
        public string Position { get; set; }

        [DataMember]
        public string StartingSalary { get; set; }

        [DataMember]
        public string EndingSalary { get; set; }

        [DataMember]
        public string ReasonForLeaving { get; set; }

        [DataMember]
        public string Responsibilities { get; set; }
    }

    [DataContract]
    public class ExpertiseDAO : IDataObject
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int ApplicantID { get; set; }

        [DataMember]
        public int SkillID { get; set; }
    }

    [DataContract]
    public class JobDAO : IDataObject
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int JobID { get; set; }

        [DataMember]
        public string Title { get; set; }
    }

    [DataContract]
    public class JobRequirementDAO : IDataObject
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int JobID { get; set; }

        [DataMember]
        public int SkillID { get; set; }

        [DataMember]
        public string Notes { get; set; }
    }

    [DataContract]
    public class ReferenceDAO : IDataObject
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int ReferenceID { get; set; }

        [DataMember]
        public int? YearsKnown { get; set; }
    }

    [DataContract]
    public class SchoolDAO : IDataObject
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int SchoolID { get; set; }

        [DataMember]
        public string SchoolName { get; set; }
    }
}
