using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Microsoft.Owin.Security.Google;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using Microsoft.AspNet.Identity;
using Model;

namespace DemoLogin.App_Start
{
    public partial class Startup
    {
       

        public void ConfigureAuth(Owin.IAppBuilder app)
        {
            // Configure the db context and user manager to use a single instance per request
            //app.CreatePerOwinContext(ApplicationDbContext.Create);
            //app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);

            //// Enable the application to use a cookie to store information for the signed in user
            //// and to use a cookie to temporarily store information about a user logging in with a third party login provider
            //// Configure the sign in cookie
            //app.UseCookieAuthentication(new CookieAuthenticationOptions
            //{
            //    AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
            //    LoginPath = new PathString("/Account/Login"),
            //    Provider = new CookieAuthenticationProvider
            //    {
            //        OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<ApplicationUserManager, ApplicationUser>(
            //    validateInterval: TimeSpan.FromMinutes(30),
            //    regenerateIdentity: (manager, user) => user.GenerateUserIdentityAsync(manager))
            //    }
            //});

            //app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            //// Uncomment the following lines to enable logging in with third party login providers
            ////app.UseMicrosoftAccountAuthentication(
            ////    clientId: "",
            ////    clientSecret: "");

            ////app.UseTwitterAuthentication(
            ////   consumerKey: "",
            ////   consumerSecret: "");

            ////app.UseFacebookAuthentication(
            ////   appId: "",
            ////   appSecret: "");

            //app.UseGoogleAuthentication(
            //     clientId: "377929102115-rfkagvt86d2enofj6rmbm0p31186b0vq.apps.googleusercontent.com",
            //     clientSecret: "04tx5d6IPPEihxvCV2Or9i31");
        }

    }
}