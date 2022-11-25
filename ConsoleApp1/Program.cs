// See https://aka.ms/new-console-template for more information

using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.IdentityModel.Tokens;

static byte[] ReadFile(string sPath)
{
    //Initialize byte array with a null value initially.
    byte[] data = null;

    //Use FileInfo object to get file size.
    FileInfo fInfo = new FileInfo(sPath);
    long numBytes = fInfo.Length;

    //Open FileStream to read file
    FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

    //Use BinaryReader to read file stream into byte array.
    BinaryReader br = new BinaryReader(fStream);

    //When you use BinaryReader, you need to supply number of bytes
    //to read from file.
    //In this case we want to read entire file. 
    //So supplying total number of bytes.
    data = br.ReadBytes((int)numBytes);
    fStream.Close();
    br.Close();
    return data;
}


ProductDal p = new();



p.Add(new Product { ProductTypeID = 6, ProductName = "Kıymalı/Etli Pide", UnitCalorie = 2.97});
p.Add(new Product { ProductTypeID = 6, ProductName = "Patates Püresi", UnitCalorie = 0.83 });
p.Add(new Product { ProductTypeID = 6, ProductName = "Pirinç Pilav", UnitCalorie = 3.52 });
p.Add(new Product { ProductTypeID = 6, ProductName = "Pizza", UnitCalorie = 2.67 });
p.Add(new Product { ProductTypeID = 6, ProductName = "Yaprak Sarması", UnitCalorie = 1.41});
p.Add(new Product { ProductTypeID = 6, ProductName = "Rulo Köfte", UnitCalorie = 2.54 });
p.Add(new Product { ProductTypeID = 6, ProductName = "Peynirli Makarna", UnitCalorie = 3.70 });
p.Add(new Product { ProductTypeID = 6, ProductName = "Kurufasulye", UnitCalorie = 0.94 });
p.Add(new Product { ProductTypeID = 6, ProductName = "Hünkar Beğendi", UnitCalorie = 1.74 });
p.Add(new Product { ProductTypeID = 6, ProductName = "Kebap", UnitCalorie = 2.15 });

Console.WriteLine("Bitti");
Console.ReadKey();
