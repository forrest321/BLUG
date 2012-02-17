using System.Collections.Generic;
using BLUG.Models;

namespace BLUG.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BLUG.BlugEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BLUG.BlugEntities context)
        {
            new List<Course>
                {
                    new Course {Name = "Active Directory 2008"},
                    new Course {Name = "Adv C#"},
                    new Course {Name = "CBAP Business Analyst Certification for CDU Credit"},
                    new Course {Name = "CICS"},
                    new Course {Name = "Citrix Terminal Services"},
                    new Course {Name = "Cognos Administration and/or Report Development"},
                    new Course {Name = "DB2 Stored Procedures"},
                    new Course {Name = "Easytrieve"},
                    new Course {Name = "Exchange 2007"},
                    new Course {Name = "Intro C#"},
                    new Course {Name = "JAVA"},
                    new Course {Name = "JCL"},
                    new Course {Name = "MS-Project 2007"},
                    new Course {Name = "Oracle 10g-11g New Features for SQL and PL/SQL Development"},
                    new Course {Name = "Oracle SQL Tuning for Developers"},
                    new Course {Name = "Oracle SQL, PL/SQL, Forms, Reports, Tuning."},
                    new Course {Name = "OWASP"},
                    new Course {Name = "PCI Compliance Training"},
                    new Course {Name = "PHP Programming"},
                    new Course {Name = "Project Management for PDU Credits"},
                    new Course {Name = "Project Management for PMP Credit"},
                    new Course {Name = "SharePoint: Introduction to SharePoint 2007 - WSS 3.0 not MOSS"},
                    new Course {Name = "SQL Server 2005 Administration"},
                    new Course {Name = "VB Scripting"},
                    new Course {Name = "VB.net Advanced"},
                    new Course {Name = "VB.net Intro"},
                    new Course {Name = "VMWare"},
                    new Course {Name = "Voice XML"},
                    new Course {Name = "WCF Windows Communication Foundation Services"},
                    new Course {Name = "Windows 7 Installation and Administration"},
                    new Course {Name = "WSDL - Web Services Descriptor Language - Service Oriented Architecture"},
                    new Course {Name = "XML"},

                }.ForEach(a => context.Courses.Add(a));

            new List<Vendor>
                {
                    new Vendor {Name = "American Cast Iron Pipe Co"},
                    new Vendor {Name = "AmSouth Bank of Alabama"},
                    new Vendor {Name = "Blue Cross/Blue Shield of Alabama"},
                    new Vendor {Name = "Carraway Methodist Medical Center"},
                    new Vendor {Name = "City of Birmingham"},
                    new Vendor {Name = "Compass Bank"},
                    new Vendor {Name = "CSC (Computer Sciences Corporation)"},
                    new Vendor {Name = "Drummond Company, Inc"},
                    new Vendor {Name = "EBSCO Industries"},
                    new Vendor {Name = "Energen"},
                    new Vendor {Name = "Jefferson County"},
                    new Vendor {Name = "Liberty National Life Insurance"},
                    new Vendor {Name = "Moore Handley"},
                    new Vendor {Name = "Motion Industries"},
                    new Vendor {Name = "O'Neal Steel, Inc"},
                    new Vendor {Name = "Protective Life Corporation"},
                    new Vendor {Name = "Regions Financial Corporation"},
                    new Vendor {Name = "Samford University"},
                    new Vendor {Name = "Shelby County"},
                    new Vendor {Name = "Southern Company Services"},
                    new Vendor {Name = "Southern Progress"},
                    new Vendor {Name = "SouthTrust Bank Information Services Division"},
                    new Vendor {Name = "University of Alabama-Birmingham"},
                }.ForEach(a => context.Vendors.Add(a));

            context.SaveChanges();
        }
    }
}
