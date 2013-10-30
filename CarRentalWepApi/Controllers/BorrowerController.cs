using CarRental.EFDBModel;
using CarRentalContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CarRentalWepApi.Controllers
{
    public class BorrowerController : ApiController
    {
        CarRentalCtx _ctx = new CarRentalCtx();
        
        public async Task<HttpResponseMessage> Get(int id)
        {
            HttpResponseMessage _retVal = null;

             Borrower _val = _ctx.Borrower.SingleOrDefault(a => a.BorrowerID == id);
            // Returning the list of message details and an OK status for every successful request by the client
             _retVal = Request.CreateResponse<Borrower>(HttpStatusCode.OK, _val);

            return _retVal;
        }

        public async Task<HttpResponseMessage> Post([FromBody]Borrower value)
        {
            HttpResponseMessage _retVal = null;

            using (CarRentalCtx _carctx = new CarRentalCtx())
            {
                try
                {
                    // Inserting new Message record
                    Borrower _val = value;

                    _ctx.Borrower.Add(_val);

                    _ctx.SaveChanges();

                    // Returning the newly created Message and a Created status for every successful request by the client
                    _retVal = Request.CreateResponse<Borrower>(HttpStatusCode.Created, _val);
                }
                catch (Exception e)
                {
                    // Returning a status depending on the exception caught by the server upon client's request
                    _retVal = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
                }
            }

            return _retVal; // Return the response
        
        }

       
        public async Task<HttpResponseMessage> Put(int id, [FromBody]Borrower value)
        {
            HttpResponseMessage _retVal = null;

            using (CarRentalCtx _carctx = new CarRentalCtx())
            {
                try
                {
                    Borrower _val = value;

                    Borrower _return = _ctx.Borrower.Find(id);

                    _return = value;

                    

                    // Returning the newly created Message and a Created status for every successful request by the client
                    _retVal = Request.CreateResponse<Borrower>(HttpStatusCode.Created, _val);
                }
                catch (Exception e)
                {
                    // Returning a status depending on the exception caught by the server upon client's request
                    _retVal = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
                }
            }

            return _retVal; // Return the response

        }

        // DELETE api/<controller>/5
        /// <summary>
        /// A method to delete a record in Message that return a response message to inform the client about the status of its request.
        /// </summary>
        /// <param name="id">The id pointing to the Message to be deleted.</param>
        /// <returns>An HttpResponseMessage to inform the client the status of its request.</returns>
        public async Task<HttpResponseMessage> Delete(int id)
        {
     
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="op"></param>
        /// <param name="pgNm"></param>
        /// <param name="pgSz"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> Get()
        {
         
        }
    }
}
