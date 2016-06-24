using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;

namespace EHIUtils
{
    public class Javascript
    {
        /// <summary>
        /// Show bootstrap modal
        /// </summary>
        /// <param name="control">Just input 'this' refers to the page</param>
        /// <param name="pageObject">Just input 'this' refers to the page obj</param>
        /// <param name="modalId">The Id of the modal div</param>
        public static void ShowModal(Control control, Page pageObject, string modalId)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("$('#" + modalId + "').modal('show');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(control, pageObject.GetType(), Guid.NewGuid().ToString(), sb.ToString(), false);
        }

        /// <summary>
        /// Hide bootstrap modal
        /// </summary>
        /// <param name="control">Just input 'this' refers to the page</param>
        /// <param name="pageObject">Just input 'this' refers to the page obj</param>
        /// <param name="modalId">The Id of the modal div</param>
        public static void HideModal(Control control, Page pageObject, string modalId)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("$('#" + modalId + "').modal('hide');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(control, pageObject.GetType(), Guid.NewGuid().ToString(), sb.ToString(), false);
        }
    }
}
