using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager mortgageLoanCreditManager = new MortgageLoanCreditManager();
            ICreditManager artisanLoanCreditManager = new ArtisanLoanCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsloggerService = new SmsLoggerService();

            List<ILoggerService> logger = new List<ILoggerService>() { databaseLoggerService, smsloggerService};

            RecourseManager recourseManager = new RecourseManager();
            recourseManager.ToApply(transportCreditManager,new List<ILoggerService> {fileLoggerService });
            Console.WriteLine("------------------------------------");
            recourseManager.ToApply(artisanLoanCreditManager,logger);

            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager,transportCreditManager };
            
            //recourseManager.CreditPreNotification(credits);
        }
    }
}
// ToApply = Başvurmak
// ArtisanLoan = Esnaf Kredisi
// Recourse = Başvuru
// Mortgage Loan = Konut Kredisi
// Personel Finance credit = İhtiyaç Kredisi
// Credit Pre-Notification = Kredi ön bildirimi
// Get Printouts = Çıktı Alın