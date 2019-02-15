using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfToDB
{
   
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        int MusteriEkle(Musteri m);

        [OperationContract]
        int MusteriSil(Musteri m);

        [OperationContract]
        DataTable MusteriGetir(Musteri m);
        
    }

    
    
}
