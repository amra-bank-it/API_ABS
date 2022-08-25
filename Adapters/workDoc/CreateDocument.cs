using API_ABS.Adapters.workDoc.Models;
using API_ABS.Models;
using Oracle.ManagedDataAccess.Client;

namespace API_ABS.Adapters.workDoc
{
  public class CreateDocument
  {
    private DocumentABS inDoc;
    private SourceABS_DB inABS_BASE;
      internal CreateDocument(DocumentABS _inDoc, SourceABS_DB _inABS_BASE)
    {
      inDoc = _inDoc;
      this.inABS_BASE = inABS_BASE;
    }
    public ResultImport SendToBank()
    {
      DocImport outDoc = new DocImport(inDoc);
      bool Error = false;
      string DescriptionImport = "";

      using (var DB  = inABS_BASE.ContextDB)
      {
        //TODO
        DB.Database.From

        //EXECUTE PPROCEDURE
        //EXECUTERESULT PROCEDURE

      }
      using (var ctx = new RAContext())
      {
        var projectNameParam = new OracleParameter("inProjectName", OracleDbType.Varchar2, projectName, ParameterDirection.Input);
        var countryCodeParam = new OracleParameter("inCountryCode", OracleDbType.Varchar2, countryCode, ParameterDirection.Input);
        var locationParam = new OracleParameter("inLocation", OracleDbType.Varchar2, location, ParameterDirection.Input);
        var assetRegisteredParam = new OracleParameter("OutAssetRegistered", OracleDbType.Varchar2, ParameterDirection.Output);

        var sql = "BEGIN RA.RA_RegisterAsset(:inProjectName, :inCountryCode, :inLocation, :OutAssetRegistered); END;";
        var result = ctx.Database.ExecuteSqlCommand(sql, projectNameParam, countryCodeParam, locationParam, assetRegisteredParam);

        assetRegistered = (string)assetRegisteredParam.Value;
      }

      ResultImport RES = new ResultImport(Error, DescriptionImport);
      
      return RES;
    }

  }
}
