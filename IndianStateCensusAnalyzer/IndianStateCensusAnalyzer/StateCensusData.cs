using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyzer
{
    public class StateCesusData
    {
        string state;
        string population;
        string area;
        string density;
        int serialNumber;
        string stateName;
        int tin;
        string stateCode;

        public StateCesusData(CensusStateCode censusStateCode)
        {
            this.stateName = censusStateCode.stateName;
            this.serialNumber = censusStateCode.serialNumber;
            this.tin = censusStateCode.tin;
            this.stateCode = censusStateCode.stateCode;
        }

        public StateCesusData(string state, string population, string area, string density)
        {
            this.state = state;
            this.population = population;
            this.area = area;
            this.density = density;
        }
    }
    public class CensusStateCode
    {
        public int serialNumber;
        public string stateName;
        public int tin;
        public string stateCode;

        public CensusStateCode(string serialNumber, string stateName, string tin, string stateCode)
        {
            this.serialNumber = Convert.ToInt32(serialNumber);
            this.stateName = stateName;
            this.tin = Convert.ToInt32(tin);
            this.stateCode = stateCode;
        }
    }
}
