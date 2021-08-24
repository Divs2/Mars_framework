using MarsFramework.Pages;
using NUnit.Framework;
using System;
using System.Threading;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test]
            public void EnterShareSkill()
            {

                ShareSkill shareskillobj = new ShareSkill();
                shareskillobj.EnterShareSkill();
                Thread.Sleep(5000);
                shareskillobj.validateskill();


            }
            [Test]
            public void ManageListingEdit()
            {

                ShareSkill editobj = new ShareSkill();
                editobj.EditShareSkill();
                Thread.Sleep(5000);
                editobj.validateeditskill();


            }

            [Test]
            public void ShareSkillDelete()
            {
                ManageListings deleteobj = new ManageListings();
                deleteobj.Listings();
                Thread.Sleep(5000);
                deleteobj.validatedelete();
            }




        }
    }
}