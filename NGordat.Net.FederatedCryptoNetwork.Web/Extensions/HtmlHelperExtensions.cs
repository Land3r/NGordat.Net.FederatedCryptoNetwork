using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NGordat.Net.FederatedCryptoNetwork.Web.Extensions
{
    public static class HtmlHelperExtensions
    {
        /// <summary>
        /// Retourne la classe CSS permettant de rendre actif le menu de navigation selon la page active
        /// </summary>
        /// <param name="html">Instance de IHtmlHelper</param>
        /// <param name="route">La route à vérifier (commençant par "/")</param>
        /// <param name="area">La zone (Area) depuis laquelle la page fait aprtie.</param>
        /// <param name="cssClass">Permet d'overrider la classe "active" définie par défaut</param>
        /// <returns></returns>
        public static string IsSelected(this IHtmlHelper html, string route, string area = null, string cssClass = null)
        {
            if (String.IsNullOrEmpty(cssClass))
                cssClass = "active";

            string currentRoute = (string)html.ViewContext.RouteData.Values["page"];
            string currentArea = (string)html.ViewContext.RouteData.Values["area"];

            // Vérification de l'Area
            if (!string.IsNullOrEmpty(currentArea) || !string.IsNullOrEmpty(area))
            {
                if (area?.ToUpperInvariant() != currentArea?.ToUpperInvariant())
                {
                    return string.Empty;
                }
            }

            // Vérification de la route.
            if (string.IsNullOrEmpty(currentRoute))
            {
                currentRoute = ((html.ViewContext.View as Microsoft.AspNetCore.Mvc.Razor.RazorView).RazorPage as RazorPage).Context.Request.Path;
            }

            if (String.IsNullOrEmpty(route))
                route = currentRoute;

            return currentRoute.ToUpperInvariant().StartsWith(route.ToUpperInvariant()) ?
                cssClass : String.Empty;
        }

    }
}
