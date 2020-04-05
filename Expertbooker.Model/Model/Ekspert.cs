namespace EkspertBooker.Model
{
    public class Ekspert
    {
        public int KorisnikId { get; set; }
        public int KorisnikUlogaId { get; set; }
        public KorisnikUloga KorisnikUloga { get; set; }
        public Korisnik Korisnik { get; set; }
        public float? ProsjecnaOcjena { get; set; }
        public int BrojZavrsenihProjekata { get; set; }
        public int BrojRecenzija { get; set; }

        public int EkspertStrucnaKategorijaId { get; set; }
        public Kategorija EkspertStrucnaKategorija { get; set; }
        public bool? Notifikacije { get; set; }
    }
}