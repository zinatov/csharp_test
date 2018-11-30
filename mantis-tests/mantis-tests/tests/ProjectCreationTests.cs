using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

namespace mantis_tests
{
    [TestFixture]
    public class ProjectCreationTests : AuthTestBase
    {
        public static IEnumerable<ProjectData> RandomDataProvider()
        {
            List<ProjectData> project = new List<ProjectData>();
            for (int i = 0; i < 5; i++)
            {
                project.Add(new ProjectData()
                {
                    Name = GenerateRandonString(10),
                    Description = GenerateRandonString(10)
                });
            }
            return project;
        }

        [Test]//, TestCaseSource("RandomDataProvider")]
        public void ProjectCreationTest()
        {
            ProjectData project = new ProjectData()
            {
                Name = "25243231235" + GenerateRandonString(10),
                Description = "122332341" + GenerateRandonString(10)
            };
            List<ProjectData> oldProjects = app.project.GetAllFromUI();

            app.project.Creation(project);

            Assert.AreEqual(oldProjects.Count + 1, app.project.GetProjectCount());

            List<ProjectData> newProjects = app.project.GetAllFromUI();

            oldProjects.Add(project);
            oldProjects.Sort();
            newProjects.Sort();
            for (int i = 0; i<oldProjects.Count; i++)
            {
                System.Console.Out.WriteLine("Old", oldProjects[i].Name, oldProjects[i].Description);
            }
            for (int i = 0; i < newProjects.Count; i++)
            {
                System.Console.Out.WriteLine("New", newProjects[i].Name, newProjects[i].Description);
            }
            Assert.AreEqual(oldProjects, newProjects);
        }
    }
}
