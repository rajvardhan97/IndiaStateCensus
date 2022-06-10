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
        string serialNumber;
        string stateName;
        string tin;
        string stateCode;

        public StateCesusData(CensusStateCode censusStateCode)
        {
            this.stateName = censusStateCode.StateName;
            this.serialNumber = censusStateCode.SerialNumber;
            this.tin = censusStateCode.Tin;
            this.stateCode = censusStateCode.StateCode;
        }

        public StateCesusData(string state, string population, string area, string density)
        {
            this.state = state;
            this.population = population;
            this.area = area;
            this.density = density;
        }
    }
}
