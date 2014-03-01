﻿using Kask.DAL2.Models;
using Kask.Services.Interfaces;
using Kask.Services.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System;

namespace Kask.Services
{
    public class AESApplicationService : IApplicationService, IApplicantService, IAppliedService
    {
        public Application GetApplicationById(int id)
        {
            try
            {
                using (AESDatabaseDataContext db = new AESDatabaseDataContext())
                {
                    Application application = (from a in db.Applications where a.Application_ID == id select a).First();
                    return (application != null ? application : null);
                }
            }
            catch(Exception e)
            {
                throw new FaultException<KaskServiceException>(new KaskServiceException(e.Message));
            }
        }

        public Application GetApplicationByName (string first, string last, string ssn)
        {
            try
            {
                using (AESDatabaseDataContext db = new AESDatabaseDataContext())
                {
                    Applicant applicant = (from a in db.Applicants where a.FirstName == first && a.LastName == last && a.SSN == ssn select a).First();
                    return GetApplicationById(applicant.Applicant_ID);
                }
            }
            catch (Exception e)
            {
                throw new FaultException<KaskServiceException>(new KaskServiceException(e.Message));
            }
        }

        public IList<Application> GetApplications()
        {
            try
            {
                using (AESDatabaseDataContext db = new AESDatabaseDataContext())
                {
                    var apps = db.Applications.ToList();
                    return (apps != null ? apps : null);
                }
            }
            catch (Exception e)
            {
                throw new FaultException<KaskServiceException>(new KaskServiceException(e.Message));
            }
        }

        public bool CreateApplication(Application app)
        {
            using (AESDatabaseDataContext db = new AESDatabaseDataContext())
            {
                db.Applications.InsertOnSubmit(app);
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    throw new FaultException<KaskServiceException>(new KaskServiceException(e.Message));
                }
            }

            return true;
        }

        public bool UpdateApplication(Application newApp)
        {
            using (AESDatabaseDataContext db = new AESDatabaseDataContext())
            {
                Application a = db.Applications.Single(app => app.Application_ID == newApp.Application_ID);
                a.ApplicationStatus = newApp.ApplicationStatus;
                // TODO: Update relation Application's Properties

                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    throw new FaultException<KaskServiceException>(new KaskServiceException(e.Message));
                }
            }

            return true;
        }

        public bool DeleteApplication(int ID)
        {
            using (AESDatabaseDataContext db = new AESDatabaseDataContext())
            {
                Application a = db.Applications.Single(app => app.Application_ID == ID);
                db.Applications.DeleteOnSubmit(a);

                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    throw new FaultException<KaskServiceException>(new KaskServiceException(e.Message));
                }
            }

            return true;
        }

        public Applicant GetApplicantByID(int id)
        {
            try
            {
                using (AESDatabaseDataContext db = new AESDatabaseDataContext())
                {
                    Applicant applicant = (from a in db.Applicants where a.Applicant_ID == id select a).First();
                    return (applicant != null ? applicant : null);
                }
            }
            catch (Exception e)
            {
                throw new FaultException<KaskServiceException>(new KaskServiceException(e.Message));
            }
        }

        public IList<Applicant> GetApplicants()
        {
            try
            {
                using (AESDatabaseDataContext db = new AESDatabaseDataContext())
                {
                    var apps = db.Applicants.ToList();
                    return (apps != null ? apps : null);
                }
            }
            catch (Exception e)
            {
                throw new FaultException<KaskServiceException>(new KaskServiceException(e.Message));
            }
        }

        public bool CreateApplicant(Applicant a)
        {
            using (AESDatabaseDataContext db = new AESDatabaseDataContext())
            {
                db.Applicants.InsertOnSubmit(a);
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    throw new FaultException<KaskServiceException>(new KaskServiceException(e.Message));
                }
            }

            return true;
        }

        public bool UpdateApplicant(Applicant newApp)
        {
            using (AESDatabaseDataContext db = new AESDatabaseDataContext())
            {
                Applicant a = db.Applicants.Single(app => app.Applicant_ID == newApp.Applicant_ID);
                a.FirstName = newApp.FirstName;
                a.LastName = newApp.LastName;
                a.Gender = newApp.Gender;
                a.SSN = newApp.SSN;
                // TODO: Update Relation Applicant's Properties

                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    throw new FaultException<KaskServiceException>(new KaskServiceException(e.Message));
                }
            }

            return true;
        }

        public bool DeleteApplicant(int ID)
        {
            using (AESDatabaseDataContext db = new AESDatabaseDataContext())
            {
                Applicant a = db.Applicants.Single(app => app.Applicant_ID == ID);
                db.Applicants.DeleteOnSubmit(a);

                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    throw new FaultException<KaskServiceException>(new KaskServiceException(e.Message));
                }
            }

            return true;
        }

        public Applied GetAppliedByID(int id)
        {
            try
            {
                using (AESDatabaseDataContext db = new AESDatabaseDataContext())
                {
                    var applied = db.Applieds.Single(a => a.Applicant_ID == id);
                    return (applied != null ? applied : null);
                }
            }
            catch (Exception e)
            {
                throw new FaultException<KaskServiceException>(new KaskServiceException(e.Message));
            }
        }

        public IList<Applied> GetApplieds()
        {
            try
            {
                using (AESDatabaseDataContext db = new AESDatabaseDataContext())
                {
                    var apps = db.Applieds.ToList();
                    return (apps != null ? apps : null);
                }
            }
            catch (Exception e)
            {
                throw new FaultException<KaskServiceException>(new KaskServiceException(e.Message));
            }
        }

        public bool CreateApplied(Applied a)
        {
            throw new System.NotImplementedException();     // These are from views branch
        }

        public bool UpdateApplied(Applied a)
        {
            throw new System.NotImplementedException();     // These are from views branch
        }

        public bool DeleteApplied(int id)
        {
            throw new System.NotImplementedException();     // These are from views branch
        }
    }
}
