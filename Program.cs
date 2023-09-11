namespace Diziler{


class program{
    
    static void Main(string[] args){


        string[] renkler=new string[5];
        string[] hayvanlar= {"Kedi","Köpek","Aslan","Timsah"};
        int[] dizi=new int[5];
        //dizilere değer atama

        renkler[0]="Mavi";
        dizi[3]=10;
        // Console.WriteLine(hayvanlar[1]);
        // Console.WriteLine(renkler[0]);
        // Console.WriteLine(dizi[3]);


        //Dönghülerde dizi kullanımı
            //klavyedeb girilen n tane sayının ortalamasını hesaplayan program
        Console.Write("Dizinin Eleman Sayısını Giriniz : ");

        int dizi_uzunlugu=int.Parse(Console.ReadLine());
        
        int[] sayidizisi=new int[dizi_uzunlugu];

        for (int i = 0; i < dizi_uzunlugu; i++)
        {
            Console.Write("Lütfen {0} sayiyi giriniz.", i+1);

            sayidizisi[i]=int.Parse(Console.ReadLine());
        }
        
        int toplam=0;
        foreach (var sayi in sayidizisi)
        {
            toplam+=sayi;
        }

        Console.WriteLine("Ortalama :  "+toplam/dizi_uzunlugu);

    }
}

}