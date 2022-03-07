using AbstractFactory.Class;
using AbstractFactory.Interface;
using System;

namespace AbstractFactory
{
    class Program
    {//ilişkili sınıfların oluşturulmasında kullanılır.Farklı ürünlerin fabrikalarının soyutlaması olarak tanımlanabilir.Tekrar eden if else yapısından kurtarır.
        //kısaca her ürünün kendi fabrikası var
        static void Main(string[] args)
        {
            ITeam besiktas = TeamFactory.GetTeam(new BesiktasFaktory());
            Console.WriteLine("Beşiktaşın stadı:{0},renkleri{1}",besiktas.getStadium(),besiktas.getTeamColor());

            ITeam galatasaray = TeamFactory.GetTeam(new GalatasarayFactory());
            Console.WriteLine("Galatasaray stadı:{0},renkleri{1}", galatasaray.getStadium(), galatasaray.getTeamColor());
        }
    }
}
