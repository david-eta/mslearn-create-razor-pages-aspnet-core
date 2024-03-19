using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ContosoPizza.Pages
{
    public class MessagesModel : PageModel
    {
        private readonly MessageStoreService _messageStoreService;
        public IEnumerable<string>? ServiceBusMessages { get; private set; }

        // Constructor for dependency injection
        public MessagesModel(MessageStoreService messageStoreService)
        {
            _messageStoreService = messageStoreService;
            ServiceBusMessages = new List<string>();
        }
        public void OnGet()
        {
            ServiceBusMessages = _messageStoreService.GetMessages();
        }
    }
}
