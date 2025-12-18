using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    public readonly string NationalID;

    public Person(string id)
    {
        NationalID = id; // sadece burada atanabilir
    }
}
/*
 readonly, bir değişkenin sadece nesne oluşturulurken (yani constructor içinde) atanabileceğini belirtir.
Nesne oluşturulduktan sonra bu değişkenin değeri değiştirilemez.
 readonly değişken isimleri genellikle Pascal Case ile yazılır: BirthDate, NationalID, SerialNumber gibi.
 */