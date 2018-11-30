using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace mantis_tests
{
    public class ProjectHelper : HelperBase
    {
        public ProjectHelper(ApplicationManager manager) : base(manager)  { }
        private List<ProjectData> projectCache = null;

        public List<ProjectData> GetAllFromUI()
        {
            if (projectCache == null)
            {
                projectCache = new List<ProjectData>();
                manager.Navigator.Open_Homepage();
                manager.Navigator.GoToProjectPage();
                int elements = driver.FindElements(By.CssSelector("td > a")).Count;
                for (int i = 1; i <= elements; i++)
                {
                    projectCache.Add(new ProjectData()
                    {
                        Name = driver.FindElement(By.CssSelector("tbody > tr:nth-of-type(" + i + ") a")).Text, //доработать
                        Description = driver.FindElement(By.CssSelector("tr:nth-of-type(" + i + ") > td:nth-of-type(5)")).Text
                    });
                }
            }
            return new List<ProjectData>(projectCache);
        }

        public void ProjectElementVerification()
        {
            manager.Navigator.Open_Homepage();
            manager.Navigator.GoToProjectPage();
            if (!IsProjectExist())
            {
                ProjectData project = new ProjectData()
                {
                    Name = "adfasdf",
                    Description = "1324123"
                };
                Creation(project);
            }
        }

        public void Remove(int toBeRemoved)
        {
            manager.Navigator.Open_Homepage();
            manager.Navigator.GoToProjectPage();
            OpenProject(toBeRemoved);
            SubmintProjectRemove();
        }

        private void SubmintProjectRemove()
        {
            driver.FindElement(By.XPath("//input[@value='Удалить проект']")).Click();
            driver.FindElement(By.XPath("//input[@value='Удалить проект']")).Click();
        }

        private void OpenProject(int toBeRemoved)
        {
            driver.FindElement(By.CssSelector("td:nth-of-type(" + (toBeRemoved + 1) + ") > a")).Click();
        }

        public void Creation(ProjectData project)
        {
            manager.Navigator.GoToProjectPage();
            InitProjectModification();
            FillProjectModification(project);
            SubmintProjectModification();
            Thread.Sleep(3000);
        }

        private void SubmintProjectModification()
        {
            driver.FindElement(By.XPath("//input[@value='Добавить проект']")).Click();
        }

        private void FillProjectModification(ProjectData project)
        {
            driver.FindElement(By.Id("project-name")).Click();
            driver.FindElement(By.Id("project-name")).Clear();
            driver.FindElement(By.Id("project-name")).SendKeys(project.Name);
            driver.FindElement(By.Id("project-description")).Click();
            driver.FindElement(By.Id("project-description")).Clear();
            driver.FindElement(By.Id("project-description")).SendKeys(project.Description);
        }

        private void InitProjectModification()
        {
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        public int GetProjectCount()
        {
            return driver.FindElements(By.CssSelector("td > a")).Count;
        }

        private bool IsProjectExist()
        {
            return IsElementPresent(By.CssSelector("td > a"));
        }
    }
}