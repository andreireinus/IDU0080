namespace OpenERP.Web.Models
{
    using System;
    using System.ServiceModel;
    using System.Web.Mvc;
    using System.Web.Routing;

    public class BaseController : Controller
    {
        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            ViewBag.Errors = new ErrorsList();
            return base.BeginExecute(requestContext, callback, state);
        }

        private void AddErrorMessage(string message)
        {
            if (ViewBag.Errors is ErrorsList)
            {
                ((ErrorsList)ViewBag.Errors).AddMessage(message);
            }
        }

        private void AddErrorMessage(int code, string message)
        {
            this.AddErrorMessage(string.Format("[{0}] {1}", code, message));
        }

        protected void HandleException(Exception exception)
        {
            this.AddErrorMessage(exception.Message);

        }

        protected void RunSafe(Action action)
        {
            try
            {
                action();
            }
            catch (FaultException<WCF.Customer.BusinessLogicFault> exception)
            {
                this.AddErrorMessage(exception.Detail.Code, exception.Detail.Message);
            }
            catch (FaultException<WCF.Invoice.BusinessLogicFault> exception)
            {
                this.AddErrorMessage(exception.Detail.Code, exception.Detail.Message);
            }
            catch (FaultException<WCF.Payment.BusinessLogicFault> exception)
            {
                this.AddErrorMessage(exception.Detail.Code, exception.Detail.Message);
            }
            catch (FaultException<WCF.Product.BusinessLogicFault> exception)
            {
                this.AddErrorMessage(exception.Detail.Code, exception.Detail.Message);
            }
            catch (FaultException<WCF.Delivery.BusinessLogicFault> exception)
            {
                this.AddErrorMessage(exception.Detail.Code, exception.Detail.Message);
            }
            catch (Exception exception)
            {
                this.HandleException(exception);
            }
        }
    }
}