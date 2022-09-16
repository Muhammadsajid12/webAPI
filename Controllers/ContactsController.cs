using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Data;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Controllers
{
    [ApiController]
    // Here we give the routes
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        private readonly ContactsAPIdbContext dbContext;

        public Guid Id { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }
        public string FullName { get; private set; }
        public long Phone { get; private set; }


        public ContactsController(ContactsAPIdbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // Method that get the All  data  from table
        [HttpGet]
        public async Task<IActionResult> GetContacts()
        {
            return Ok(await dbContext.Contacts.ToListAsync());
        }

        // Here we creating the  method that will put the data into table which have in model folder 
       /* [HttpPost]
        public async Task<IActionResult> AddContact(AddContactRequest addContactRequest)
        {
            // Here we are creating the obj this data go in this contact obj 
            var contact = new Contact();
            {
                Id = Guid.NewGuid();
                FullName = addContactRequest.FullName;
                Email = addContactRequest.Email;
                Phone = addContactRequest.Phone;
                Address = addContactRequest.Address;

            };
            // Here we adding the obj in database
            await dbContext.Contacts.AddAsync(contact);
            // Here save the changes.....
            await dbContext.SaveChangesAsync();

            return Ok(contact);
        } */

        /* [HttpPut]
         [Route("id{guid}")]
         public async Task<IActionResult> UpdateContact([FromRoute] Guid id, UpdataContactRequest updataContactRequest)
         {
             var contact = await dbContext.Contacts.FindAsync(id);
             if (contact != null)
             {
                 contact.FullName = updataContactRequest.FullName;
                 contact.Address = updataContactRequest.Address;
                 contact.Phone = updataContactRequest.Phone;
                 contact.Email = updataContactRequest.Email;

                 await dbContext.SaveChangesAsync();
                 return Ok(contact);
             }

             return NotFound();





         }*/
    }


}
