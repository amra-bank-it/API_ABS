using API_ABS.Models;

namespace API_ABS.Business.GetAccountStatement
{
    public class AccStatement
    {

        public void Get(string Acc)
        {
            Documents doc = new Documents();

            using (var db = doc.)
            {
                var ResultDocs = db.Trns.Where(x => x.Ctrnaccd == Acc || x.Ctrnaccc == Acc).ToList();
                //TODO Должна быть функция проверки на пустышку

                foreach (var ResultDoc in ResultDocs)
                {

                    Documents 
                        
                }

                using (var BD = new ModelContext())
                {
                    //  BD.Trns.Where(x=>x.Ctrnaccc == Acc || x.ctr)



                    //  var ddd = db1.Cus.FirstOrDefault();
                    //  var aaa = db1.Trns.FirstOrDefault();
                    //  var vvv = db1.Accs.FirstOrDefault();
                    //  int t = 0;
                }
            }
        }
    }
}