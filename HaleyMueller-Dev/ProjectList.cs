using HaleyMueller_Dev.Models;

namespace HaleyMueller_Dev
{
    public static class ProjectList
    {
        public static List<Models.ProjectModel> GetProjects()
        {
            var model = new List<Models.ProjectModel>();
            model.Add(new Models.ProjectModel()
            {
                Name = "Midwest DevOps API",
                ImgUrl = "/img/Swagger.png",
                Description = "This is a lead paragraph. It stands out from regular paragraphs.",
                LastUpdated = new DateTime(2022, 6, 23),
                Links = new List<ProjectModel.Link>()
                {
                    new ProjectModel.Link()
                    {
                        Name = "Website",
                        Url = "https://github.com/Midwest-DevOps-LLC/Midwest-DevOps-Site/tree/main/RESTService"
                    },
                    new ProjectModel.Link()
                    {
                        Name = "Swagger",
                        Url = "https://api.midwestdevops.com/swagger/index.html"
                    }
                }
            });

            model.Add(new Models.ProjectModel()
            {
                Name = "Food Tracker",
                ImgUrl = "/img/FoodTracker.png",
                Description = "This is a lead paragraph. It stands out from regular paragraphs.",
                LastUpdated = new DateTime(2021, 2, 15),
                Links = new List<ProjectModel.Link>()
                {
                    new ProjectModel.Link()
                    {
                        Name = "Repository",
                        Url = "https://github.com/Midwest-DevOps-LLC/FoodTracker"
                    }
                }
            });

            model.Add(new Models.ProjectModel()
            {
                Name = "Cards",
                ImgUrl = "/img/Cards.png",
                Warning = "WARNING: some text is NSFW on this site",
                Description = "This is a lead paragraph. It stands out from regular paragraphs.",
                LastUpdated = new DateTime(2021, 10, 14),
                Links = new List<ProjectModel.Link>()
                {
                    new ProjectModel.Link()
                    {
                        Name = "Website",
                        Url = "https://cards.midwestdevops.com/"
                    },
                    new ProjectModel.Link()
                    {
                        Name = "Repository",
                        Url = "https://github.com/Midwest-DevOps-LLC/Cards"
                    }
                }
            });

            model.Add(new Models.ProjectModel()
            {
                Name = "House Party",
                ImgUrl = "/img/EventPlanner.png",
                Description = "This is a lead paragraph. It stands out from regular paragraphs.",
                LastUpdated = new DateTime(2019, 12, 30),
                Links = new List<ProjectModel.Link>()
                {
                    new ProjectModel.Link()
                    {
                        Name = "Website",
                        Url = "https://houseparty.midwestdevops.com/"
                    }
                }
            });

            //TODO Set this up
            model.Add(new Models.ProjectModel()
            {
                Name = "Live Streaming",
                ImgUrl = "/img/Livestream.png",
                Description = "This is a lead paragraph. It stands out from regular paragraphs.",
                LastUpdated = new DateTime(2021, 10, 14),
                Links = new List<ProjectModel.Link>()
                {
                    new ProjectModel.Link()
                    {
                        Name = "Repository",
                        Url = "https://github.com/Midwest-DevOps-LLC/Livestreaming-Service"
                    }
                }
            });

            model.Add(new Models.ProjectModel()
            {
                Name = "Midwest Dev Ops",
                ImgUrl = "/img/MidwestDevOps.png",
                Description = "This is a lead paragraph. It stands out from regular paragraphs.",
                LastUpdated = new DateTime(2022, 7, 4),
                Links = new List<ProjectModel.Link>()
                {
                    new ProjectModel.Link()
                    {
                        Name = "Website",
                        Url = "https://midwestdevops.com/"
                    },
                    new ProjectModel.Link()
                    {
                        Name = "Repository",
                        Url = "https://github.com/Midwest-DevOps-LLC/Midwest-DevOps-Site"
                    }
                }
            });

            model.Add(new Models.ProjectModel()
            {
                Name = "Internet Radio",
                ImgUrl = "/img/InternetRadio.png",
                Description = "This is a lead paragraph. It stands out from regular paragraphs.",
                LastUpdated = new DateTime(2022, 7, 4),
                Links = new List<ProjectModel.Link>()
                {
                    new ProjectModel.Link()
                    {
                        Name = "Repository",
                        Url = "https://github.com/Midwest-DevOps-LLC/Internet-Radio"
                    }
                }
            });

            model.Add(new Models.ProjectModel()
            {
                Name = "Dominos C# API Wrapper",
                ImgUrl = "/img/Dominos.png",
                Description = "This is a lead paragraph. It stands out from regular paragraphs.",
                LastUpdated = new DateTime(2021, 10, 14),
                Links = new List<ProjectModel.Link>()
                {
                    new ProjectModel.Link()
                    {
                        Name = "Repository",
                        Url = "https://github.com/HaleyMueller/Dominos-API-CSharp"
                    }
                }
            });

            model.Add(new Models.ProjectModel()
            {
                Name = "Riptide Networking Collabaration",
                ImgUrl = "/img/Riptide.png",
                Description = "This is a lead paragraph. It stands out from regular paragraphs.",
                LastUpdated = new DateTime(2022, 5, 26),
                Links = new List<ProjectModel.Link>()
                {
                    new ProjectModel.Link()
                    {
                        Name = "Pull Request",
                        Url = "https://github.com/tom-weiland/RiptideNetworking/pull/43"
                    }
                }
            });

            model.Add(new Models.ProjectModel()
            {
                Name = "CCDA Game Launcher",
                ImgUrl = "/img/CDDA.png",
                Description = "This is a lead paragraph. It stands out from regular paragraphs.",
                LastUpdated = new DateTime(2021, 2, 15),
                Links = new List<ProjectModel.Link>()
                {
                    new ProjectModel.Link()
                    {
                        Name = "Repository",
                        Url = "https://github.com/HaleyMueller/CDDA-Cross-Platform-Launcher"
                    }
                }
            });

            return model;
        }
    }
}
