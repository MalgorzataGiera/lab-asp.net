using laboratorium_3___App.Controllers;
using laboratorium_3___App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_9___test
{
    public class ContactControllerTest
    {
        private ContactController _controller;
        private IContactService _service;
        private IDateTimeProvider _dateTimeProvider;
        public ContactControllerTest()
        {
            _service = new MemoryContactService(_dateTimeProvider);
            _service.Add(new Contact() { Id = 1 });
            _service.Add(new Contact() { Id = 2 });
            _controller = new ContactController(_service);
        }

        [Fact]
        public void IndexTest()
        {
            var result = _controller.Index();
            Assert.IsType<ViewResult>(result);

            var view = result as ViewResult;

            var model = view.Model as List<Contact>;
            Assert.Equal(2, model.Count());
        }

        [Theory]
        [InlineData(1)]
        public void DetailsTestForExistingContacts(int id)
        {
            
        }

        [Fact]
        public void DetailsTestForNonExistingContacts() 
        {
            var result = _controller.Details(4);
            Assert.IsType<NotFoundResult>(result);
        }
    }
}