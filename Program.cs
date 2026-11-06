const int hargaAdministrasi = 2000;

Console.WriteLine("=== RINCIAN PENCETAKAN ===");

Console.WriteLine("Masukkan nama pelanggan:");
string nama = Console.ReadLine();
Console.WriteLine("Nama pelanggan: " + nama);

Console.WriteLine("Masukkan jumlah halaman yang di cetak:");
int jumlahhalamanyangdicetak = int.Parse(Console.ReadLine());
Console.WriteLine("Jumlah halaman yang di cetak: " + jumlahhalamanyangdicetak);

int hargaPerhalaman = 500;
Console.WriteLine("Harga per halaman: " + hargaPerhalaman);
int subtotal = hargaPerhalaman * jumlahhalamanyangdicetak;
Console.WriteLine("subtotal:" + subtotal);

Console.WriteLine("Harga administrasi: " + hargaAdministrasi);
int total = subtotal + hargaAdministrasi;
Console.WriteLine("Total yang harus dibayar: " + total);