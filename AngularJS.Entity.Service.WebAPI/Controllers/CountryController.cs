using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularJS.Entity.Service.WebAPI.Controllers
{
    public class CountryController : ApiController
    {
        // GET api/country  
        public IEnumerable<System.Web.Mvc.SelectListItem> Get()
        {
            List<System.Web.Mvc.SelectListItem> countries = new List<System.Web.Mvc.SelectListItem>
            {
                new System.Web.Mvc.SelectListItem
                {
                    Text = "India",
                    Value = "IN"
                },
                new System.Web.Mvc.SelectListItem
                {
                    Text = "United States",
                    Value = "US"
                },
                new System.Web.Mvc.SelectListItem
                {
                    Text = "United Kingdom",
                    Value = "UK"
                },
                new System.Web.Mvc.SelectListItem
                {
                    Text = "Australlia",
                    Value = "CA"
                }
            };
            return countries;
        }

        // GET api/country/5  
        public IEnumerable<System.Web.Mvc.SelectListItem> Get(string id)
        {
            List<System.Web.Mvc.SelectListItem> states = new List<System.Web.Mvc.SelectListItem>();
            switch (id)
            {
                case "IN":
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Maharashtra",
                        Value = "MH "
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Madhya Pradesh",
                        Value = "MP"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Delhi",
                        Value = "DL"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Kanpur",
                        Value = "KN"
                    });
                    break;
                case "US":
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "California",
                        Value = "CA"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Newyork",
                        Value = "NY"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "New Mexico",
                        Value = "NM"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Oklahoma",
                        Value = "OK"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Idaho",
                        Value = "ID"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Massachusetts",
                        Value = "MA"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Georgia",
                        Value = "GA"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Missouri",
                        Value = "MO"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "West Virginia",
                        Value = "WV"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Tennessee",
                        Value = "TN"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Maryland",
                        Value = "MD"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Texas",
                        Value = "TX"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Arizona",
                        Value = "AZ"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Nevada",
                        Value = "NV"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Arkansas",
                        Value = "AR"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Maine",
                        Value = "ME"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Virginia",
                        Value = "VA"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Michigan",
                        Value = "MI"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Minnesota",
                        Value = "MN"
                    });
                    break;
                case "UK":
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "London",
                        Value = "LN"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Liverpool",
                        Value = "LP"
                    }); states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Cornwall",
                        Value = "CO"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Berkshire",
                        Value = "BK"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Middlesex",
                        Value = "MX"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Gloucestershire",
                        Value = "GL"
                    });
                    break;
                case "CA":
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Sydney",
                        Value = "SD"
                    });
                    states.Add(new System.Web.Mvc.SelectListItem
                    {
                        Text = "Melbourne",
                        Value = "MB"
                    });
                    break;
            }
            return states;
        }
    }
}
