using SampleArch.Model.Common;
using SampleArch.Service.Common;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace SampleArch.WebApi.Controllers.Base
{
    /// <summary>
    /// BaseApiController{T} - base controller for CRUD
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class BaseApiController<T> : ApiController where T : BaseEntity, IEntity<long>, new()
    {
        #region Local Properties / Fields
        //
        /// <summary>
        /// The _cancellation token source
        /// </summary>
        private readonly CancellationTokenSource _cancellationTokenSource;

        /// <summary>
        /// The _cancellation token
        /// </summary>
        private readonly CancellationToken _cancellationToken;

        /// <summary>
        /// The _service
        /// </summary>
        private readonly IEntityService<T> _service;
        //
        #endregion Local Properties / Fields

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApiController{T}" /> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public BaseApiController(IEntityService<T> service)
        {
            _service = service;

            _cancellationTokenSource = new CancellationTokenSource();
            _cancellationToken = _cancellationTokenSource.Token;
        }

        #region CRUD 
        //
        // GET: api/{T}
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>
        /// IEnumerable{T}
        /// </returns>
        [ResponseType(typeof(IEnumerable))]
        public virtual IEnumerable<T> GetAll()
        {
            return _service.GetAll();
        }

        // GET: api/{T}/5
        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// {T}
        /// </returns>
        [ResponseType(typeof(IHttpActionResult))]
        public virtual async Task<IHttpActionResult> Get(int id)
        {
            var entity = await _service.GetByIdAsync(id, _cancellationToken);

            if (entity != null) return Ok(entity);
            _cancellationTokenSource.Cancel();

            return NotFound();
        }

        // PUT: api/{T}/5
        /// <summary>
        /// Puts the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// {T}
        /// </returns>
        [ResponseType(typeof(IHttpActionResult))]
        public virtual async Task<IHttpActionResult> Put(int id, T entity)
        {
            if (!ModelState.IsValid)
            {
                _cancellationTokenSource.Cancel();
                return BadRequest(ModelState);
            }

            //Id is a required field to pass currently
            if (id != entity.Id)
            {
                _cancellationTokenSource.Cancel();
                return NotFound();
            }

            try
            {
                if (Exists(id))
                {
                    await _service.UpdateAsync(entity, _cancellationToken);
                    //--> UnitOfWork gets called on Update, Save called there
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                if (Exists(id)) throw;
                _cancellationTokenSource.Cancel();

                return NotFound();
            }

            return Ok(entity);
        }

        // POST: api/{T}
        /// <summary>
        /// Posts the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// {T}
        /// </returns>
        [ResponseType(typeof(IHttpActionResult))]
        public virtual async Task<IHttpActionResult> Post(T entity)
        {
            if (!ModelState.IsValid)
            {
                _cancellationTokenSource.Cancel();
                return BadRequest(ModelState);
            }

            entity = await _service.AddAsync(entity, _cancellationToken);
            //--> UnitOfWork gets called on Update, Save called there

            return CreatedAtRoute("DefaultApi", new { id = entity.Id }, entity);
        }

        // DELETE: api/{T}/5
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// {T}
        /// </returns>
        [ResponseType(typeof(IHttpActionResult))]
        public virtual async Task<IHttpActionResult> Delete(int id)
        {
            var entity = await _service.GetByIdAsync(id, _cancellationToken).ConfigureAwait(true); ;
            if (entity == null)
            {
                _cancellationTokenSource.Cancel();
                return NotFound();
            }

            entity = await _service.DeleteAsync(entity, _cancellationToken);
            //--> UnitOfWork gets called on Update, Save called there

            return Ok(entity);
        }

        /// <summary>
        /// Exists the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// bool
        /// </returns>
        [ResponseType(typeof(bool))]
        private bool Exists(int id)
        {
            return _service.FindBy(e => e.Id == id).Any();
        }
        //
        //
        #endregion CRUD 

        /// <summary>
        /// Releases the unmanaged resources that are used by the object and, optionally, releases the managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //any resources created
                if(_cancellationTokenSource != null)
                {
                    _cancellationTokenSource.Dispose();
                }
            }
            base.Dispose(disposing);
        }
    }
}