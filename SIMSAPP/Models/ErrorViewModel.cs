using System;

namespace SIMSAPP.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        //TEST
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public void GetOn()
        {

        }
    }
}
