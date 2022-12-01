using MyManagementApp.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestandoComponentes.Extensions
{
    public static class FormExtension
    {
        public static void NotifyError(this Form form)
        {
            form.NotifyError(Result.Factory.False());
        }
        public static void NotifyError(this Form form, Result r)
        {

            if (r.Success)
                return;

            var message = r.Messages.Any()
                ? "Some information probably is missing. Verify and try again"
                        + Environment.NewLine + "   - "
                        + string.Join(Environment.NewLine + "   - ", r.Messages)
                : "Some information probably is missing. Verify and try again";
            string caption = "Warning";
            DialogResult result;
            result = MessageBox.Show(message, caption);
        }
    }
}
