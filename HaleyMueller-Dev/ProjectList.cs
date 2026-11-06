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
                Name = "Stream Flow Platform",
                ImgUrls = new() { "/img/zen_NF2651wEtO.png", "/img/zen_mR1CSOE0Zg.png", "/img/zen_yAkLDfgOlw.png", "/img/zen_CCip5Bqq5Q.png", "/img/flow-twitch.svg" },
                Description = "A complete live streaming automation platform that captures, processes, and archives every broadcast.<br/><br/>It records stream lifecycle events from Twitch and Owncast, synchronizes chat, redeems, and custom events in real time through SignalR and WebSockets, powers live overlays, and integrates with Resonite for in-game event automation.<br/><br/>After each stream, it automatically downloads the VOD, transcodes it for browser playback, generates AI-powered transcripts using Whisper, creates searchable subtitles, summarizes the stream with a local Ollama model, and builds interactive replays complete with synchronized chat, event timelines, game detection, and word cloud analytics.",
                LastUpdated = new DateTime(2026, 7, 4),
                Links = new List<ProjectModel.Link>()
                {
                    new ProjectModel.Link()
                    {
                        Name = "Site",
                        Url = "https://twitch.crownedhaley.com/"
                    }
                }
            });
            model.Add(new Models.ProjectModel()
            {
                Name = "Midwest DevOps API",
                ImgUrls = new() { "/img/Swagger.png", "/img/devenv_ybOoMibgXk.png", "/img/devenv_FZqHrwJiMH.png" },
                Description = "Designed REST API with 50+ endpoints for auth, employee management,permissions, and bulk operations.<br/><br/>Implemented RBAC/permissions and integrated third-party services.<br/><br/>Documented via Swagger/OpenAPI; secured endpoints and optimized common queries.",
                LastUpdated = new DateTime(2022, 6, 23),
                Links = new List<ProjectModel.Link>()
                {
                    //new ProjectModel.Link()
                    //{
                    //    Name = "Swagger",
                    //    Url = "https://api.midwestdevops.com/swagger/index.html"
                    //}
                }
            });

            model.Add(new Models.ProjectModel()
            {
                Name = "jellyfin2link",
                ImgUrls = new() { "/img/68747470733a2f2f66696c65732e63726f776e656468616c65792e636f6d2f752f6775576d5564746a38382e706e67.png", "/img/Renderite.Renderer_95FF91aWcD.gif", "/img/Renderite.Renderer_fj8C0XH8up.gif" },
                Description = "This website can display your jellyfin media library and provide api endpoints to run media from your jellyfin instance. This was made so that I can watch my media within Resonite.",
                LastUpdated = new DateTime(2026, 5, 7),
                Links = new List<ProjectModel.Link>()
                {
                    new ProjectModel.Link()
                    {
                        Name = "Repository",
                        Url = "https://github.com/HaleyMueller/jellyfin2link"
                    }
                }
            });

            model.Add(new Models.ProjectModel()
            {
                Name = "Cards",
                ImgUrls = new() { "/img/Cards.png", "/img/zen_EZr48V3aR6.gif", "/img/zen_MUt0Ju3Ei3.gif", "/img/zen_3hn3HcsbIL.png" },
                Warning = "WARNING: some text is NSFW on this site",
                Description = "This project is an online version of Cards Against Humanity where you can do an online game using SignalR. Also you can create your own cards and decks!",
                LastUpdated = new DateTime(2021, 10, 14),
                Links = new List<ProjectModel.Link>()
                {
                    //new ProjectModel.Link()
                    //{
                    //    Name = "Website",
                    //    Url = "https://cards.midwestdevops.com/"
                    //},
                    new ProjectModel.Link()
                    {
                        Name = "Repository",
                        Url = "https://github.com/Midwest-DevOps-LLC/Cards"
                    }
                }
            });

            //model.Add(new Models.ProjectModel()
            //{
            //    Name = "Food Tracker",
            //    ImgUrls = new() { "/img/FoodTracker.png" },
            //    Description = "This project will read Walmart reciepts from a single picture using Azure AI and track your purchase history.",
            //    LastUpdated = new DateTime(2021, 2, 15),
            //    Links = new List<ProjectModel.Link>()
            //    {
            //        new ProjectModel.Link()
            //        {
            //            Name = "Repository",
            //            Url = "https://github.com/Midwest-DevOps-LLC/FoodTracker"
            //        }
            //    }
            //});

            //TODO Set this up
            model.Add(new Models.ProjectModel()
            {
                Name = "Live Streaming",
                ImgUrls = new() { "/img/Livestream.png" },
                Description = "This project streams a video file on a website for other viewers to see. It has the ability for chat and Spotify control.",
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
                ImgUrls = new() { "/img/Arc_HoS65VRxQF.png" },
                Description = "This is my company's page where I can manage user accounts and their permissions for the projects I make.",
                LastUpdated = new DateTime(2022, 7, 4),
                Links = new List<ProjectModel.Link>()
                {
                    //new ProjectModel.Link()
                    //{
                    //    Name = "Website",
                    //    Url = "https://midwestdevops.com/"
                    //},
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
                ImgUrls = new() { "/img/InternetRadio.png" },
                Description = "This project streams audio from a folder on the host computer. It automatically updates it's playlist from a spotify playlist. Also you can add additional songs by using the built in Youtube or Spotify search. It even has custom ads!",
                LastUpdated = new DateTime(2022, 7, 4),
                Links = new List<ProjectModel.Link>()
                {
                    //new ProjectModel.Link()
                    //{
                    //    Name = "Repository",
                    //    Url = "https://github.com/Midwest-DevOps-LLC/Internet-Radio"
                    //}
                }
            });

            model.Add(new Models.ProjectModel()
            {
                Name = "Dominos C# API Wrapper",
                ImgUrls = new() { "/img/Dominos.png" },
                Description = "I was craving pizza one night so I traced most of the api Dominos uses on their website and created a wrapper for it. ",
                Warning = "Sadly no longer working. They have changed their api",
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
                Name = "CCDA Game Launcher",
                ImgUrls = new() { "/img/CDDA.png" },
                Description = "This project replaces an old github program that isn't updated anymore. I've recreated it to .net core so it can be multiplatform ",
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


            model.Add(new Models.ProjectModel()
            {
                Name = "This Site!",
                ImgUrls = new() { "/img/Website.png" },
                Description = "This project replaces an old github program that isn't updated anymore. I've recreated it to .net core so it can be multiplatform ",
                LastUpdated = new DateTime(2021, 2, 15),
                Links = new List<ProjectModel.Link>()
                {
                    new ProjectModel.Link()
                    {
                        Name = "Repository",
                        Url = "https://github.com/HaleyMueller/HaleyMueller-Dev"
                    }
                }
            });

            return model;
        }
    }
}
