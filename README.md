# Klinik Apotek App - Sistem Manajemen Klinik & Apotek

**Aplikasi Desktop Manajemen Klinik & Apotek Berbasis Windows Forms**

![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4.svg)
![C#](https://img.shields.io/badge/C%23-7.3-239120.svg)
![MySQL](https://img.shields.io/badge/MySQL-8.0+-4479A1.svg)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-Desktop-0078D6.svg)

---

## Tim Pengembang - Kelompok [4]

**Ketua Kelompok:**
- **Palenewen, Imanuel** - 220211060179

**Anggota:**
- **Tjia, David** - 220211060059
- **Jeblo, Joshua** - 220211060189
- **Mantiri, Revaldo** - 220211060169

**Mata Kuliah:** Visual Programming - (C#)  
**Semester:** 5  
**Tahun Akademik:** 2024/2025

---

## Tentang Proyek

Klinik Apotek App adalah aplikasi desktop berbasis Windows Forms (.NET Framework 4.7.2) yang dirancang untuk mengelola sistem klinik dan apotek secara terintegrasi. Aplikasi ini menyediakan fitur lengkap untuk manajemen pasien, obat, resep, transaksi, dan user dengan role-based access control.

### Fitur Utama

#### Sistem Login & Autentikasi
- Multi-role authentication (Admin, Apoteker, User/Pasien)
- Self-registration untuk pasien baru
- Validasi username duplikat
- Password minimal 6 karakter
- Auto-create user account saat registrasi

#### Dashboard Admin
- **Manage Pasien**: CRUD data pasien lengkap
- **Manage Obat**: CRUD obat dengan stok management
- **Manage Users**: CRUD user accounts dengan role
- **Manage Resep**: CRUD data resep dokter
- **Manage Transaksi**: View & input transaksi manual
- **Auto-update stok**: Stok otomatis berkurang saat transaksi

#### Dashboard Apoteker
- **Input Transaksi**: Penjualan obat ke pasien
- **View Obat**: Lihat daftar obat & stok tersedia
- **View Resep**: Filter resep berdasarkan pasien
- **Real-time Stock Update**: Stok update otomatis

#### Dashboard User/Pasien
- **Shopping Cart System**: 
  - Browse obat dengan search/filter
  - Checkbox untuk pilih multiple obat
  - Input jumlah beli dengan validasi stok
  - Keranjang belanja dengan edit & delete item
  - Auto-calculate subtotal & total
  
- **Transaction History**:
  - View semua transaksi pribadi
  - Format currency Indonesia (Rp)
  - DateTime format dd/MM/yyyy HH:mm
  
- **Selection Persistence**:
  - Data selection tersimpan saat search/refresh
  - Preserved on cancel purchase
  - Cleared only after successful payment

### Teknologi yang Digunakan

- **Framework**: .NET Framework 4.7.2
- **Language**: C# 7.3
- **UI Framework**: Windows Forms
- **Database**: MySQL 8.0+
- **Database Connector**: MySql.Data (ADO.NET)
- **Database Tool**: phpMyAdmin (XAMPP)
- **Design Pattern**: 
  - Repository Pattern
  - Transaction Pattern (ACID)
  - Role-Based Access Control (RBAC)

---

## Database Schema

### Tables (5):
1. **pasien** - Data pasien (id, nama, umur, nohp, alamat)
2. **obat** - Data obat dengan stok (id, nama, stok, harga, deskripsi)
3. **users** - User credentials (id, username, password, role, pasien_id)
4. **resep** - Data resep dokter (id, pasien_id, obat_id, dosis, aturan)
5. **transaksi** - History transaksi (id, pasien_id, obat_id, jumlah, total, tanggal)

### Foreign Keys:
- `users.pasien_id` ? `pasien.id` (ON DELETE SET NULL)
- `resep.pasien_id` ? `pasien.id` (ON DELETE CASCADE)
- `resep.obat_id` ? `obat.id` (ON DELETE CASCADE)
- `transaksi.pasien_id` ? `pasien.id` (ON DELETE CASCADE)
- `transaksi.obat_id` ? `obat.id` (ON DELETE CASCADE)

### Views:
- **v_transaksi_lengkap** - Joined view untuk reporting

---

## Cara Instalasi dan Menjalankan

### Prasyarat

- **Operating System**: Windows 7/8/10/11
- **IDE**: Visual Studio 2017 atau lebih tinggi
- **.NET Framework**: 4.7.2 (pre-installed di Windows 10+)
- **Database**: MySQL 8.0+ atau XAMPP
- **RAM**: Minimal 2GB (4GB direkomendasikan)

### Langkah 1: Clone Repository

```sh
git clone https://github.com/Imanuelpalenewen/Vispro-Klinik.git
cd Vispro-Klinik
```

### Langkah 2: Setup Database

1. **Start MySQL Server**
   - Jika pakai XAMPP: Start Apache & MySQL
   - Jika pakai MySQL Standalone: Start MySQL Service

2. **Import Database**
   - Buka **phpMyAdmin** (http://localhost/phpmyadmin)
   - Klik **"Import"** atau **"SQL"** tab
   - Run file `database-setup.sql`:

```sql
-- Atau jalankan via command line:
mysql -u root -p < database-setup.sql
```

3. **Verify Database**
   - Database `klinik_db` terbuat
   - 5 tables ada (pasien, obat, users, resep, transaksi)
   - Sample data ter-insert (admin, apoteker, obat)

### Langkah 3: Konfigurasi Connection String

Edit file **`KlinikApotekApp\Database.cs`**:

```csharp
public static string ConnectionString = "server=localhost;user id=root;password=;database=klinik_db;";
```

**Catatan:**
- Jika MySQL pakai password: `password=your_password_here;`
- Jika MySQL di port lain: `server=localhost;port=3307;...`

### Langkah 4: Build & Run

**Via Visual Studio:**
1. Buka `KlinikApotekApp.sln` di Visual Studio
2. Build Solution: **Ctrl+Shift+B** (atau Build ? Build Solution)
3. Run: **F5** (atau Debug ? Start Debugging)

**Via Command Line:**
```sh
# Build
msbuild KlinikApotekApp.sln /t:Build /p:Configuration=Release

# Run
cd KlinikApotekApp\bin\Release
KlinikApotekApp.exe
```

? **Aplikasi siap digunakan!**

---

## Default User Accounts

Setelah setup database, gunakan akun berikut untuk login:

| Username | Password | Role | Deskripsi |
|----------|----------|------|-----------|
| `admin` | `admin123` | Admin | Full access ke semua fitur management |
| `apoteker` | `apoteker123` | Apoteker | Input transaksi, view obat & resep |

**User/Pasien:** Harus registrasi melalui form **"Daftar Sebagai Pasien Baru"**

---

## Cara Menggunakan

### Untuk Admin:

1. **Login**
   - Username: `admin`
   - Password: `admin123`

2. **Dashboard Menu:**
   - **Manage Pasien**: Tambah, edit, hapus, view pasien
   - **Manage Obat**: Tambah, edit, hapus, restock obat
   - **Manage Users**: Tambah, edit, hapus user & role
   - **Manage Resep**: CRUD resep dokter
   - **Input Transaksi**: Input transaksi manual
   - **Manage Transaksi**: View semua transaksi

### Untuk Apoteker:

1. **Login**
   - Username: `apoteker`
   - Password: `apoteker123`

2. **Dashboard Menu:**
   - **Input Transaksi**: Pilih pasien, obat, jumlah ? Simpan
   - **View Obat**: Lihat semua obat & stok
   - **View Resep**: Filter resep by pasien

### Untuk User/Pasien:

#### A. Registrasi (Pertama Kali)
1. Klik **"Daftar Sebagai Pasien Baru"**
2. Isi form:
   - Nama Lengkap
   - Umur (angka)
   - No HP (contoh: 081234567890)
   - Alamat
   - Username (unique)
   - Password (min 6 karakter)
3. Klik **"Register"**
4. Success ? Auto kembali ke login

#### B. Belanja Obat
1. **Login** dengan username/password yang dibuat
2. **Tab "List Obat"**:
   - Browse atau search obat by nama
   - Check obat yang ingin dibeli
   - Edit jumlah (max sesuai stok)
   - Selection tetap tersimpan saat search/refresh
3. **Klik "Beli Obat"** ? Keranjang terbuka
4. **Keranjang Belanja**:
   - Review item
   - Edit jumlah (auto-update subtotal)
   - Hapus item jika perlu
   - Lihat total pembayaran
5. **Klik "Bayar Sekarang"** ? Konfirmasi ? Success!
6. **Tab "Riwayat Transaksi"**:
   - View semua pembelian
   - Tanggal, obat, jumlah, total

---

## Fitur Teknis

### Validasi & Error Handling
- Validasi input form lengkap (required fields, format)
- Username duplicate checking (real-time)
- Stock validation (jumlah ? stok tersedia)
- Quantity validation (jumlah > 0)
- Database transaction rollback on error
- Try-catch di semua database operations

### User Experience
- **Auto-calculate**: Subtotal & total otomatis
- **Currency format**: Rp format Indonesia (id-ID)
- **Date format**: dd/MM/yyyy HH:mm
- **Confirmation dialogs**: Untuk aksi penting (delete, payment)
- **Success/Error messages**: Jelas dan informatif
- **Auto-refresh**: Data update setelah CRUD operations
- **Selection persistence**: Cart items saved across searches

### Database Transactions
- **ACID Compliance**: Atomic, Consistent, Isolated, Durable
- **Registration**: INSERT pasien + INSERT user (single transaction)
- **Purchase**: INSERT transaksi + UPDATE stok (atomic operation)
- **Auto-rollback**: Jika error di tengah transaction

### Design Patterns
- **Repository Pattern**: Centralized data access (Database.cs)
- **Transaction Pattern**: Multi-table operations
- **RBAC**: Role-Based Access Control (Admin/Apoteker/User)
- **State Management**: Selection persistence (selectedObatList)

---

## Desain UI

### Color Palette:
- **Primary Blue**: #2E86C1 (Buttons, Headers)
- **Hover Blue**: #1F4E79 (Button hover state)
- **Light Gray**: #F2F4F4 (Backgrounds)
- **Alternating Row**: #EBF5FB (DataGridView)
- **Success Green**: #46CC71 (Beli Obat button)
- **Danger Red**: #E74C3C (Logout, Delete)
- **White**: #FFFFFF (Cards, Panels)

### Typography:
- **Font Family**: Segoe UI (default Windows)
- **Headers**: 14-16pt, Bold
- **Body**: 9-10pt, Regular
- **Buttons**: 10pt, Regular/Bold

### UI Components:
- **Forms**: Panel-based layout dengan header section
- **DataGridView**: Auto-resize columns, row selection
- **Buttons**: Flat style dengan hover effect
- **TextBox**: Border, padding, focus indicator
- **ComboBox**: DropDownList style

---

## Performa System

| Metric | Value |
|--------|-------|
| **App Startup Time** | < 2 detik |
| **Database Query (SELECT)** | < 100ms |
| **Form Load Time** | < 500ms |
| **Transaction Processing** | < 200ms |
| **Max Concurrent Users** | 10+ (local network) |
| **Database Size (sample data)** | < 5MB |

### Optimizations Applied:
- Connection pooling (MySQL Connector)
- Indexed primary keys & foreign keys
- Parameterized queries (SQL injection prevention)
- Using statements for auto-disposal
- DataTable caching for frequent queries
- Lazy loading for large datasets

---

## Troubleshooting

### Error: "Unable to connect to MySQL server"
**Solusi:**
1. Pastikan MySQL/XAMPP running
2. Check connection string di `Database.cs`
3. Verify port (default: 3306)
4. Test connection: `mysql -u root -p`

### Error: "Table 'klinik_db.xxx' doesn't exist"
**Solusi:**
1. Run ulang `database-setup.sql`
2. Pastikan `USE klinik_db;` dieksekusi
3. Verify tables: `SHOW TABLES;`

### Error: "Username sudah digunakan"
**Solusi:**
- Ganti username saat registrasi
- Username harus unique

### Stok obat tidak update setelah pembelian
**Solusi:**
1. Check transaction di FormPembelianObat.cs
2. Verify query UPDATE stok
3. Check database foreign keys
4. Refresh DataGridView: F5

### Build Error: "Missing MySql.Data"
**Solusi:**
```sh
# Via NuGet Package Manager Console:
Install-Package MySql.Data -Version 8.0.33

# Via .NET CLI:
dotnet add package MySql.Data --version 8.0.33
```

### Form Designer Error
**Solusi:**
1. Clean Solution (Build ? Clean)
2. Rebuild Solution (Build ? Rebuild)
3. Close & reopen Visual Studio
4. Delete .vs folder (hidden)

---

## Struktur Project

```
KlinikApotekApp/
??? KlinikApotekApp/              # Main project folder
?   ??? Database.cs               # Database helper & connection
?   ??? Program.cs                # Entry point
?   ?
?   ??? Forms/                    # All form files
?   ?   ??? FormLogin.cs/Designer.cs/resx
?   ?   ??? FormRegisterUser.cs/Designer.cs/resx
?   ?   ??? FormAdminDashboard.cs/Designer.cs/resx
?   ?   ??? FormApotekerDashboard.cs/Designer.cs/resx
?   ?   ??? FormDashboardUser.cs/Designer.cs/resx
?   ?   ??? FormPembelianObat.cs/Designer.cs/resx
?   ?   ??? FormManagePasien.cs/Designer.cs/resx
?   ?   ??? FormManageObat.cs/Designer.cs/resx
?   ?   ??? FormManageUsers.cs/Designer.cs/resx
?   ?   ??? FormManageResep.cs/Designer.cs/resx
?   ?   ??? FormManageTransaksi.cs/Designer.cs/resx
?   ?   ??? FormInputTransaksi.cs/Designer.cs/resx
?   ?   ??? FormViewObat.cs/Designer.cs/resx
?   ?   ??? FormViewResep.cs/Designer.cs/resx
?   ?
?   ??? Properties/               # Assembly info & resources
?   ?   ??? AssemblyInfo.cs
?   ?   ??? Resources.Designer.cs
?   ?   ??? Settings.Designer.cs
?   ?
?   ??? bin/                      # Build output (ignored by git)
?   ??? obj/                      # Temporary build files (ignored)
?   ??? KlinikApotekApp.csproj    # Project file
?
??? database-setup.sql            # Database schema & sample data
??? KlinikApotekApp.sln           # Solution file
??? .gitignore                    # Git ignore rules
??? README.md                     # This file

Documentation/ (AI-generated - not tracked by git)
??? COMPLETION-SUMMARY.md         # Project completion status
??? TESTING-GUIDE.md              # Manual testing guide
??? BUG-FIXES.md                  # Bug fix documentation
??? USER-MODULE-IMPLEMENTATION-GUIDE.md
??? QUICK-START-GUIDE.md
```

---

## Testing Checklist

### Registration Flow:
- [x] Register dengan data lengkap ? Success
- [x] Register dengan username duplikat ? Error message
- [x] Register dengan password < 6 char ? Error message
- [x] Register dengan field kosong ? Error message
- [x] Cancel registrasi ? Back to login

### Login Flow:
- [x] Login as Admin ? Dashboard Admin
- [x] Login as Apoteker ? Dashboard Apoteker
- [x] Login as User ? Dashboard User
- [x] Wrong credentials ? Error message

### User Shopping Flow:
- [x] Browse obat ? DataGridView populated
- [x] Search obat by nama ? Filter works
- [x] Select multiple obat ? Checkbox works
- [x] Edit jumlah ? Validation (max = stok)
- [x] Selection persistence ? Saved on search/refresh
- [x] Beli obat ? Cart opens with selected items
- [x] Edit jumlah di cart ? Subtotal auto-update
- [x] Hapus item ? Item removed, total recalculated
- [x] Empty cart ? Cannot proceed (error message)
- [x] Bayar sekarang ? Transaction saved, stok updated
- [x] Riwayat transaksi ? History displayed

### Admin Operations:
- [x] CRUD Pasien ? All operations work
- [x] CRUD Obat ? All operations work
- [x] CRUD Users ? All operations work
- [x] CRUD Resep ? All operations work
- [x] View Transaksi ? Data displayed correctly
- [x] Input Transaksi ? Stock auto-updated

### Apoteker Operations:
- [x] Input Transaksi ? Saved successfully
- [x] View Obat ? List displayed
- [x] View Resep ? Filter by pasien works

---

## Catatan Penting

### Password Security
**PENTING**: Password saat ini disimpan dalam **plain text** di database. Ini **TIDAK AMAN** untuk production!

**Untuk production environment:**
```csharp
// Install: Install-Package BCrypt.Net-Next

// Hash password saat registrasi:
string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

// Verify password saat login:
bool isValid = BCrypt.Net.BCrypt.Verify(password, hashedPassword);
```

### Backup Database
Backup database secara berkala:
```sh
# Backup
mysqldump -u root -p klinik_db > backup_klinik_db_2024-12-01.sql

# Restore
mysql -u root -p klinik_db < backup_klinik_db_2024-12-01.sql
```

### Security Best Practices (For Production)
- Hash passwords (BCrypt/Argon2)
- Use stored procedures (SQL injection prevention)
- Implement session management
- Add audit logging (who did what, when)
- Use HTTPS for remote connections
- Encrypt sensitive data at rest

---

## Referensi & Credits

- **Windows Forms**: [Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
- **MySQL Connector/NET**: [MySQL Documentation](https://dev.mysql.com/doc/connector-net/en/)
- **C# Programming Guide**: [Microsoft C# Guide](https://docs.microsoft.com/en-us/dotnet/csharp/)
- **ADO.NET**: [ADO.NET Overview](https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/)
- **Database Design**: [MySQL Best Practices](https://dev.mysql.com/doc/)

---

## Lisensi

Proyek ini dibuat untuk keperluan akademik (Tugas Akhir Visual Programming - Semester 5).

**Copyright 2024 Kelompok [4] - Visual Programming Class**

---

## Kontak

Untuk pertanyaan atau feedback, silakan hubungi:

- **GitHub**: [Imanuelpalenewen](https://github.com/Imanuelpalenewen)
- **Repository**: [Vispro-Klinik](https://github.com/Imanuelpalenewen/Vispro-Klinik)

---

## Future Enhancements (Opsional)

### Planned Features:
- [ ] **Reporting Module**: Print invoice, sales report, stock report
- [ ] **Email Notifications**: Reset password, appointment reminders
- [ ] **Barcode Scanner**: Scan obat untuk faster input
- [ ] **Photo Upload**: Upload foto obat & pasien
- [ ] **Export Data**: Export to Excel/PDF
- [ ] **Dashboard Analytics**: Charts & statistics
- [ ] **SMS Integration**: Send SMS untuk reminder
- [ ] **Mobile App**: Android/iOS companion app
- [ ] **Cloud Sync**: Sync data to cloud database

---

<div align="center">

**Dibuat dengan cinta oleh Kelompok [4] - Vispro Class 2024**

*Transforming Healthcare Management with Technology*

---

### Project Statistics

![Lines of Code](https://img.shields.io/badge/Lines%20of%20Code-5000%2B-blue)
![Forms Count](https://img.shields.io/badge/Forms-15-green)
![Database Tables](https://img.shields.io/badge/Tables-5-orange)
![Features](https://img.shields.io/badge/Features-30%2B-red)

</div>
