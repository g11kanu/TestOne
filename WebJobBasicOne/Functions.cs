using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace WebJobBasicOne
{
    public class Functions
    {
        // This function will get triggered/executed when a new message is written 
        // on an Azure Queue called queue.
        public static void ProcessQueueMessage([QueueTrigger("inputtext")] string message, [Blob("basic/out.txt")] out string output)
        {
            output = string.Format("{0} Processed at {1}", message, DateTime.Now.ToString());
        }
    }
}
