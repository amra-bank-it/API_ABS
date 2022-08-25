namespace API_ABS.Adapters.workDoc.Models
{
  public class ResultImport
  {
    public ResultImport(bool error, string descriptionImport)
    {
      Error = error;
      DescriptionImport = descriptionImport;
    }

    public bool Error { get; }
    public string DescriptionImport { get; }
  }
}
