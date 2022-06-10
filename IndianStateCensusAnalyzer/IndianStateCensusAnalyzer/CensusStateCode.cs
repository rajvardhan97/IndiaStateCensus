namespace IndianStateCensusAnalyzer
{
    public class CensusStateCode
    {
        public string SerialNumber;
        public string StateName;
        public string Tin;
        public string StateCode;

        public CensusStateCode(string serialnumber, string statename, string tin, string statecode)
        {
            this.SerialNumber = serialnumber;
            this.StateName = statename;
            this.Tin = tin;
            this.StateCode = statecode;
        }
    }
}