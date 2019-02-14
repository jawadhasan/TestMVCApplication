using System;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using MbmStore.Models;

namespace MbmStore.Helpers
{
    public static class HtmlHelperExtensions
    {
        private static string BuildCustomerHtml(this HtmlHelper helper, Customer customer)
        {
            var sb = new StringBuilder();

            var customerIntroduction = $"{customer.FirstName} {customer.LastName}";
            if (customer.Birthdate != DateTime.MinValue)
            {
                customerIntroduction = $"{customerIntroduction} is {customer.Age} years old";
            }

            sb.AppendLine("<div class='card border-success mb-3'>");

                sb.AppendLine("<div class='card-header text-white bg-primary'>");
                sb.AppendLine("<i class='fa fa-user fa-2x'></i>");
                sb.AppendLine($"{customerIntroduction}");
                sb.AppendLine("</div>");

                sb.AppendLine("<div class='card-body'>");

            //Address-Block
                    sb.AppendLine("<div class='address-block'>");
                    sb.AppendLine("<i class='fa fa-address-card fa-2x'></i>");
                    sb.AppendLine("<br />");
                    sb.AppendLine($"<h5'>{customer.Address}</h5>");
                    sb.AppendLine("<br />");
                    sb.AppendLine($"<h6'>{customer.Zip} {customer.City}</h5>");
                    sb.AppendLine("</div>"); //Address-Div

                    sb.AppendLine("<br />");

            //PhoneNumbers-Block
                    sb.AppendLine("<div class='phone-block'>");
                    sb.AppendLine("<i class='fa fa-mobile fa-2x'></i>");
                    sb.AppendLine("<br />");
                    sb.AppendLine(string.Join(", ", customer.PhoneNumbers.ToList()));
                  
                    sb.AppendLine("</div>"); //Phone-Div


            sb.AppendLine("</div>");//end card-body
            
            sb.AppendLine("</div>");//End card

          
            return sb.ToString();
        }


        public static MvcHtmlString RenderCustomer(this HtmlHelper helper, Customer customer)
        {
            return new MvcHtmlString(BuildCustomerHtml(helper, customer));
        }

    }
}