const int hargaAdministrasi = 2000;
Console.WriteLine("=== RINCIAN PENCETAKAN ===");

string nama = "andi";
Console.WriteLine("Nama pelanggan: " + nama);

int jumlahhalamanyangdicetak = 20;
Console.WriteLine("Jumlah halaman yang di cetak: " + jumlahhalamanyangdicetak);

int hargaPerhalaman = 500;
Console.WriteLine("Harga per halaman: " + hargaPerhalaman);
int subtotal = hargaPerhalaman * jumlahhalamanyangdicetak;
Console.WriteLine("subtotal:" + subtotal);

Console.WriteLine("Harga administrasi: " + hargaAdministrasi);
int total = subtotal + hargaAdministrasi;
Console.WriteLine("Total yang harus dibayar: " + total);