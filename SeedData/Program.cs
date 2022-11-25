// See https://aka.ms/new-console-template for more information
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

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

List<Product> products = new List<Product>() {
                new Product {  ProductTypeID = 1, ProductName = "Antrikot", UnitCalorie = 1.21, Image = ReadFile("Resources/antrikot.png") },
                new Product {  ProductTypeID = 1, ProductName = "Bonfile", UnitCalorie = 1.38, Image = ReadFile("Resources/bonfile.png") },
                new Product {  ProductTypeID = 1, ProductName = "Biftek", UnitCalorie = 2.42, Image = ReadFile("Resources/biftek.png") },
                new Product {  ProductTypeID = 1, ProductName = "Dana Kıyma", UnitCalorie = 2.46, Image = ReadFile("Resources/dana kıyma.png") },
                new Product {  ProductTypeID = 1, ProductName = "Hindi Budu", UnitCalorie = 2.08, Image = ReadFile("Resources/hindi budu.png") },
                new Product {  ProductTypeID = 1, ProductName = "Hindi Göğsü", UnitCalorie = 1.35, Image = ReadFile("Resources/hindi göğüs.png") },
                new Product {  ProductTypeID = 1, ProductName = "Hindi Kanadı", UnitCalorie = 2.21, Image = ReadFile("Resources/hindi kanat.png") },
                new Product {  ProductTypeID = 1, ProductName = "Kuzu Pirzola", UnitCalorie = 2.76, Image = ReadFile("Resources/kuzu pirzola.png") },
                new Product {  ProductTypeID = 1, ProductName = "Kuzu İncik", UnitCalorie = 2.01, Image = ReadFile("Resources/kuzu incik.png") },
                new Product {  ProductTypeID = 1, ProductName = "Sığır Eti", UnitCalorie = 2.48, Image = ReadFile("Resources/sığır eti.png") },
                new Product {  ProductTypeID = 1, ProductName = "Sığır Filetosu", UnitCalorie = 2.18, Image = ReadFile("Resources/sığır filetosu.png") },
                new Product {  ProductTypeID = 1, ProductName = "Sığır Kaburgası", UnitCalorie = 2.38, Image = ReadFile("Resources/sığır kaburgası.png") },
                new Product {  ProductTypeID = 1, ProductName = "Tavuk But", UnitCalorie = 1.74, Image = ReadFile("Resources/tavuk but.png") },
                new Product {  ProductTypeID = 1, ProductName = "Tavuk Ciğeri", UnitCalorie = 1.67, Image = ReadFile("Resources/tavuk ciğer.png") },
                new Product {  ProductTypeID = 1, ProductName = "Tavuk Göğsü", UnitCalorie = 1.72, Image = ReadFile("Resources/tavuk göğsü.png") },
                new Product {  ProductTypeID = 1, ProductName = "Tavuk Kanadı", UnitCalorie = 2.66, Image = ReadFile("Resources/tavuk kanat.png") },
                new Product {  ProductTypeID = 1, ProductName = "Tavuk Taşlığı", UnitCalorie = 1.46, Image = ReadFile("Resources/tavuk taşlık.png") },
                new Product {  ProductTypeID = 1, ProductName = "Tavuk Yağı", UnitCalorie = 8.98, Image = ReadFile("Resources/tavuk yağı.png") },
                new Product {  ProductTypeID = 1, ProductName = "Ördek", UnitCalorie = 3.37, Image = ReadFile("Resources/ördek.png") },
                new Product {  ProductTypeID = 1, ProductName = "Şinitzel", UnitCalorie = 1.56, Image = ReadFile("Resources/şinitzel.png") },
                new Product {  ProductTypeID = 2, ProductName = "Alabalık", UnitCalorie = 1.90, Image = ReadFile("Resources/alabalık.png") },
                new Product {  ProductTypeID = 2, ProductName = "Havyar", UnitCalorie = 2.64, Image = ReadFile("Resources/havyar.png") },
                new Product {  ProductTypeID = 2, ProductName = "Lüfer", UnitCalorie = 1.59, Image = ReadFile("Resources/lüfer.png") },
                new Product {  ProductTypeID = 2, ProductName = "Mezgit", UnitCalorie = 0.90, Image = ReadFile("Resources/mezgit.png") },
                new Product {  ProductTypeID = 2, ProductName = "Midye", UnitCalorie = 1.72, Image = ReadFile("Resources/midye.png") },
                new Product {  ProductTypeID = 2, ProductName = "Ton Balığı", UnitCalorie = 1.32, Image = ReadFile("Resources/ton balığı.png") },
                new Product {  ProductTypeID = 2, ProductName = "Uskumru", UnitCalorie = 2.62, Image = ReadFile("Resources/uskumru.png") },
                new Product {  ProductTypeID = 2, ProductName = "Çipura", UnitCalorie = 1.35, Image = ReadFile("Resources/çipura.png") },
                new Product {  ProductTypeID = 2, ProductName = "Somon", UnitCalorie = 2.06, Image = ReadFile("Resources/somon.png") },
                new Product {  ProductTypeID = 2, ProductName = "Kalkan Balığı", UnitCalorie = 1.22, Image = ReadFile("Resources/kalkan balığı.png") },
                new Product {  ProductTypeID = 3, ProductName = "Cheddar Peyniri ", UnitCalorie = 4.03, Image = ReadFile("Resources/cheddar peyniri.png") },
                new Product {  ProductTypeID = 3, ProductName = "Hellim", UnitCalorie = 3.21, Image = ReadFile("Resources/hellim.png") },
                new Product {  ProductTypeID = 3, ProductName = "Kaşar Peyniri", UnitCalorie = 3.37, Image = ReadFile("Resources/kaşar peynir.png") },
                new Product {  ProductTypeID = 3, ProductName = "Tulum Peyniri", UnitCalorie = 3.63, Image = ReadFile("Resources/tulum peynir.png") },
                new Product {  ProductTypeID = 3, ProductName = "Yumuşak Peynir", UnitCalorie = 2.68, Image = ReadFile("Resources/yumuşak peynir.png") },
                new Product {  ProductTypeID = 3, ProductName = "Bazlama", UnitCalorie = 2.40, Image = ReadFile("Resources/bazlama.png") },
                new Product {  ProductTypeID = 3, ProductName = "Beyaz Ekmek", UnitCalorie = 2.38, Image = ReadFile("Resources/beyaz ekmek.png") },
                new Product {  ProductTypeID = 3, ProductName = "Esmer Ekmek", UnitCalorie = 2.50, Image = ReadFile("Resources/esmer ekmek.png") },
                new Product {  ProductTypeID = 3, ProductName = "Hamburger Ekmeği", UnitCalorie = 1.78, Image = ReadFile("Resources/hamburger ekmeği.png") },
                new Product {  ProductTypeID = 3, ProductName = "Lavaş", UnitCalorie = 2.64, Image = ReadFile("Resources/lavaş.png") },
                new Product {  ProductTypeID = 3, ProductName = "Mısır Ekmeği", UnitCalorie = 1.79, Image = ReadFile("Resources/mısır ekmeği.png") },
                new Product {  ProductTypeID = 3, ProductName = "Tam Buğday Ekmek", UnitCalorie = 2.47, Image = ReadFile("Resources/tam buğday ekmek.png") },
                new Product {  ProductTypeID = 3, ProductName = "Zeytin Yağı", UnitCalorie = 8.84, Image = ReadFile("Resources/zeytin yağı.png") },
                new Product {  ProductTypeID = 3, ProductName = "Yeşil Zeytin", UnitCalorie = 1.15, Image = ReadFile("Resources/yeşil zeytin.png") },
                new Product {  ProductTypeID = 3, ProductName = "Siyah Zeytin", UnitCalorie = 1.15, Image = ReadFile("Resources/siyah zeytin.png") },
                new Product {  ProductTypeID = 3, ProductName = "Bal", UnitCalorie = 3.04, Image = ReadFile("Resources/bal.png") },
                new Product {  ProductTypeID = 3, ProductName = "Erik Reçeli", UnitCalorie = 2.50, Image = ReadFile("Resources/erik reçeli.png") },
                new Product {  ProductTypeID = 3, ProductName = "Fıstık Ezmesi", UnitCalorie = 5.89, Image = ReadFile("Resources/fıstık ezmesi.png") },
                new Product {  ProductTypeID = 3, ProductName = "Kayısı Reçeli", UnitCalorie = 2.50, Image = ReadFile("Resources/kayısı reçeli.png") },
                new Product {  ProductTypeID = 3, ProductName = "Yumurta", UnitCalorie = 0.97, Image = ReadFile("Resources/yumurta.png") },
                new Product {  ProductTypeID = 4, ProductName = "Bamya ", UnitCalorie = 0.33, Image = ReadFile("Resources/bamya.png") },
                new Product {  ProductTypeID = 4, ProductName = "Bezelye", UnitCalorie = 0.81, Image = ReadFile("Resources/bezelye.png") },
                new Product {  ProductTypeID = 4, ProductName = "Biber", UnitCalorie = 0.27, Image = ReadFile("Resources/biber.png") },
                new Product {  ProductTypeID = 4, ProductName = "Domates", UnitCalorie = 0.18, Image = ReadFile("Resources/domates.png") },
                new Product {  ProductTypeID = 4, ProductName = "Havuç", UnitCalorie = 0.41, Image = ReadFile("Resources/havuç.png") },
                new Product {  ProductTypeID = 4, ProductName = "Kırmızı Biber", UnitCalorie = 0.26, Image = ReadFile("Resources/kırmızı biber.png") },
                new Product {  ProductTypeID = 4, ProductName = "Kabak", UnitCalorie = 0.26, Image = ReadFile("Resources/kabak.png") },
                new Product {  ProductTypeID = 4, ProductName = "Lahana", UnitCalorie = 0.25, Image = ReadFile("Resources/lahana.png") },
                new Product {  ProductTypeID = 4, ProductName = "Mantar", UnitCalorie = 0.22, Image = ReadFile("Resources/mantar.png") },
                new Product {  ProductTypeID = 4, ProductName = "Mısır", UnitCalorie = 3.65, Image = ReadFile("Resources/mısır.png") },
                new Product {  ProductTypeID = 4, ProductName = "Patates", UnitCalorie = 0.77, Image = ReadFile("Resources/patates.png") },
                new Product {  ProductTypeID = 4, ProductName = "Patlıcan", UnitCalorie = 0.25, Image = ReadFile("Resources/patlıcan.png") },
                new Product {  ProductTypeID = 4, ProductName = "Pırasa", UnitCalorie = 0.61, Image = ReadFile("Resources/pırasa.png") },
                new Product {  ProductTypeID = 4, ProductName = "Salatalık", UnitCalorie = 1.49, Image = ReadFile("Resources/salatalık.png") },
                new Product {  ProductTypeID = 4, ProductName = "Soğan", UnitCalorie = 0.40, Image = ReadFile("Resources/soğan.png") },
                new Product {  ProductTypeID = 4, ProductName = "Sarımsak", UnitCalorie = 1.49, Image = ReadFile("Resources/sarımsak.png") },
                new Product {  ProductTypeID = 4, ProductName = "Turp", UnitCalorie = 0.28, Image = ReadFile("Resources/turp.png") },
                new Product {  ProductTypeID = 4, ProductName = "Marul", UnitCalorie = 0.22, Image = ReadFile("Resources/marul.png") },
                new Product {  ProductTypeID = 4, ProductName = "Roka", UnitCalorie = 0.25, Image = ReadFile("Resources/roka.png") },
                new Product {  ProductTypeID = 4, ProductName = "Kara Lahana", UnitCalorie = 0.32, Image = ReadFile("Resources/kara lahana.png") },
                new Product {  ProductTypeID = 5, ProductName = "Armut", UnitCalorie = 0.57, Image = ReadFile("Resources/armut.png") },
                new Product {  ProductTypeID = 5, ProductName = "Ayva", UnitCalorie = 0.57, Image = ReadFile("Resources/ayva.png") },
                new Product {  ProductTypeID = 5, ProductName = "Elma", UnitCalorie = 0.52, Image = ReadFile("Resources/elma.png") },
                new Product {  ProductTypeID = 5, ProductName = "Erik", UnitCalorie = 0.46, Image = ReadFile("Resources/erik.png") },
                new Product {  ProductTypeID = 5, ProductName = "Hurma", UnitCalorie = 2.82, Image = ReadFile("Resources/hurma.png") },
                new Product {  ProductTypeID = 5, ProductName = "İncir", UnitCalorie = 0.74, Image = ReadFile("Resources/incir.png") },
                new Product {  ProductTypeID = 5, ProductName = "Muz", UnitCalorie = 0.89, Image = ReadFile("Resources/muz.png") },
                new Product {  ProductTypeID = 5, ProductName = "Karpuz", UnitCalorie = 0.30, Image = ReadFile("Resources/karpuz.png") },
                new Product {  ProductTypeID = 5, ProductName = "Kayısı", UnitCalorie = 0.48, Image = ReadFile("Resources/kayısı.png") },
                new Product {  ProductTypeID = 5, ProductName = "Kiraz", UnitCalorie = 0.50, Image = ReadFile("Resources/kiraz.png") },
                new Product {  ProductTypeID = 5, ProductName = "Kivi", UnitCalorie = 0.61, Image = ReadFile("Resources/kivi.png") },
                new Product {  ProductTypeID = 5, ProductName = "Nar", UnitCalorie = 0.83, Image = ReadFile("Resources/nar.png") },
                new Product {  ProductTypeID = 5, ProductName = "Portakal", UnitCalorie = 0.47, Image = ReadFile("Resources/portakal.png") },
                new Product {  ProductTypeID = 5, ProductName = "Çilek", UnitCalorie = 0.32, Image = ReadFile("Resources/çilek.png") },
                new Product {  ProductTypeID = 5, ProductName = "Üzüm", UnitCalorie = 0.69, Image = ReadFile("Resources/üzüm.png") },
                new Product {  ProductTypeID = 5, ProductName = "Şeftali", UnitCalorie = 0.39, Image = ReadFile("Resources/şeftali.png") },
                new Product {  ProductTypeID = 6, ProductName = "Bulgur Pilavı", UnitCalorie = 2.15 },
                new Product {  ProductTypeID = 6, ProductName = "Bezelye Çorbası", UnitCalorie = 0.75, Image = ReadFile("Resources/bezelye çorbası.png") },
                new Product {  ProductTypeID = 6, ProductName = "Karnıyarık", UnitCalorie = 1.34, Image = ReadFile("Resources/karnıyarık.png") },
                new Product {  ProductTypeID = 6, ProductName = "Kıymalı/Etli Pide", UnitCalorie = 2.97, Image = ReadFile("Resources/kıymalı etli pide.png") },
                new Product {  ProductTypeID = 6, ProductName = "Patates Püresi", UnitCalorie = 0.83, Image = ReadFile("Resources/patates püresi.png") },
                new Product {  ProductTypeID = 6, ProductName = "Pirinç Pilav", UnitCalorie = 3.52, Image = ReadFile("Resources/pirinç pilavı.png") },
                new Product {  ProductTypeID = 6, ProductName = "Pizza", UnitCalorie = 2.67, Image = ReadFile("Resources/pizza.png") },
                new Product {  ProductTypeID = 6, ProductName = "Yaprak Sarması", UnitCalorie = 1.41, Image = ReadFile("Resources/yaprak sarma.png") },
                new Product {  ProductTypeID = 6, ProductName = "Rulo Köfte", UnitCalorie = 2.54, Image = ReadFile("Resources/rulo köfte.png") },
                new Product {  ProductTypeID = 6, ProductName = "Peynirli Makarna", UnitCalorie = 3.70, Image = ReadFile("Resources/peynirli makarna.png") },
                new Product {  ProductTypeID = 6, ProductName = "Kurufasulye", UnitCalorie = 0.94, Image = ReadFile("Resources/kuru fasulye.png") },
                new Product {  ProductTypeID = 6, ProductName = "Hünkar Beğendi", UnitCalorie = 1.74 },
                new Product {  ProductTypeID = 6, ProductName = "Kebap", UnitCalorie = 2.15, Image = ReadFile("Resources/kebap.png") }};

Console.WriteLine(products.Count);

foreach (var item in products)
{
    p.Add(item);
    Console.WriteLine("process...");
}
Console.WriteLine("DONE");
Console.ReadKey();