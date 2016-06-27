﻿using System.Web.Configuration;

namespace TaskRouter.Web.Infraestructure
{
    public class Config
    {
        public static string AccountSID
        {
            get { return WebConfigurationManager.AppSettings["AccountSID"]; }
        }

        public static string AuthToken
        {
            get { return WebConfigurationManager.AppSettings["AuthToken"]; }
        }

        public static string HostUrl
        {
            get { return WebConfigurationManager.AppSettings["HostUrl"]; }
        }

        public static string AgentForProgrammableVoice
        {
            get { return WebConfigurationManager.AppSettings["AgentForProgrammableVoice"]; }
        }

        public static string AgentForProgrammableSMS
        {
            get { return WebConfigurationManager.AppSettings["AgentForProgrammableSMS"]; }
        }
    }
}