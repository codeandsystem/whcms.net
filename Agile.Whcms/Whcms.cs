using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace Agile.Whcms
{
    public class Whcms
    {
        private readonly string _username;
        private readonly string _md5Password;
        private readonly RestClient _client;

        public Whcms(string whcmsUrl, string username, string password)
        {
            _username = username;

            byte[] computeHash = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < computeHash.Length; i++)
            {
                sBuilder.Append(computeHash[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            _md5Password = sBuilder.ToString();



            _client = new RestClient(whcmsUrl);



        }

        private RestRequest _CreateRequest(string action)
        {
            RestRequest request = new RestRequest("POST");
            request.AddParameter("username", _username);
            request.AddParameter("password", _md5Password);
            request.AddParameter("responsetype", "xml");
            request.AddParameter("action", action);

            return request;
        }
        public AddClientResponse AddClient() { throw new NotImplementedException(); }
        public UpdateClientResponse UpdateClient() { throw new NotImplementedException(); }
        public DeleteClientResponse DeleteClient() { throw new NotImplementedException(); }
        public CloseClientResponse CloseClient() { throw new NotImplementedException(); }
        public AddClientNoteResponse AddClientNote() { throw new NotImplementedException(); }

        private T _Execute<T>(IRestRequest request) where T : new()
        {
            IRestResponse<T> response = _client.Execute<T>(request);
            if(response.StatusCode != HttpStatusCode.OK)
                throw new WebException(response.StatusDescription);

            if (response.ErrorException != null)
                throw response.ErrorException;
            return response.Data;
        }
        public GetClientsResponse GetClients()
        {
            RestRequest request = _CreateRequest("getclients");
            return _Execute<GetClientsResponse>(request);

        }
        public GetClientsResponse GetClientsDetails() { throw new NotImplementedException(); }
        public GetCreditsResponse GetCredits() { throw new NotImplementedException(); }
        public GetEmailsResponse GetEmails() { throw new NotImplementedException(); }
        public GetClientQuotesResponse GetClientQuotes() { throw new NotImplementedException(); }
        public GetClientsPasswordResponse GetClientsPassword() { throw new NotImplementedException(); }
        public GetClientTransactionsResponse GetClientTransactions() { throw new NotImplementedException(); }
        public AddContactResponse AddContact() { throw new NotImplementedException(); }
        public GetContactsResponse GetContacts() { throw new NotImplementedException(); }
        public UpdateContactResponse UpdateContact() { throw new NotImplementedException(); }
        public DeleteContactResponse DeleteContact() { throw new NotImplementedException(); }
        public GetClientProductsResponse GetClientProducts() { throw new NotImplementedException(); }
        public UpdateClientProductResponse UpdateClientProduct() { throw new NotImplementedException(); }
        public GetClientsAddonsResponse GetClientsAddons() { throw new NotImplementedException(); }
        public UpdateClientAddonResponse UpdateClientAddon() { throw new NotImplementedException(); }
        public GetClientsDomainsResponse GetClientsDomains() { throw new NotImplementedException(); }
        public UpdateClientDomainResponse UpdateClientDomain() { throw new NotImplementedException(); }
        public AddCancelRequestResponse AddCancelRequest() { throw new NotImplementedException(); }
        public UpgradeProductResponse UpgradeProduct() { throw new NotImplementedException(); }
        public ValidateLoginResponse ValidateLogin() { throw new NotImplementedException(); }
        public SendEmailResponse SendEmail() { throw new NotImplementedException(); }


        public RegisterDomainResponse RegisterDomain() { throw new NotImplementedException(); }
        public RenewDomainResponse RenewDomain() { throw new NotImplementedException(); }
        public TransferDomainResponse TransferDomain() { throw new NotImplementedException(); }
        public ReleaseDomainResponse ReleaseDomain() { throw new NotImplementedException(); }
        public GetDomainLockResponse GetDomainLock() { throw new NotImplementedException(); }
        public GetNameserversResponse GetNameservers() { throw new NotImplementedException(); }
        public GetWHOISResponse GetWHOIS() { throw new NotImplementedException(); }
        public RequestEPPResponse RequestEPP() { throw new NotImplementedException(); }
        public ToggleIDProtectResponse ToggleIDProtect() { throw new NotImplementedException(); }
        public UpdateLockResponse UpdateLock() { throw new NotImplementedException(); }
        public UpdateNameserversResponse UpdateNameservers() { throw new NotImplementedException(); }
        public UpdateWHOISResponse UpdateWHOIS() { throw new NotImplementedException(); }
        public DomainWHOISLookupResponse DomainWHOISLookup() { throw new NotImplementedException(); }


        public ModuleCreateResponse ModuleCreate() { throw new NotImplementedException(); }
        public ModuleSuspendResponse ModuleSuspend() { throw new NotImplementedException(); }
        public ModuleUnsuspendResponse ModuleUnsuspend() { throw new NotImplementedException(); }
        public ModuleTerminateResponse ModuleTerminate() { throw new NotImplementedException(); }
        public ModuleChangePackageResponse ModuleChangePackage() { throw new NotImplementedException(); }
        public ModuleChangePasswordResponse ModuleChangePassword() { throw new NotImplementedException(); }


        public OpenTicketResponse OpenTicket() { throw new NotImplementedException(); }
        public ReplyTicketResponse ReplyTicket() { throw new NotImplementedException(); }
        public GetTicketsResponse GetTickets() { throw new NotImplementedException(); }
        public GetTicketResponse GetTicket() { throw new NotImplementedException(); }
        public UpdateTicketResponse UpdateTicket() { throw new NotImplementedException(); }
        public DeleteTicketResponse DeleteTicket() { throw new NotImplementedException(); }
        public AddTicketNoteResponse AddTicketNote() { throw new NotImplementedException(); }
        public GetTicketNotesResponse GetTicketNotes() { throw new NotImplementedException(); }
        public DeleteTicketNoteResponse DeleteTicketNote() { throw new NotImplementedException(); }
        public GetSupportDepartmentsResponse GetSupportDepartments() { throw new NotImplementedException(); }
        public GetSupportStatusesResponse GetSupportStatuses() { throw new NotImplementedException(); }
        public GetTicketPredefinedCategoriesResponse GetTicketPredefinedCategories() { throw new NotImplementedException(); }
        public GetTicketPredefinedRepliesResponse GetTicketPredefinedReplies() { throw new NotImplementedException(); }
        public AddAnnouncementResponse AddAnnouncement() { throw new NotImplementedException(); }
        public DeleteAnnouncementResponse DeleteAnnouncement() { throw new NotImplementedException(); }
        public UpdateAnnouncementResponse UpdateAnnouncement() { throw new NotImplementedException(); }
        public GetAnnouncementsResponse GetAnnouncements() { throw new NotImplementedException(); }


        public AddOrderResponse AddOrder() { throw new NotImplementedException(); }
        public GetOrdersResponse GetOrders() { throw new NotImplementedException(); }
        public GetProductsResponse GetProducts() { throw new NotImplementedException(); }
        public GetORderPromotionsResponse GetORderPromotions() { throw new NotImplementedException(); }
        public GetOrderStatusesResponse GetOrderStatuses() { throw new NotImplementedException(); }
        public AcceptOrderResponse AcceptOrder() { throw new NotImplementedException(); }
        public PendingOrderResponse PendingOrder() { throw new NotImplementedException(); }
        public CancelOrderResponse CancelOrder() { throw new NotImplementedException(); }
        public FraudOrderResponse FraudOrder() { throw new NotImplementedException(); }
        public DeleteOrderResponse DeleteOrder() { throw new NotImplementedException(); }


        public GetInvoicesResponse GetInvoices(int? userid = null, string status = null, int? limitstart = null, int? limitnum = null)
        {
            RestRequest request = _CreateRequest("getinvoices");
            if (userid.HasValue)
                request.AddParameter("userid", userid);
            if (!string.IsNullOrWhiteSpace(status))
                request.AddParameter("status", status);
            if (limitstart.HasValue)
                request.AddParameter("limitstart", limitstart);
            if (limitnum.HasValue)
                request.AddParameter("limitnum", limitnum);

            GetInvoicesResponse response = _Execute<GetInvoicesResponse>(request);
            return response;
        }
        public GetInvoiceResponse GetInvoice() { throw new NotImplementedException(); }
        public CreateInvoiceResponse CreateInvoice() { throw new NotImplementedException(); }
        public UpdateInvoiceResponse UpdateInvoice() { throw new NotImplementedException(); }
        public AddInvoicePaymentResponse AddInvoicePayment() { throw new NotImplementedException(); }
        public CapturePaymentResponse CapturePayment() { throw new NotImplementedException(); }
        public ApplyCreditResponse ApplyCredit() { throw new NotImplementedException(); }
        public AddBillableItemResponse AddBillableItem() { throw new NotImplementedException(); }
        public AddCreditResponse AddCredit() { throw new NotImplementedException(); }
        public AddTransactionResponse AddTransaction() { throw new NotImplementedException(); }
        public GetTransactionsResponse GetTransactions() { throw new NotImplementedException(); }
        public UpdateTransactionResponse UpdateTransaction() { throw new NotImplementedException(); }
        public GenerateInvoicesResponse GenerateInvoices() { throw new NotImplementedException(); }
        public GetPaymentMethodsResponse GetPaymentMethods() { throw new NotImplementedException(); }

        public CreateQuoteResponse CreateQuote() { throw new NotImplementedException(); }
        public UpdateQuoteResponse UpdateQuote() { throw new NotImplementedException(); }
        public DeleteQuoteResponse DeleteQuote() { throw new NotImplementedException(); }
        public SendQuoteResponse SendQuote() { throw new NotImplementedException(); }
        public AcceptQuoteResponse AcceptQuote() { throw new NotImplementedException(); }
        public GetQuotesResponse GetQuotes() { throw new NotImplementedException(); }


        public GetActivityLogResponse GetActivityLog() { throw new NotImplementedException(); }
        public GetAdminDetailsResponse GetAdminDetails() { throw new NotImplementedException(); }
        public UpdateAdminNotesResponse UpdateAdminNotes() { throw new NotImplementedException(); }
        public GetCurrenciesResponse GetCurrencies() { throw new NotImplementedException(); }
        public GetPromotionsResponse GetPromotions() { throw new NotImplementedException(); }
        public GetClientGroupsResponse GetClientGroups() { throw new NotImplementedException(); }
        public GetEmailTemplatesResponse GetEmailTemplates()
        {
            throw new NotImplementedException();
        }
        public GetToDoItemsResponse GetToDoItems() { throw new NotImplementedException(); }
        public GetToDoItemStatusesResponse GetToDoItemStatuses() { throw new NotImplementedException(); }
        public UpdateToDoItemResponse UpdateToDoItem() { throw new NotImplementedException(); }
        public GetStaffOnlineResponse GetStaffOnline() { throw new NotImplementedException(); }
        public GetStatsResponse GetStats() { throw new NotImplementedException(); }
        public EncryptPasswordResponse EncryptPassword() { throw new NotImplementedException(); }
        public DecryptPasswordResponse DecryptPassword()
        {
            throw new NotImplementedException();
        }
        public AddBannedIPResponse AddBannedIP() { throw new NotImplementedException(); }
        public AddProductResponse AddProduct() { throw new NotImplementedException(); }
        public LogActivityResponse LogActivity() { throw new NotImplementedException(); }

        public SendAdminEmailResponse SendAdminEmail()
        {
            throw new NotImplementedException();
        }
    }

    public class AddCancelRequestResponse { }

    public class UpgradeProductResponse { }

    public class ModuleChangePasswordResponse { }

    public class ModuleChangePackageResponse { }

    public class UpdateLockResponse { }

    public class ModuleUnsuspendResponse { }

    public class GetClientsDomainsResponse { }

    public class GetWHOISResponse { }

    public class GetDomainLockResponse { }

    public class GetClientsAddonsResponse { }

    public class ValidateLoginResponse { }

    public class UpdateWHOISResponse { }

    public class UpdateClientProductResponse { }

    public class DeleteContactResponse { }

    public class UpdateClientAddonResponse { }

    public class RequestEPPResponse { }

    public class ToggleIDProtectResponse { }

    public class SendEmailResponse { }

    public class GetNameserversResponse { }

    public class UpdateContactResponse { }

    public class UpdateClientDomainResponse { }

    public class ReleaseDomainResponse { }

    public class AddTicketNoteResponse { }

    public class UpdateNameserversResponse { }

    public class ModuleCreateResponse { }

    public class GetContactsResponse { }

    public class GetClientProductsResponse { }

    public class DeleteTicketNoteResponse { }

    public class DomainWHOISLookupResponse { }

    public class DeleteTicketResponse { }

    public class UpdateTicketResponse { }

    public class ModuleSuspendResponse { }

    public class GetTicketResponse { }

    public class AddContactResponse { }

    public class GetTicketsResponse { }

    public class ReplyTicketResponse { }

    public class RenewDomainResponse { }

    public class GetClientTransactionsResponse { }

    public class GetClientsPasswordResponse { }

    public class GetSupportStatusesResponse { }

    public class RegisterDomainResponse { }

    public class GetTicketPredefinedRepliesResponse { }

    public class TransferDomainResponse { }

    public class GetClientQuotesResponse { }

    public class ModuleTerminateResponse { }

    public class AddAnnouncementResponse { }

    public class DeleteAnnouncementResponse { }

    public class OpenTicketResponse { }

    public class GetTicketPredefinedCategoriesResponse { }

    public class UpdateAnnouncementResponse { }

    public class AddOrderResponse { }

    public class GetOrdersResponse { }

    public class AcceptOrderResponse { }

    public class GetAnnouncementsResponse { }

    public class GetEmailsResponse { }

    public class GetCreditsResponse { }

    public class AddClientNoteResponse { }

    public class CloseClientResponse { }

    public class DeleteClientResponse { }

    public class GetTicketNotesResponse { }

    public class CancelOrderResponse { }

    public class PendingOrderResponse { }

    public class UpdateClientResponse { }

    public class GetProductsResponse { }

    public class FraudOrderResponse { }

    public class GenerateInvoicesResponse { }

    public class UpdateQuoteResponse { }

    public class DeleteOrderResponse { }

    public class GetPaymentMethodsResponse { }

    public class GetOrderStatusesResponse { }

    public class CreateQuoteResponse { }

    public class GetTransactionsResponse { }

    public class SendQuoteResponse { }

    public class AcceptQuoteResponse { }

    public class AddTransactionResponse { }

    public class AddBillableItemResponse { }

    public class GetInvoicesResponse
    {
        [XmlElement("totalresults")]
        public int TotalResults { get; set; }

        [XmlElement("startnumber")]
        public int StartNumber { get; set; }

        [XmlElement("numreturned")]
        public int NumReturned { get; set; }

      
        [XmlArray("invoices")]
        [XmlArrayItem("invoice")]
        public List<Invoice> Invoices { get; set; }

    }

    public class Invoice
    {
        [XmlElement("id")]
        public int Id { get; set; }

        [XmlElement("userid")]
        public int UserId { get; set; }

        [XmlElement("invoicenum")]
        public string InvoiceNum { get; set; }

        [XmlElement("date")]
        public string Date { get; set; }
        [XmlElement("datepaid")]

        public string Datepaid { get; set; }
             [XmlElement("duedate")]
        public string DueDate
        {
            get;
            set;

        }
        [XmlElement("subtotal")]
        public decimal Subtotal { get; set; }
        [XmlElement("credit")]
        public decimal Credit { get; set; }
        [XmlElement("tax")]
        public decimal Tax { get; set; }
        [XmlElement("tax2")]
        public decimal Tax2 { get; set; }
        [XmlElement("total")]
        public decimal Total { get; set; }
        [XmlElement("taxrate")]
        public decimal TaxRate { get; set; }
        [XmlElement("taxrate2")]
        public decimal TaxRate2 { get; set; }
        [XmlElement("status")]
        public string Status { get; set; }
        [XmlElement("paymentmethod")]
        public string PaymentMethod { get; set; }
        [XmlElement("notes")]
        public string Notes { get; set; }

    }

    public class GetORderPromotionsResponse { }

    public class AddCreditResponse { }

    public class CreateInvoiceResponse { }

    public class AddInvoicePaymentResponse { }

    public class CapturePaymentResponse { }

    public class ApplyCreditResponse { }

    public class GetSupportDepartmentsResponse { }

    public class GetCurrenciesResponse { }

    public class UpdateInvoiceResponse { }

    public class SendAdminEmailResponse { }

    public class GetClientGroupsResponse { }

    public class GetAdminDetailsResponse { }

    public class DeleteQuoteResponse { }

    public class GetPromotionsResponse { }

    public class UpdateTransactionResponse { }

    public class UpdateAdminNotesResponse { }

    public class EncryptPasswordResponse { }

    public class GetEmailTemplatesResponse { }

    public class GetStaffOnlineResponse { }

    public class LogActivityResponse { }

    public class AddBannedIPResponse { }

    public class AddProductResponse { }

    public class GetInvoiceResponse { }

    public class UpdateToDoItemResponse { }

    public class GetQuotesResponse { }

    public class GetToDoItemsResponse { }

    public class GetActivityLogResponse { }

    public class GetToDoItemStatusesResponse { }

    public class GetStatsResponse { }

    public class DecryptPasswordResponse { }

    public class AddClientResponse { }
}
