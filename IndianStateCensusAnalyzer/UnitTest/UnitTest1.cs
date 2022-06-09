using NUnit.Framework;

namespace IndianStateCensusAnalyzer
{
    public class Tests
    {
        CensusAnalyzer censusAnalyzer;
        string path = @"G:\RFP\IndiaStateCensus\IndianStateCensusAnalyzer\CsvFile\";
        string file = "IndiaStateCensusData.csv";
        string InvalidFile = "IndiaStateCode.txt";
        string InvalidDelimiter = "DelimiterIndiaStateCensusData.csv";
        string InvalidHeader = "WrongIndiaStateCensusData.csv";

        [SetUp]
        public void Setup()
        {
            censusAnalyzer = new CensusAnalyzer();
        }

        // TC 1.1: Given the States Census CSV file, Check to ensure the Number of Record matches
        [Test]
        public void GivenCSVFile_CheckifNumberofRecordsMatch()
        {  censusAnalyzer.keyValuePairs =censusAnalyzer.CensusData(path + file, "State,Population,AreaInSqKm,DensityPerSqKm");
            Assert.AreEqual(29, censusAnalyzer.keyValuePairs.Count);
        }

        // TC 1.2: Given the State Census CSV File if incorrect Returns a custom Exception
        [Test]
        public void GivenIncorrectFileName_ReturnCustomException()
        {
            CensusCustomException Exception = Assert.Throws<CensusCustomException>(() => censusAnalyzer.CensusData(path + file + "c", "State,Population,AreaInSqKm,DensityPerSqKm"));
            Assert.AreEqual(CensusCustomException.ExceptionType.File_Not_Found, Exception);
        }

        // TC 1.3: Given the State Census CSV File when correct but type incorrect Returns a custom Exception
        [Test]
        public void GivenIncorrectType_ReturnsCustomException()
        {
            CensusCustomException Exception = Assert.Throws<CensusCustomException>(() => censusAnalyzer.CensusData(path + InvalidFile, "State,Population,AreaInSqKm,DensityPerSqKm"));
            Assert.AreEqual(CensusCustomException.ExceptionType.Invalid_File_Type, Exception);
        }

        // TC 1.4: Given the State Census CSV File when correct but delimiter incorrect Returns a custom Exception
        [Test]
        public void GivenIncorrectDelimiter_ReturnsCustomException()
        {
            CensusCustomException Exception = Assert.Throws<CensusCustomException>(() => censusAnalyzer.CensusData(path + InvalidDelimiter, "State,Population,AreaInSqKm,DensityPerSqKm"));
            Assert.AreEqual(CensusCustomException.ExceptionType.Invalid_Delimeter, Exception);
        }
        /// <summary>
        /// TC1.5:-Check header is correct or not
        /// </summary>
        [Test]
        public void GivenIncorrectHeader_ReturnsCustomException()
        {
            CensusCustomException Exception = Assert.Throws<CensusCustomException>(() => censusAnalyzer.CensusData(path + InvalidHeader, "State,Population,AreaInSqKm,DensityPerSqKm"));
            Assert.AreEqual(CensusCustomException.ExceptionType.Incorrect_Header, Exception);
        }

    }
}