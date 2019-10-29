using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace a101_backend.Services.DealService
{
    public class DealService : IDealService
    {
        public void SetStatus(string statusInfo)
        {
            string writePath = @"C:/a101_docs/dealStatus.txt";

            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(statusInfo);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return;
        }
    }
}
