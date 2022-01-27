
namespace BankInfo
{


    public class Customer
{
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
}

 public class BankReport
    {
        public string BankName { get; set; }
        public int BankCount { get; set; }
    }
   
        

            
}


/*
    Given the same customer set, display how many millionaires per bank.
    Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

    Example Output:
    WF 2
    BOA 1
    FTB 1
    CITI 1
*/