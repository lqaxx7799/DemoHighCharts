using DemoHighCharts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace DemoHighCharts.Controllers
{
    public class StatisticController : ApiController
    {
        private readonly CoffeeShopDBEntities db = new CoffeeShopDBEntities();
        public IHttpActionResult Get()
        {
            var revenueList = new List<double>();
            var dateList = new List<DateTime>();
            var dataOrder = db.DirectOrders.ToList();
            var currentDate = dataOrder[0].ArrivedTime.Value.Date;

            revenueList.Add(0);
            dateList.Add(currentDate);

            foreach (var row in dataOrder)
            {
                double priceCount = 0;
                foreach (var detail in row.DirectOrderDetails)
                {
                    priceCount += detail.PriceEach.Value * detail.Amount.Value;
                }

                if (row.ArrivedTime.Value.Date == currentDate)
                {
                    revenueList[revenueList.Count - 1] += priceCount;
                }
                else
                {
                    revenueList.Add(priceCount);
                    currentDate = row.ArrivedTime.Value.Date;
                    dateList.Add(currentDate);
                }
            }

            return Ok(new
            {
                data = revenueList,
                label = dateList,
                success = true
            });
        }

        public IHttpActionResult Post()
        {
            var txtName = HttpContext.Current.Request.Params["txtName"];
            return Ok(new
            {
                message = "Register successfully! Hello " + txtName + "!"
            });
        }
    }
}
